﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaWeb.DetalleProductoServ {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetalleProducto", Namespace="http://schemas.datacontract.org/2004/07/CapaEntidad")]
    [System.SerializableAttribute()]
    public partial class DetalleProducto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> CantidadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal IdDetalleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> NumeroBoletaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductoNombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> ProductoPrecioField;
        
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
        public System.Nullable<decimal> Cantidad {
            get {
                return this.CantidadField;
            }
            set {
                if ((this.CantidadField.Equals(value) != true)) {
                    this.CantidadField = value;
                    this.RaisePropertyChanged("Cantidad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal IdDetalle {
            get {
                return this.IdDetalleField;
            }
            set {
                if ((this.IdDetalleField.Equals(value) != true)) {
                    this.IdDetalleField = value;
                    this.RaisePropertyChanged("IdDetalle");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> NumeroBoleta {
            get {
                return this.NumeroBoletaField;
            }
            set {
                if ((this.NumeroBoletaField.Equals(value) != true)) {
                    this.NumeroBoletaField = value;
                    this.RaisePropertyChanged("NumeroBoleta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductoNombre {
            get {
                return this.ProductoNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductoNombreField, value) != true)) {
                    this.ProductoNombreField = value;
                    this.RaisePropertyChanged("ProductoNombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> ProductoPrecio {
            get {
                return this.ProductoPrecioField;
            }
            set {
                if ((this.ProductoPrecioField.Equals(value) != true)) {
                    this.ProductoPrecioField = value;
                    this.RaisePropertyChanged("ProductoPrecio");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DetalleProductoServ.IServicioDetalleProducto")]
    public interface IServicioDetalleProducto {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDetalleProducto/ListarDetalleProductos", ReplyAction="http://tempuri.org/IServicioDetalleProducto/ListarDetalleProductosResponse")]
        CapaWeb.DetalleProductoServ.DetalleProducto[] ListarDetalleProductos(decimal numeroBoleta);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioDetalleProducto/ListarDetalleProductos", ReplyAction="http://tempuri.org/IServicioDetalleProducto/ListarDetalleProductosResponse")]
        System.Threading.Tasks.Task<CapaWeb.DetalleProductoServ.DetalleProducto[]> ListarDetalleProductosAsync(decimal numeroBoleta);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioDetalleProductoChannel : CapaWeb.DetalleProductoServ.IServicioDetalleProducto, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioDetalleProductoClient : System.ServiceModel.ClientBase<CapaWeb.DetalleProductoServ.IServicioDetalleProducto>, CapaWeb.DetalleProductoServ.IServicioDetalleProducto {
        
        public ServicioDetalleProductoClient() {
        }
        
        public ServicioDetalleProductoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioDetalleProductoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioDetalleProductoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioDetalleProductoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CapaWeb.DetalleProductoServ.DetalleProducto[] ListarDetalleProductos(decimal numeroBoleta) {
            return base.Channel.ListarDetalleProductos(numeroBoleta);
        }
        
        public System.Threading.Tasks.Task<CapaWeb.DetalleProductoServ.DetalleProducto[]> ListarDetalleProductosAsync(decimal numeroBoleta) {
            return base.Channel.ListarDetalleProductosAsync(numeroBoleta);
        }
    }
}
