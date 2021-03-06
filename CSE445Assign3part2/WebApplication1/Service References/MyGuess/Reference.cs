﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.MyGuess {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyGuess.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/secretNumber", ReplyAction="http://tempuri.org/IService/secretNumberResponse")]
        int secretNumber(int lower, int upper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/secretNumber", ReplyAction="http://tempuri.org/IService/secretNumberResponse")]
        System.Threading.Tasks.Task<int> secretNumberAsync(int lower, int upper);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/checkNumber", ReplyAction="http://tempuri.org/IService/checkNumberResponse")]
        string checkNumber(int userNum, int secretNum);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/checkNumber", ReplyAction="http://tempuri.org/IService/checkNumberResponse")]
        System.Threading.Tasks.Task<string> checkNumberAsync(int userNum, int secretNum);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : WebApplication1.MyGuess.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<WebApplication1.MyGuess.IService>, WebApplication1.MyGuess.IService {
        
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
        
        public int secretNumber(int lower, int upper) {
            return base.Channel.secretNumber(lower, upper);
        }
        
        public System.Threading.Tasks.Task<int> secretNumberAsync(int lower, int upper) {
            return base.Channel.secretNumberAsync(lower, upper);
        }
        
        public string checkNumber(int userNum, int secretNum) {
            return base.Channel.checkNumber(userNum, secretNum);
        }
        
        public System.Threading.Tasks.Task<string> checkNumberAsync(int userNum, int secretNum) {
            return base.Channel.checkNumberAsync(userNum, secretNum);
        }
    }
}
