﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaDePrematricula.SolicitudServWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Solicitud", Namespace="http://schemas.datacontract.org/2004/07/ServicioGestionSolicitudes.Dominio")]
    [System.SerializableAttribute()]
    public partial class Solicitud : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SistemaDePrematricula.SolicitudServWS.Alumno AlumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CertificadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaCitaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaRespuestaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaSolicitudField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GradoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdNivelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPreMatriculaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NivelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreApellidoAlumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NroDniAlumnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NroDniApoderadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ObservacionesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SistemaDePrematricula.SolicitudServWS.Apoderado apoderadoField;
        
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
        public SistemaDePrematricula.SolicitudServWS.Alumno Alumno {
            get {
                return this.AlumnoField;
            }
            set {
                if ((object.ReferenceEquals(this.AlumnoField, value) != true)) {
                    this.AlumnoField = value;
                    this.RaisePropertyChanged("Alumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Certificado {
            get {
                return this.CertificadoField;
            }
            set {
                if ((object.ReferenceEquals(this.CertificadoField, value) != true)) {
                    this.CertificadoField = value;
                    this.RaisePropertyChanged("Certificado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Estado {
            get {
                return this.EstadoField;
            }
            set {
                if ((object.ReferenceEquals(this.EstadoField, value) != true)) {
                    this.EstadoField = value;
                    this.RaisePropertyChanged("Estado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaCita {
            get {
                return this.FechaCitaField;
            }
            set {
                if ((this.FechaCitaField.Equals(value) != true)) {
                    this.FechaCitaField = value;
                    this.RaisePropertyChanged("FechaCita");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaRespuesta {
            get {
                return this.FechaRespuestaField;
            }
            set {
                if ((this.FechaRespuestaField.Equals(value) != true)) {
                    this.FechaRespuestaField = value;
                    this.RaisePropertyChanged("FechaRespuesta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaSolicitud {
            get {
                return this.FechaSolicitudField;
            }
            set {
                if ((this.FechaSolicitudField.Equals(value) != true)) {
                    this.FechaSolicitudField = value;
                    this.RaisePropertyChanged("FechaSolicitud");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Grado {
            get {
                return this.GradoField;
            }
            set {
                if ((object.ReferenceEquals(this.GradoField, value) != true)) {
                    this.GradoField = value;
                    this.RaisePropertyChanged("Grado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdNivel {
            get {
                return this.IdNivelField;
            }
            set {
                if ((this.IdNivelField.Equals(value) != true)) {
                    this.IdNivelField = value;
                    this.RaisePropertyChanged("IdNivel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPreMatricula {
            get {
                return this.IdPreMatriculaField;
            }
            set {
                if ((this.IdPreMatriculaField.Equals(value) != true)) {
                    this.IdPreMatriculaField = value;
                    this.RaisePropertyChanged("IdPreMatricula");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nivel {
            get {
                return this.NivelField;
            }
            set {
                if ((object.ReferenceEquals(this.NivelField, value) != true)) {
                    this.NivelField = value;
                    this.RaisePropertyChanged("Nivel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreApellidoAlumno {
            get {
                return this.NombreApellidoAlumnoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreApellidoAlumnoField, value) != true)) {
                    this.NombreApellidoAlumnoField = value;
                    this.RaisePropertyChanged("NombreApellidoAlumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NroDniAlumno {
            get {
                return this.NroDniAlumnoField;
            }
            set {
                if ((object.ReferenceEquals(this.NroDniAlumnoField, value) != true)) {
                    this.NroDniAlumnoField = value;
                    this.RaisePropertyChanged("NroDniAlumno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NroDniApoderado {
            get {
                return this.NroDniApoderadoField;
            }
            set {
                if ((object.ReferenceEquals(this.NroDniApoderadoField, value) != true)) {
                    this.NroDniApoderadoField = value;
                    this.RaisePropertyChanged("NroDniApoderado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Observaciones {
            get {
                return this.ObservacionesField;
            }
            set {
                if ((object.ReferenceEquals(this.ObservacionesField, value) != true)) {
                    this.ObservacionesField = value;
                    this.RaisePropertyChanged("Observaciones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tipo {
            get {
                return this.TipoField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoField, value) != true)) {
                    this.TipoField = value;
                    this.RaisePropertyChanged("Tipo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SistemaDePrematricula.SolicitudServWS.Apoderado apoderado {
            get {
                return this.apoderadoField;
            }
            set {
                if ((object.ReferenceEquals(this.apoderadoField, value) != true)) {
                    this.apoderadoField = value;
                    this.RaisePropertyChanged("apoderado");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Alumno", Namespace="http://schemas.datacontract.org/2004/07/ServicioAlumnos.Dominio")]
    [System.SerializableAttribute()]
    public partial class Alumno : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoMaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoPaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DNIField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaNacimientoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GradoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdNivelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NivelField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NroDniApoderadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
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
        public string ApellidoMaterno {
            get {
                return this.ApellidoMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoMaternoField, value) != true)) {
                    this.ApellidoMaternoField = value;
                    this.RaisePropertyChanged("ApellidoMaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoPaterno {
            get {
                return this.ApellidoPaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoPaternoField, value) != true)) {
                    this.ApellidoPaternoField = value;
                    this.RaisePropertyChanged("ApellidoPaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DNI {
            get {
                return this.DNIField;
            }
            set {
                if ((object.ReferenceEquals(this.DNIField, value) != true)) {
                    this.DNIField = value;
                    this.RaisePropertyChanged("DNI");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaNacimiento {
            get {
                return this.FechaNacimientoField;
            }
            set {
                if ((this.FechaNacimientoField.Equals(value) != true)) {
                    this.FechaNacimientoField = value;
                    this.RaisePropertyChanged("FechaNacimiento");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Grado {
            get {
                return this.GradoField;
            }
            set {
                if ((object.ReferenceEquals(this.GradoField, value) != true)) {
                    this.GradoField = value;
                    this.RaisePropertyChanged("Grado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdNivel {
            get {
                return this.IdNivelField;
            }
            set {
                if ((this.IdNivelField.Equals(value) != true)) {
                    this.IdNivelField = value;
                    this.RaisePropertyChanged("IdNivel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nivel {
            get {
                return this.NivelField;
            }
            set {
                if ((object.ReferenceEquals(this.NivelField, value) != true)) {
                    this.NivelField = value;
                    this.RaisePropertyChanged("Nivel");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NroDniApoderado {
            get {
                return this.NroDniApoderadoField;
            }
            set {
                if ((object.ReferenceEquals(this.NroDniApoderadoField, value) != true)) {
                    this.NroDniApoderadoField = value;
                    this.RaisePropertyChanged("NroDniApoderado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sexo {
            get {
                return this.SexoField;
            }
            set {
                if ((object.ReferenceEquals(this.SexoField, value) != true)) {
                    this.SexoField = value;
                    this.RaisePropertyChanged("Sexo");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Apoderado", Namespace="http://schemas.datacontract.org/2004/07/ServicioGestionSolicitudes.Dominio")]
    [System.SerializableAttribute()]
    public partial class Apoderado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoMaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoPaternoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NroCelularField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NroDniField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ParentescoField;
        
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
        public string ApellidoMaterno {
            get {
                return this.ApellidoMaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoMaternoField, value) != true)) {
                    this.ApellidoMaternoField = value;
                    this.RaisePropertyChanged("ApellidoMaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ApellidoPaterno {
            get {
                return this.ApellidoPaternoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoPaternoField, value) != true)) {
                    this.ApellidoPaternoField = value;
                    this.RaisePropertyChanged("ApellidoPaterno");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombres {
            get {
                return this.NombresField;
            }
            set {
                if ((object.ReferenceEquals(this.NombresField, value) != true)) {
                    this.NombresField = value;
                    this.RaisePropertyChanged("Nombres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NroCelular {
            get {
                return this.NroCelularField;
            }
            set {
                if ((object.ReferenceEquals(this.NroCelularField, value) != true)) {
                    this.NroCelularField = value;
                    this.RaisePropertyChanged("NroCelular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NroDni {
            get {
                return this.NroDniField;
            }
            set {
                if ((object.ReferenceEquals(this.NroDniField, value) != true)) {
                    this.NroDniField = value;
                    this.RaisePropertyChanged("NroDni");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Parentesco {
            get {
                return this.ParentescoField;
            }
            set {
                if ((object.ReferenceEquals(this.ParentescoField, value) != true)) {
                    this.ParentescoField = value;
                    this.RaisePropertyChanged("Parentesco");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ManejadorException", Namespace="http://schemas.datacontract.org/2004/07/ServicioGestionSolicitudes.Errores")]
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SolicitudServWS.ISolicitudService")]
    public interface ISolicitudService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudService/Crear", ReplyAction="http://tempuri.org/ISolicitudService/CrearResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(SistemaDePrematricula.SolicitudServWS.ManejadorException), Action="http://tempuri.org/ISolicitudService/CrearManejadorExceptionFault", Name="ManejadorException", Namespace="http://schemas.datacontract.org/2004/07/ServicioGestionSolicitudes.Errores")]
        SistemaDePrematricula.SolicitudServWS.Solicitud Crear(SistemaDePrematricula.SolicitudServWS.Solicitud solicitud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudService/Crear", ReplyAction="http://tempuri.org/ISolicitudService/CrearResponse")]
        System.Threading.Tasks.Task<SistemaDePrematricula.SolicitudServWS.Solicitud> CrearAsync(SistemaDePrematricula.SolicitudServWS.Solicitud solicitud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudService/Obtener", ReplyAction="http://tempuri.org/ISolicitudService/ObtenerResponse")]
        SistemaDePrematricula.SolicitudServWS.Solicitud Obtener(int idPrematricula, string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudService/Obtener", ReplyAction="http://tempuri.org/ISolicitudService/ObtenerResponse")]
        System.Threading.Tasks.Task<SistemaDePrematricula.SolicitudServWS.Solicitud> ObtenerAsync(int idPrematricula, string dni);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudService/Modificar", ReplyAction="http://tempuri.org/ISolicitudService/ModificarResponse")]
        SistemaDePrematricula.SolicitudServWS.Solicitud Modificar(SistemaDePrematricula.SolicitudServWS.Solicitud solicitud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudService/Modificar", ReplyAction="http://tempuri.org/ISolicitudService/ModificarResponse")]
        System.Threading.Tasks.Task<SistemaDePrematricula.SolicitudServWS.Solicitud> ModificarAsync(SistemaDePrematricula.SolicitudServWS.Solicitud solicitud);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudService/Listar", ReplyAction="http://tempuri.org/ISolicitudService/ListarResponse")]
        SistemaDePrematricula.SolicitudServWS.Solicitud[] Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISolicitudService/Listar", ReplyAction="http://tempuri.org/ISolicitudService/ListarResponse")]
        System.Threading.Tasks.Task<SistemaDePrematricula.SolicitudServWS.Solicitud[]> ListarAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISolicitudServiceChannel : SistemaDePrematricula.SolicitudServWS.ISolicitudService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SolicitudServiceClient : System.ServiceModel.ClientBase<SistemaDePrematricula.SolicitudServWS.ISolicitudService>, SistemaDePrematricula.SolicitudServWS.ISolicitudService {
        
        public SolicitudServiceClient() {
        }
        
        public SolicitudServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SolicitudServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SolicitudServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SolicitudServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SistemaDePrematricula.SolicitudServWS.Solicitud Crear(SistemaDePrematricula.SolicitudServWS.Solicitud solicitud) {
            return base.Channel.Crear(solicitud);
        }
        
        public System.Threading.Tasks.Task<SistemaDePrematricula.SolicitudServWS.Solicitud> CrearAsync(SistemaDePrematricula.SolicitudServWS.Solicitud solicitud) {
            return base.Channel.CrearAsync(solicitud);
        }
        
        public SistemaDePrematricula.SolicitudServWS.Solicitud Obtener(int idPrematricula, string dni) {
            return base.Channel.Obtener(idPrematricula, dni);
        }
        
        public System.Threading.Tasks.Task<SistemaDePrematricula.SolicitudServWS.Solicitud> ObtenerAsync(int idPrematricula, string dni) {
            return base.Channel.ObtenerAsync(idPrematricula, dni);
        }
        
        public SistemaDePrematricula.SolicitudServWS.Solicitud Modificar(SistemaDePrematricula.SolicitudServWS.Solicitud solicitud) {
            return base.Channel.Modificar(solicitud);
        }
        
        public System.Threading.Tasks.Task<SistemaDePrematricula.SolicitudServWS.Solicitud> ModificarAsync(SistemaDePrematricula.SolicitudServWS.Solicitud solicitud) {
            return base.Channel.ModificarAsync(solicitud);
        }
        
        public SistemaDePrematricula.SolicitudServWS.Solicitud[] Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<SistemaDePrematricula.SolicitudServWS.Solicitud[]> ListarAsync() {
            return base.Channel.ListarAsync();
        }
    }
}
