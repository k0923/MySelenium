﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://example/", ConfigurationName="ServiceReference1.HelloWorld")]
    public interface HelloWorld {
        
        // CODEGEN: 命名空间  的元素名称 arg0 以后生成的消息协定未标记为 nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://example/HelloWorld/sayHelloWorldFromRequest", ReplyAction="http://example/HelloWorld/sayHelloWorldFromResponse")]
        ConsoleApp1.ServiceReference1.sayHelloWorldFromResponse sayHelloWorldFrom(ConsoleApp1.ServiceReference1.sayHelloWorldFromRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://example/HelloWorld/sayHelloWorldFromRequest", ReplyAction="http://example/HelloWorld/sayHelloWorldFromResponse")]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.sayHelloWorldFromResponse> sayHelloWorldFromAsync(ConsoleApp1.ServiceReference1.sayHelloWorldFromRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sayHelloWorldFromRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sayHelloWorldFrom", Namespace="http://example/", Order=0)]
        public ConsoleApp1.ServiceReference1.sayHelloWorldFromRequestBody Body;
        
        public sayHelloWorldFromRequest() {
        }
        
        public sayHelloWorldFromRequest(ConsoleApp1.ServiceReference1.sayHelloWorldFromRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class sayHelloWorldFromRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string arg0;
        
        public sayHelloWorldFromRequestBody() {
        }
        
        public sayHelloWorldFromRequestBody(string arg0) {
            this.arg0 = arg0;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class sayHelloWorldFromResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="sayHelloWorldFromResponse", Namespace="http://example/", Order=0)]
        public ConsoleApp1.ServiceReference1.sayHelloWorldFromResponseBody Body;
        
        public sayHelloWorldFromResponse() {
        }
        
        public sayHelloWorldFromResponse(ConsoleApp1.ServiceReference1.sayHelloWorldFromResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="")]
    public partial class sayHelloWorldFromResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string @return;
        
        public sayHelloWorldFromResponseBody() {
        }
        
        public sayHelloWorldFromResponseBody(string @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HelloWorldChannel : ConsoleApp1.ServiceReference1.HelloWorld, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldClient : System.ServiceModel.ClientBase<ConsoleApp1.ServiceReference1.HelloWorld>, ConsoleApp1.ServiceReference1.HelloWorld {
        
        public HelloWorldClient() {
        }
        
        public HelloWorldClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWorldClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ConsoleApp1.ServiceReference1.sayHelloWorldFromResponse ConsoleApp1.ServiceReference1.HelloWorld.sayHelloWorldFrom(ConsoleApp1.ServiceReference1.sayHelloWorldFromRequest request) {
            return base.Channel.sayHelloWorldFrom(request);
        }
        
        public string sayHelloWorldFrom(string arg0) {
            ConsoleApp1.ServiceReference1.sayHelloWorldFromRequest inValue = new ConsoleApp1.ServiceReference1.sayHelloWorldFromRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.sayHelloWorldFromRequestBody();
            inValue.Body.arg0 = arg0;
            ConsoleApp1.ServiceReference1.sayHelloWorldFromResponse retVal = ((ConsoleApp1.ServiceReference1.HelloWorld)(this)).sayHelloWorldFrom(inValue);
            return retVal.Body.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.sayHelloWorldFromResponse> ConsoleApp1.ServiceReference1.HelloWorld.sayHelloWorldFromAsync(ConsoleApp1.ServiceReference1.sayHelloWorldFromRequest request) {
            return base.Channel.sayHelloWorldFromAsync(request);
        }
        
        public System.Threading.Tasks.Task<ConsoleApp1.ServiceReference1.sayHelloWorldFromResponse> sayHelloWorldFromAsync(string arg0) {
            ConsoleApp1.ServiceReference1.sayHelloWorldFromRequest inValue = new ConsoleApp1.ServiceReference1.sayHelloWorldFromRequest();
            inValue.Body = new ConsoleApp1.ServiceReference1.sayHelloWorldFromRequestBody();
            inValue.Body.arg0 = arg0;
            return ((ConsoleApp1.ServiceReference1.HelloWorld)(this)).sayHelloWorldFromAsync(inValue);
        }
    }
}