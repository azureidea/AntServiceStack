﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestContract.Client
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    using AntServiceStack.ProtoBuf;
    using AntServiceStack.ServiceHost;
    using AntServiceStack.Baiji.Specific;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Threading;
    using AntServiceStack.ServiceClient;
    using AntServiceStack.Common.Types;
    
    
    /// <summary>
    /// Helloworld Request
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/HelloWord.xsd")]
    [System.Xml.Serialization.XmlRootAttribute("HelloWorldRequest", Namespace="http://tempuri.org/HelloWord.xsd", IsNullable=false)]
    [DataContract(Name="HelloWorldRequest", Namespace="http://tempuri.org/HelloWord.xsd")]
    [ProtoContract()]
    [Description("Helloworld Request")]
    public partial class HelloWorldRequestType : ISpecificRecord
    {
        
        private TestEnum ackEnumField;
        
        public static readonly AntServiceStack.Baiji.Schema.Schema SCHEMA = AntServiceStack.Baiji.Schema.Schema.Parse(((("{\"type\":\"record\",\"name\":\"HelloWorldRequestType\",\"namespace\":\"" + typeof(HelloWorldRequestType).Namespace) 
                        + ("\",\"doc\":null,\"fields\":[{\"name\":\"AckEnum\",\"type\":{\"type\":\"enum\",\"name\":\"TestEnum\"," +
                            "\"namespace\":\"" + typeof(TestEnum).Namespace)) 
                        + "\",\"doc\":null,\"symbols\":[\"Success\",\"Failure\",\"Warning\"]}}]}"));
        
        /// <summary>
        /// 返回类型
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [Description("返回类型")]
        [DataMember()]
        [ProtoMember(1)]
        public TestEnum AckEnum
        {
            get
            {
                return this.ackEnumField;
            }
            set
            {
                this.ackEnumField = value;
            }
        }
        
        public virtual AntServiceStack.Baiji.Schema.Schema GetSchema()
        {
            return SCHEMA;
        }
        
        public virtual object Get(int fieldPos)
        {
            switch(fieldPos)
            {
                case 0: return this.AckEnum;
                default: throw new AntServiceStack.Baiji.Exceptions.BaijiRuntimeException("Bad index " + fieldPos + " in Get()");
            }
        }
        
        public virtual void Put(int fieldPos, object fieldValue)
        {
            switch(fieldPos)
            {
                case 0: this.AckEnum = (TestEnum)fieldValue; break;
                default: throw new AntServiceStack.Baiji.Exceptions.BaijiRuntimeException("Bad index " + fieldPos + " in Put()");
            }
        }
        
        public virtual object Get(string fieldName)
        {
            var recordSchema = GetSchema() as AntServiceStack.Baiji.Schema.RecordSchema;
            if (recordSchema == null)
            {
                return null;
            }
            AntServiceStack.Baiji.Schema.Field field;
            if (!recordSchema.TryGetField(fieldName, out field))
            {
                return null;
            }
            return Get(field.Pos);
        }
        
        public virtual void Put(string fieldName, object fieldValue)
        {
            var recordSchema = GetSchema() as AntServiceStack.Baiji.Schema.RecordSchema;
            if (recordSchema == null)
            {
                return ;
            }
            AntServiceStack.Baiji.Schema.Field field;
            if (!recordSchema.TryGetField(fieldName, out field))
            {
                return ;
            }
            Put(field.Pos, fieldValue);
        }
    }
    
    /// <summary>
    /// 测试enum类型
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/HelloWord.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://tempuri.org/HelloWord.xsd", IsNullable=false)]
    [Description("测试enum类型")]
    [DataContract(Namespace="http://tempuri.org/HelloWord.xsd")]
    [ProtoContract()]
    public enum TestEnum
    {
        
        /// <summary>
        /// 成功
        /// </summary>
        [Description("成功")]
        [EnumMember()]
        [ProtoEnum()]
        Success,
        
        /// <summary>
        /// 失败
        /// </summary>
        [Description("失败")]
        [EnumMember()]
        [ProtoEnum()]
        Failure,
        
        /// <summary>
        /// 警告
        /// </summary>
        [Description("警告")]
        [EnumMember()]
        [ProtoEnum()]
        Warning,
    }
    
    /// <summary>
    /// Helloworld Response
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1087.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/HelloWord.xsd")]
    [System.Xml.Serialization.XmlRootAttribute("HelloWorldResponse", Namespace="http://tempuri.org/HelloWord.xsd", IsNullable=false)]
    [DataContract(Name="HelloWorldResponse", Namespace="http://tempuri.org/HelloWord.xsd")]
    [ProtoContract()]
    [Description("Helloworld Response")]
    public partial class HelloWorldResponseType : ISpecificRecord, IHasResponseStatus
    {
        
        private string responseField;
        
        private ResponseStatusType responseStatusField;
        
        public static readonly AntServiceStack.Baiji.Schema.Schema SCHEMA = AntServiceStack.Baiji.Schema.Schema.Parse(((("{\"type\":\"record\",\"name\":\"HelloWorldResponseType\",\"namespace\":\"" + typeof(HelloWorldResponseType).Namespace) 
                        + (("\",\"doc\":null,\"fields\":[{\"name\":\"Response\",\"type\":[\"string\",\"null\"]},{\"name\":\"Resp" +
                            "onseStatus\",\"type\":{\"type\":\"record\",\"name\":\"ResponseStatusType\",\"namespace\":\"" + typeof(ResponseStatusType).Namespace) 
                        + (("\",\"doc\":null,\"fields\":[{\"name\":\"Timestamp\",\"type\":\"datetime\"},{\"name\":\"Ack\",\"type" +
                            "\":{\"type\":\"enum\",\"name\":\"AckCodeType\",\"namespace\":\"" + typeof(AckCodeType).Namespace) 
                        + (("\",\"doc\":null,\"symbols\":[\"Success\",\"Failure\",\"Warning\",\"PartialFailure\"]}},{\"name\"" +
                            ":\"Errors\",\"type\":[{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"ErrorDataType" +
                            "\",\"namespace\":\"" + typeof(ErrorDataType).Namespace) 
                        + (("\",\"doc\":null,\"fields\":[{\"name\":\"Message\",\"type\":[\"string\",\"null\"]},{\"name\":\"Error" +
                            "Code\",\"type\":[\"string\",\"null\"]},{\"name\":\"StackTrace\",\"type\":[\"string\",\"null\"]},{" +
                            "\"name\":\"SeverityCode\",\"type\":{\"type\":\"enum\",\"name\":\"SeverityCodeType\",\"namespace" +
                            "\":\"" + typeof(SeverityCodeType).Namespace) 
                        + (("\",\"doc\":null,\"symbols\":[\"Error\",\"Warning\"]}},{\"name\":\"ErrorFields\",\"type\":[{\"type" +
                            "\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"ErrorFieldType\",\"namespace\":\"" + typeof(ErrorFieldType).Namespace) 
                        + ((@""",""doc"":null,""fields"":[{""name"":""FieldName"",""type"":[""string"",""null""]},{""name"":""ErrorCode"",""type"":[""string"",""null""]},{""name"":""Message"",""type"":[""string"",""null""]}]}},""null""]},{""name"":""ErrorClassification"",""type"":{""type"":""enum"",""name"":""ErrorClassificationCodeType"",""namespace"":""" + typeof(ErrorClassificationCodeType).Namespace) 
                        + (@""",""doc"":null,""symbols"":[""ServiceError"",""ValidationError"",""FrameworkError"",""SLAError""]}}]}},""null""]},{""name"":""Build"",""type"":[""string"",""null""]},{""name"":""Version"",""type"":[""string"",""null""]},{""name"":""Extension"",""type"":[{""type"":""array"",""items"":{""type"":""record"",""name"":""ExtensionType"",""namespace"":""" + typeof(ExtensionType).Namespace)))))))) 
                        + "\",\"doc\":null,\"fields\":[{\"name\":\"Id\",\"type\":[\"string\",\"null\"]},{\"name\":\"Version\",\"" +
                            "type\":[\"string\",\"null\"]},{\"name\":\"ContentType\",\"type\":[\"string\",\"null\"]},{\"name\"" +
                            ":\"Value\",\"type\":[\"string\",\"null\"]}]}},\"null\"]}]}}]}"));
        
        /// <summary>
        /// 返回信息
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [Description("返回信息")]
        [DataMember()]
        [ProtoMember(1)]
        public string Response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
            }
        }
        
        /// <summary>
        /// 框架公共Response
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [Description("框架公共Response")]
        [DataMember()]
        [ProtoMember(2)]
        public ResponseStatusType ResponseStatus
        {
            get
            {
                return this.responseStatusField;
            }
            set
            {
                this.responseStatusField = value;
            }
        }
        
        public virtual AntServiceStack.Baiji.Schema.Schema GetSchema()
        {
            return SCHEMA;
        }
        
        public virtual object Get(int fieldPos)
        {
            switch(fieldPos)
            {
                case 0: return this.Response;
                case 1: return this.ResponseStatus;
                default: throw new AntServiceStack.Baiji.Exceptions.BaijiRuntimeException("Bad index " + fieldPos + " in Get()");
            }
        }
        
        public virtual void Put(int fieldPos, object fieldValue)
        {
            switch(fieldPos)
            {
                case 0: this.Response = (string)fieldValue; break;
                case 1: this.ResponseStatus = (ResponseStatusType)fieldValue; break;
                default: throw new AntServiceStack.Baiji.Exceptions.BaijiRuntimeException("Bad index " + fieldPos + " in Put()");
            }
        }
        
        public virtual object Get(string fieldName)
        {
            var recordSchema = GetSchema() as AntServiceStack.Baiji.Schema.RecordSchema;
            if (recordSchema == null)
            {
                return null;
            }
            AntServiceStack.Baiji.Schema.Field field;
            if (!recordSchema.TryGetField(fieldName, out field))
            {
                return null;
            }
            return Get(field.Pos);
        }
        
        public virtual void Put(string fieldName, object fieldValue)
        {
            var recordSchema = GetSchema() as AntServiceStack.Baiji.Schema.RecordSchema;
            if (recordSchema == null)
            {
                return ;
            }
            AntServiceStack.Baiji.Schema.Field field;
            if (!recordSchema.TryGetField(fieldName, out field))
            {
                return ;
            }
            Put(field.Pos, fieldValue);
        }
    }
    
    /// <summary>
    /// Service client auto-generated by SOA tool, DO NOT CHANGE!
    /// 
    /// 
    /// </summary>
    public class CloudBagRestFulApiClient : ServiceClientBase<CloudBagRestFulApiClient>
    {
        
        public const string CodeGeneratorVersion = "1.0.0.0";
        
        public const string OriginalServiceName = "CloudBagRestFulApi";
        
        public const string OriginalServiceNamespace = "http://soa.ant.com/innovationwork/CloudBag/v1";
        
        public const string OriginalServiceType = "NonSLB";
        
        private CloudBagRestFulApiClient(string baseUri) : 
                base(baseUri)
        {
        }
        
        private CloudBagRestFulApiClient(string serviceName, string serviceNamespace, string subEnv) : 
                base(serviceName, serviceNamespace, subEnv)
        {
        }
        
        public virtual HelloWorldResponseType HelloWorld(HelloWorldRequestType helloWorldIn)
        {
            return base.Invoke<HelloWorldResponseType>("HelloWorld", helloWorldIn);
        }
        
        public virtual HelloWorldResponseType HelloWorld(HelloWorldRequestType helloWorldIn, Func<HelloWorldResponseType> getFallback)
        {
            return base.Invoke<HelloWorldResponseType>("HelloWorld", helloWorldIn, getFallback);
        }
        
        public virtual Task<HelloWorldResponseType> CreateAsyncTaskOfHelloWorld(HelloWorldRequestType helloWorldIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<HelloWorldRequestType, HelloWorldResponseType>("HelloWorld", helloWorldIn, cancellationToken, taskCreationOptions);
        }
        
        public virtual Task<HelloWorldResponseType> StartIOCPTaskOfHelloWorld(HelloWorldRequestType helloWorldIn)
        {
            return base.StartIOCPTask<HelloWorldResponseType>("HelloWorld", helloWorldIn);
        }
        
        public virtual HelloWorldResponseType HelloWorldAsync(HelloWorldRequestType helloWorldAsyncIn)
        {
            return base.Invoke<HelloWorldResponseType>("HelloWorldAsync", helloWorldAsyncIn);
        }
        
        public virtual HelloWorldResponseType HelloWorldAsync(HelloWorldRequestType helloWorldAsyncIn, Func<HelloWorldResponseType> getFallback)
        {
            return base.Invoke<HelloWorldResponseType>("HelloWorldAsync", helloWorldAsyncIn, getFallback);
        }
        
        public virtual Task<HelloWorldResponseType> CreateAsyncTaskOfHelloWorldAsync(HelloWorldRequestType helloWorldAsyncIn, CancellationToken? cancellationToken = null, TaskCreationOptions? taskCreationOptions = null)
        {
            return base.CreateAsyncTask<HelloWorldRequestType, HelloWorldResponseType>("HelloWorldAsync", helloWorldAsyncIn, cancellationToken, taskCreationOptions);
        }
        
        public virtual Task<HelloWorldResponseType> StartIOCPTaskOfHelloWorldAsync(HelloWorldRequestType helloWorldAsyncIn)
        {
            return base.StartIOCPTask<HelloWorldResponseType>("HelloWorldAsync", helloWorldAsyncIn);
        }
    }
}
