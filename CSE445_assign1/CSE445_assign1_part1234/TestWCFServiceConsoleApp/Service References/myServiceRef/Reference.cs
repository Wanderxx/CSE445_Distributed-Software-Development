﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestWCFServiceConsoleApp.myServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="myServiceRef.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/PiValue", ReplyAction="http://tempuri.org/IService/PiValueResponse")]
        double PiValue();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/absValue", ReplyAction="http://tempuri.org/IService/absValueResponse")]
        int absValue(int intVal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/c2f", ReplyAction="http://tempuri.org/IService/c2fResponse")]
        int c2f(int c);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/f2c", ReplyAction="http://tempuri.org/IService/f2cResponse")]
        int f2c(int f);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : TestWCFServiceConsoleApp.myServiceRef.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<TestWCFServiceConsoleApp.myServiceRef.IService>, TestWCFServiceConsoleApp.myServiceRef.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public double PiValue() {
            return base.Channel.PiValue();
        }
        
        public int absValue(int intVal) {
            return base.Channel.absValue(intVal);
        }
        
        public int c2f(int c) {
            return base.Channel.c2f(c);
        }
        
        public int f2c(int f) {
            return base.Channel.f2c(f);
        }
    }
}
