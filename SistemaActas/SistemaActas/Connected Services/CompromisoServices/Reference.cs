﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaActas.CompromisoServices {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Compromiso", Namespace="http://schemas.datacontract.org/2004/07/WS_Actas.Model")]
    [System.SerializableAttribute()]
    public partial class Compromiso : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_actaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_compromisoField;
        
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
        public int id_acta {
            get {
                return this.id_actaField;
            }
            set {
                if ((this.id_actaField.Equals(value) != true)) {
                    this.id_actaField = value;
                    this.RaisePropertyChanged("id_acta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_compromiso {
            get {
                return this.id_compromisoField;
            }
            set {
                if ((this.id_compromisoField.Equals(value) != true)) {
                    this.id_compromisoField = value;
                    this.RaisePropertyChanged("id_compromiso");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/WS_Actas.Model")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string contraseñaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int id_usuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int identificacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nombreField;
        
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
        public string contraseña {
            get {
                return this.contraseñaField;
            }
            set {
                if ((object.ReferenceEquals(this.contraseñaField, value) != true)) {
                    this.contraseñaField = value;
                    this.RaisePropertyChanged("contraseña");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id_usuario {
            get {
                return this.id_usuarioField;
            }
            set {
                if ((this.id_usuarioField.Equals(value) != true)) {
                    this.id_usuarioField = value;
                    this.RaisePropertyChanged("id_usuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int identificacion {
            get {
                return this.identificacionField;
            }
            set {
                if ((this.identificacionField.Equals(value) != true)) {
                    this.identificacionField = value;
                    this.RaisePropertyChanged("identificacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string nombre {
            get {
                return this.nombreField;
            }
            set {
                if ((object.ReferenceEquals(this.nombreField, value) != true)) {
                    this.nombreField = value;
                    this.RaisePropertyChanged("nombre");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CompromisoServices.IServiceCompromisos")]
    public interface IServiceCompromisos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCompromisos/CrearCompromiso", ReplyAction="http://tempuri.org/IServiceCompromisos/CrearCompromisoResponse")]
        void CrearCompromiso(int id_acta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCompromisos/CrearCompromiso", ReplyAction="http://tempuri.org/IServiceCompromisos/CrearCompromisoResponse")]
        System.Threading.Tasks.Task CrearCompromisoAsync(int id_acta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCompromisos/ObtenerCompromisos", ReplyAction="http://tempuri.org/IServiceCompromisos/ObtenerCompromisosResponse")]
        SistemaActas.CompromisoServices.Compromiso[] ObtenerCompromisos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCompromisos/ObtenerCompromisos", ReplyAction="http://tempuri.org/IServiceCompromisos/ObtenerCompromisosResponse")]
        System.Threading.Tasks.Task<SistemaActas.CompromisoServices.Compromiso[]> ObtenerCompromisosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCompromisos/ObtenerCompromiso", ReplyAction="http://tempuri.org/IServiceCompromisos/ObtenerCompromisoResponse")]
        SistemaActas.CompromisoServices.Compromiso ObtenerCompromiso(string idCompromiso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCompromisos/ObtenerCompromiso", ReplyAction="http://tempuri.org/IServiceCompromisos/ObtenerCompromisoResponse")]
        System.Threading.Tasks.Task<SistemaActas.CompromisoServices.Compromiso> ObtenerCompromisoAsync(string idCompromiso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCompromisos/ActualizarCompromiso", ReplyAction="http://tempuri.org/IServiceCompromisos/ActualizarCompromisoResponse")]
        void ActualizarCompromiso(int id_compromiso, int id_acta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCompromisos/ActualizarCompromiso", ReplyAction="http://tempuri.org/IServiceCompromisos/ActualizarCompromisoResponse")]
        System.Threading.Tasks.Task ActualizarCompromisoAsync(int id_compromiso, int id_acta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCompromisos/ObtenerUsuarioCompromiso", ReplyAction="http://tempuri.org/IServiceCompromisos/ObtenerUsuarioCompromisoResponse")]
        SistemaActas.CompromisoServices.Usuario ObtenerUsuarioCompromiso(string idCompromiso);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCompromisos/ObtenerUsuarioCompromiso", ReplyAction="http://tempuri.org/IServiceCompromisos/ObtenerUsuarioCompromisoResponse")]
        System.Threading.Tasks.Task<SistemaActas.CompromisoServices.Usuario> ObtenerUsuarioCompromisoAsync(string idCompromiso);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCompromisosChannel : SistemaActas.CompromisoServices.IServiceCompromisos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCompromisosClient : System.ServiceModel.ClientBase<SistemaActas.CompromisoServices.IServiceCompromisos>, SistemaActas.CompromisoServices.IServiceCompromisos {
        
        public ServiceCompromisosClient() {
        }
        
        public ServiceCompromisosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceCompromisosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCompromisosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCompromisosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void CrearCompromiso(int id_acta) {
            base.Channel.CrearCompromiso(id_acta);
        }
        
        public System.Threading.Tasks.Task CrearCompromisoAsync(int id_acta) {
            return base.Channel.CrearCompromisoAsync(id_acta);
        }
        
        public SistemaActas.CompromisoServices.Compromiso[] ObtenerCompromisos() {
            return base.Channel.ObtenerCompromisos();
        }
        
        public System.Threading.Tasks.Task<SistemaActas.CompromisoServices.Compromiso[]> ObtenerCompromisosAsync() {
            return base.Channel.ObtenerCompromisosAsync();
        }
        
        public SistemaActas.CompromisoServices.Compromiso ObtenerCompromiso(string idCompromiso) {
            return base.Channel.ObtenerCompromiso(idCompromiso);
        }
        
        public System.Threading.Tasks.Task<SistemaActas.CompromisoServices.Compromiso> ObtenerCompromisoAsync(string idCompromiso) {
            return base.Channel.ObtenerCompromisoAsync(idCompromiso);
        }
        
        public void ActualizarCompromiso(int id_compromiso, int id_acta) {
            base.Channel.ActualizarCompromiso(id_compromiso, id_acta);
        }
        
        public System.Threading.Tasks.Task ActualizarCompromisoAsync(int id_compromiso, int id_acta) {
            return base.Channel.ActualizarCompromisoAsync(id_compromiso, id_acta);
        }
        
        public SistemaActas.CompromisoServices.Usuario ObtenerUsuarioCompromiso(string idCompromiso) {
            return base.Channel.ObtenerUsuarioCompromiso(idCompromiso);
        }
        
        public System.Threading.Tasks.Task<SistemaActas.CompromisoServices.Usuario> ObtenerUsuarioCompromisoAsync(string idCompromiso) {
            return base.Channel.ObtenerUsuarioCompromisoAsync(idCompromiso);
        }
    }
}