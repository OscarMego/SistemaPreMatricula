﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServicioSITECE.AsociadoWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Asociado", Namespace="http://schemas.datacontract.org/2004/07/ServicioSITECE.Dominio")]
    [System.SerializableAttribute()]
    public partial class Asociado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoModularField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long IdAsociadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreColegioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TokenField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoModular {
            get {
                return this.CodigoModularField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoModularField, value) != true)) {
                    this.CodigoModularField = value;
                    this.RaisePropertyChanged("CodigoModular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long IdAsociado {
            get {
                return this.IdAsociadoField;
            }
            set {
                if ((this.IdAsociadoField.Equals(value) != true)) {
                    this.IdAsociadoField = value;
                    this.RaisePropertyChanged("IdAsociado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreColegio {
            get {
                return this.NombreColegioField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreColegioField, value) != true)) {
                    this.NombreColegioField = value;
                    this.RaisePropertyChanged("NombreColegio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Token {
            get {
                return this.TokenField;
            }
            set {
                if ((object.ReferenceEquals(this.TokenField, value) != true)) {
                    this.TokenField = value;
                    this.RaisePropertyChanged("Token");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ManejadorException", Namespace="http://schemas.datacontract.org/2004/07/ServicioSITECE.Errores")]
    [System.SerializableAttribute()]
    public partial class ManejadorException : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoField, value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AsociadoWS.IRegistroService")]
    public interface IRegistroService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistroService/CrearAsociado", ReplyAction="http://tempuri.org/IRegistroService/CrearAsociadoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ServicioSITECE.AsociadoWS.ManejadorException), Action="http://tempuri.org/IRegistroService/CrearAsociadoManejadorExceptionFault", Name="ManejadorException", Namespace="http://schemas.datacontract.org/2004/07/ServicioSITECE.Errores")]
        ServicioSITECE.AsociadoWS.Asociado CrearAsociado(ServicioSITECE.AsociadoWS.Asociado asociado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistroService/CrearAsociado", ReplyAction="http://tempuri.org/IRegistroService/CrearAsociadoResponse")]
        System.Threading.Tasks.Task<ServicioSITECE.AsociadoWS.Asociado> CrearAsociadoAsync(ServicioSITECE.AsociadoWS.Asociado asociado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistroService/ObtenerAsociado", ReplyAction="http://tempuri.org/IRegistroService/ObtenerAsociadoResponse")]
        ServicioSITECE.AsociadoWS.Asociado ObtenerAsociado(string token, string codigoModular);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistroService/ObtenerAsociado", ReplyAction="http://tempuri.org/IRegistroService/ObtenerAsociadoResponse")]
        System.Threading.Tasks.Task<ServicioSITECE.AsociadoWS.Asociado> ObtenerAsociadoAsync(string token, string codigoModular);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistroService/ObtenerAsociadoToken", ReplyAction="http://tempuri.org/IRegistroService/ObtenerAsociadoTokenResponse")]
        ServicioSITECE.AsociadoWS.Asociado ObtenerAsociadoToken(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRegistroService/ObtenerAsociadoToken", ReplyAction="http://tempuri.org/IRegistroService/ObtenerAsociadoTokenResponse")]
        System.Threading.Tasks.Task<ServicioSITECE.AsociadoWS.Asociado> ObtenerAsociadoTokenAsync(string token);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRegistroServiceChannel : ServicioSITECE.AsociadoWS.IRegistroService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RegistroServiceClient : System.ServiceModel.ClientBase<ServicioSITECE.AsociadoWS.IRegistroService>, ServicioSITECE.AsociadoWS.IRegistroService {
        
        public RegistroServiceClient() {
        }
        
        public RegistroServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RegistroServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistroServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RegistroServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ServicioSITECE.AsociadoWS.Asociado CrearAsociado(ServicioSITECE.AsociadoWS.Asociado asociado) {
            return base.Channel.CrearAsociado(asociado);
        }
        
        public System.Threading.Tasks.Task<ServicioSITECE.AsociadoWS.Asociado> CrearAsociadoAsync(ServicioSITECE.AsociadoWS.Asociado asociado) {
            return base.Channel.CrearAsociadoAsync(asociado);
        }
        
        public ServicioSITECE.AsociadoWS.Asociado ObtenerAsociado(string token, string codigoModular) {
            return base.Channel.ObtenerAsociado(token, codigoModular);
        }
        
        public System.Threading.Tasks.Task<ServicioSITECE.AsociadoWS.Asociado> ObtenerAsociadoAsync(string token, string codigoModular) {
            return base.Channel.ObtenerAsociadoAsync(token, codigoModular);
        }
        
        public ServicioSITECE.AsociadoWS.Asociado ObtenerAsociadoToken(string token) {
            return base.Channel.ObtenerAsociadoToken(token);
        }
        
        public System.Threading.Tasks.Task<ServicioSITECE.AsociadoWS.Asociado> ObtenerAsociadoTokenAsync(string token) {
            return base.Channel.ObtenerAsociadoTokenAsync(token);
        }
    }
}
