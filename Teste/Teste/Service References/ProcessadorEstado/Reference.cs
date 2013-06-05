﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teste.ProcessadorEstado {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Estado", Namespace="http://schemas.datacontract.org/2004/07/Processador")]
    [System.SerializableAttribute()]
    public partial class Estado : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegiaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SiglaField;
        
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
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pais {
            get {
                return this.PaisField;
            }
            set {
                if ((object.ReferenceEquals(this.PaisField, value) != true)) {
                    this.PaisField = value;
                    this.RaisePropertyChanged("Pais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Regiao {
            get {
                return this.RegiaoField;
            }
            set {
                if ((object.ReferenceEquals(this.RegiaoField, value) != true)) {
                    this.RegiaoField = value;
                    this.RaisePropertyChanged("Regiao");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sigla {
            get {
                return this.SiglaField;
            }
            set {
                if ((object.ReferenceEquals(this.SiglaField, value) != true)) {
                    this.SiglaField = value;
                    this.RaisePropertyChanged("Sigla");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProcessadorEstado.IEstado")]
    public interface IEstado {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstado/Cadastrar", ReplyAction="http://tempuri.org/IEstado/CadastrarResponse")]
        void Cadastrar(Teste.ProcessadorEstado.Estado estado_);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstado/Alterar", ReplyAction="http://tempuri.org/IEstado/AlterarResponse")]
        void Alterar(Teste.ProcessadorEstado.Estado estado_);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstado/Deletar", ReplyAction="http://tempuri.org/IEstado/DeletarResponse")]
        void Deletar(Teste.ProcessadorEstado.Estado estado_);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEstado/Consultar", ReplyAction="http://tempuri.org/IEstado/ConsultarResponse")]
        Teste.ProcessadorEstado.Estado[] Consultar(Teste.ProcessadorEstado.Estado estado_);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEstadoChannel : Teste.ProcessadorEstado.IEstado, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EstadoClient : System.ServiceModel.ClientBase<Teste.ProcessadorEstado.IEstado>, Teste.ProcessadorEstado.IEstado {
        
        public EstadoClient() {
        }
        
        public EstadoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EstadoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstadoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EstadoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Cadastrar(Teste.ProcessadorEstado.Estado estado_) {
            base.Channel.Cadastrar(estado_);
        }
        
        public void Alterar(Teste.ProcessadorEstado.Estado estado_) {
            base.Channel.Alterar(estado_);
        }
        
        public void Deletar(Teste.ProcessadorEstado.Estado estado_) {
            base.Channel.Deletar(estado_);
        }
        
        public Teste.ProcessadorEstado.Estado[] Consultar(Teste.ProcessadorEstado.Estado estado_) {
            return base.Channel.Consultar(estado_);
        }
    }
}