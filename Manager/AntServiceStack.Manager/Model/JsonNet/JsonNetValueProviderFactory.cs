﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

namespace AntServiceStack.Manager.Model.JsonNet
{
    using System.Collections;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Web.Mvc;
    using Newtonsoft.Json;

    public class JsonNetValueProviderFactory : ValueProviderFactory
    {
        private void AddToBackingStore(Dictionary<string, object> backingStore, string prefix, object value)
        {
            IDictionary<string, object> d = value as IDictionary<string, object>;
            if (d != null)
            {
                foreach (KeyValuePair<string, object> entry in d)
                {
                    AddToBackingStore(backingStore, MakePropertyKey(prefix, entry.Key), entry.Value);
                }
                return;
            }

            IList l = value as IList;
            if (l != null)
            {
                for (int i = 0; i < l.Count; i++)
                {
                    AddToBackingStore(backingStore, MakeArrayKey(prefix, i), l[i]);
                }
                return;
            }

            // primitive
            backingStore[prefix] = value;
        }
        private object GetDeserializedObject(ControllerContext controllerContext)
        {
            if (!controllerContext.HttpContext.Request.ContentType.StartsWith("application/json", StringComparison.InvariantCultureIgnoreCase))
            {
                // not JSON request
                return null;
            }

           // StreamReader reader = new StreamReader(controllerContext.HttpContext.Request.InputStream);
            byte[] byts = new byte[controllerContext.HttpContext.Request.InputStream.Length];
            controllerContext.HttpContext.Request.InputStream.Read(byts, 0, byts.Length);
            string bodyText = System.Text.Encoding.UTF8.GetString(byts);
            //string bodyText = reader.ReadToEnd();
            if (String.IsNullOrEmpty(bodyText))
            {
                // no JSON data
                return null;
            }
            //接下来的代码是关键，判断content type，如果是json.net，那么就使用Json.Net的反序列化方法，如果不是，那么就使用系统默认的反序列化方法
            if (controllerContext.HttpContext.Request.ContentType.StartsWith("application/json.net", StringComparison.InvariantCultureIgnoreCase))
            {
                var jsonData = JsonConvert.DeserializeObject<ExpandoObject>(bodyText);
                return jsonData;
            }
            else
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                object jsonData = serializer.DeserializeObject(bodyText);
                return jsonData;
            }
        }
        public override IValueProvider GetValueProvider(ControllerContext controllerContext)
        {
            if (controllerContext == null)
            {
                throw new ArgumentNullException("controllerContext");
            }

            object jsonData = GetDeserializedObject(controllerContext);
            if (jsonData == null)
            {
                return null;
            }

            Dictionary<string, object> backingStore = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            AddToBackingStore(backingStore, String.Empty, jsonData);
            return new DictionaryValueProvider<object>(backingStore, CultureInfo.CurrentCulture);
        }

        private string MakeArrayKey(string prefix, int index)
        {
            return prefix + "[" + index.ToString(CultureInfo.InvariantCulture) + "]";
        }

        private string MakePropertyKey(string prefix, string propertyName)
        {
            return (String.IsNullOrEmpty(prefix)) ? propertyName : prefix + "." + propertyName;
        }
    }
}