﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coomuce.DirectorServicios.ServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Ficha_042EL", Namespace="http://schemas.datacontract.org/2004/07/Ecoopsos.Entity.PromocionyPrevencion")]
    [System.SerializableAttribute()]
    public partial class Ficha_042EL : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short AbortosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CarnetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CelularField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short CesareasField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short ClasificacionCorporalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoCanalizaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoDeptoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoEscolaridadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoIpsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoMunField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoRazaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short ColesterolHDLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short ColesterolLDLField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short ColesterolTotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short EdadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FechaDigitaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FechaFichaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaTomaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FechaUltReglaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FormaCanalizaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short GestacionesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool GestanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short GlicemiaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short PartosField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short PerimetroAdbominalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short PesoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private Coomuce.DirectorServicios.ServiceReference.RespuestasFicha_042EL[] RespuestasFicha_042ELField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool SinFichaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short TallaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short TensionDiastolicaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short TensionSistolicaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioDigitaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsuarioDiligenciaField;
        
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
        public short Abortos {
            get {
                return this.AbortosField;
            }
            set {
                if ((this.AbortosField.Equals(value) != true)) {
                    this.AbortosField = value;
                    this.RaisePropertyChanged("Abortos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Carnet {
            get {
                return this.CarnetField;
            }
            set {
                if ((object.ReferenceEquals(this.CarnetField, value) != true)) {
                    this.CarnetField = value;
                    this.RaisePropertyChanged("Carnet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Celular {
            get {
                return this.CelularField;
            }
            set {
                if ((object.ReferenceEquals(this.CelularField, value) != true)) {
                    this.CelularField = value;
                    this.RaisePropertyChanged("Celular");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Cesareas {
            get {
                return this.CesareasField;
            }
            set {
                if ((this.CesareasField.Equals(value) != true)) {
                    this.CesareasField = value;
                    this.RaisePropertyChanged("Cesareas");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short ClasificacionCorporal {
            get {
                return this.ClasificacionCorporalField;
            }
            set {
                if ((this.ClasificacionCorporalField.Equals(value) != true)) {
                    this.ClasificacionCorporalField = value;
                    this.RaisePropertyChanged("ClasificacionCorporal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoCanaliza {
            get {
                return this.CodigoCanalizaField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoCanalizaField, value) != true)) {
                    this.CodigoCanalizaField = value;
                    this.RaisePropertyChanged("CodigoCanaliza");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoDepto {
            get {
                return this.CodigoDeptoField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoDeptoField, value) != true)) {
                    this.CodigoDeptoField = value;
                    this.RaisePropertyChanged("CodigoDepto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoEscolaridad {
            get {
                return this.CodigoEscolaridadField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoEscolaridadField, value) != true)) {
                    this.CodigoEscolaridadField = value;
                    this.RaisePropertyChanged("CodigoEscolaridad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoIps {
            get {
                return this.CodigoIpsField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoIpsField, value) != true)) {
                    this.CodigoIpsField = value;
                    this.RaisePropertyChanged("CodigoIps");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoMun {
            get {
                return this.CodigoMunField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoMunField, value) != true)) {
                    this.CodigoMunField = value;
                    this.RaisePropertyChanged("CodigoMun");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoRaza {
            get {
                return this.CodigoRazaField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoRazaField, value) != true)) {
                    this.CodigoRazaField = value;
                    this.RaisePropertyChanged("CodigoRaza");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short ColesterolHDL {
            get {
                return this.ColesterolHDLField;
            }
            set {
                if ((this.ColesterolHDLField.Equals(value) != true)) {
                    this.ColesterolHDLField = value;
                    this.RaisePropertyChanged("ColesterolHDL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short ColesterolLDL {
            get {
                return this.ColesterolLDLField;
            }
            set {
                if ((this.ColesterolLDLField.Equals(value) != true)) {
                    this.ColesterolLDLField = value;
                    this.RaisePropertyChanged("ColesterolLDL");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short ColesterolTotal {
            get {
                return this.ColesterolTotalField;
            }
            set {
                if ((this.ColesterolTotalField.Equals(value) != true)) {
                    this.ColesterolTotalField = value;
                    this.RaisePropertyChanged("ColesterolTotal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Edad {
            get {
                return this.EdadField;
            }
            set {
                if ((this.EdadField.Equals(value) != true)) {
                    this.EdadField = value;
                    this.RaisePropertyChanged("Edad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FechaDigita {
            get {
                return this.FechaDigitaField;
            }
            set {
                if ((this.FechaDigitaField.Equals(value) != true)) {
                    this.FechaDigitaField = value;
                    this.RaisePropertyChanged("FechaDigita");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FechaFicha {
            get {
                return this.FechaFichaField;
            }
            set {
                if ((this.FechaFichaField.Equals(value) != true)) {
                    this.FechaFichaField = value;
                    this.RaisePropertyChanged("FechaFicha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaToma {
            get {
                return this.FechaTomaField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaTomaField, value) != true)) {
                    this.FechaTomaField = value;
                    this.RaisePropertyChanged("FechaToma");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FechaUltRegla {
            get {
                return this.FechaUltReglaField;
            }
            set {
                if ((this.FechaUltReglaField.Equals(value) != true)) {
                    this.FechaUltReglaField = value;
                    this.RaisePropertyChanged("FechaUltRegla");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FormaCanaliza {
            get {
                return this.FormaCanalizaField;
            }
            set {
                if ((object.ReferenceEquals(this.FormaCanalizaField, value) != true)) {
                    this.FormaCanalizaField = value;
                    this.RaisePropertyChanged("FormaCanaliza");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Gestaciones {
            get {
                return this.GestacionesField;
            }
            set {
                if ((this.GestacionesField.Equals(value) != true)) {
                    this.GestacionesField = value;
                    this.RaisePropertyChanged("Gestaciones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Gestante {
            get {
                return this.GestanteField;
            }
            set {
                if ((this.GestanteField.Equals(value) != true)) {
                    this.GestanteField = value;
                    this.RaisePropertyChanged("Gestante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Glicemia {
            get {
                return this.GlicemiaField;
            }
            set {
                if ((this.GlicemiaField.Equals(value) != true)) {
                    this.GlicemiaField = value;
                    this.RaisePropertyChanged("Glicemia");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Partos {
            get {
                return this.PartosField;
            }
            set {
                if ((this.PartosField.Equals(value) != true)) {
                    this.PartosField = value;
                    this.RaisePropertyChanged("Partos");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short PerimetroAdbominal {
            get {
                return this.PerimetroAdbominalField;
            }
            set {
                if ((this.PerimetroAdbominalField.Equals(value) != true)) {
                    this.PerimetroAdbominalField = value;
                    this.RaisePropertyChanged("PerimetroAdbominal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Peso {
            get {
                return this.PesoField;
            }
            set {
                if ((this.PesoField.Equals(value) != true)) {
                    this.PesoField = value;
                    this.RaisePropertyChanged("Peso");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Coomuce.DirectorServicios.ServiceReference.RespuestasFicha_042EL[] RespuestasFicha_042EL {
            get {
                return this.RespuestasFicha_042ELField;
            }
            set {
                if ((object.ReferenceEquals(this.RespuestasFicha_042ELField, value) != true)) {
                    this.RespuestasFicha_042ELField = value;
                    this.RaisePropertyChanged("RespuestasFicha_042EL");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool SinFicha {
            get {
                return this.SinFichaField;
            }
            set {
                if ((this.SinFichaField.Equals(value) != true)) {
                    this.SinFichaField = value;
                    this.RaisePropertyChanged("SinFicha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short Talla {
            get {
                return this.TallaField;
            }
            set {
                if ((this.TallaField.Equals(value) != true)) {
                    this.TallaField = value;
                    this.RaisePropertyChanged("Talla");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short TensionDiastolica {
            get {
                return this.TensionDiastolicaField;
            }
            set {
                if ((this.TensionDiastolicaField.Equals(value) != true)) {
                    this.TensionDiastolicaField = value;
                    this.RaisePropertyChanged("TensionDiastolica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short TensionSistolica {
            get {
                return this.TensionSistolicaField;
            }
            set {
                if ((this.TensionSistolicaField.Equals(value) != true)) {
                    this.TensionSistolicaField = value;
                    this.RaisePropertyChanged("TensionSistolica");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsuarioDigita {
            get {
                return this.UsuarioDigitaField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioDigitaField, value) != true)) {
                    this.UsuarioDigitaField = value;
                    this.RaisePropertyChanged("UsuarioDigita");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UsuarioDiligencia {
            get {
                return this.UsuarioDiligenciaField;
            }
            set {
                if ((object.ReferenceEquals(this.UsuarioDiligenciaField, value) != true)) {
                    this.UsuarioDiligenciaField = value;
                    this.RaisePropertyChanged("UsuarioDiligencia");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="RespuestasFicha_042EL", Namespace="http://schemas.datacontract.org/2004/07/Ecoopsos.Entity.PromocionyPrevencion")]
    [System.SerializableAttribute()]
    public partial class RespuestasFicha_042EL : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoComponenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoFactorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodigoSubComponenteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoRespuestaField;
        
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
        public string CodigoComponente {
            get {
                return this.CodigoComponenteField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoComponenteField, value) != true)) {
                    this.CodigoComponenteField = value;
                    this.RaisePropertyChanged("CodigoComponente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoFactor {
            get {
                return this.CodigoFactorField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoFactorField, value) != true)) {
                    this.CodigoFactorField = value;
                    this.RaisePropertyChanged("CodigoFactor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CodigoSubComponente {
            get {
                return this.CodigoSubComponenteField;
            }
            set {
                if ((object.ReferenceEquals(this.CodigoSubComponenteField, value) != true)) {
                    this.CodigoSubComponenteField = value;
                    this.RaisePropertyChanged("CodigoSubComponente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoRespuesta {
            get {
                return this.TipoRespuestaField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoRespuestaField, value) != true)) {
                    this.TipoRespuestaField = value;
                    this.RaisePropertyChanged("TipoRespuesta");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ResultadoFicha_042EL", Namespace="http://schemas.datacontract.org/2004/07/Ecoopsos.Entity.PromocionyPrevencion")]
    [System.SerializableAttribute()]
    public partial class ResultadoFicha_042EL : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CarnetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int FechaFichaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeField;
        
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
        public string Carnet {
            get {
                return this.CarnetField;
            }
            set {
                if ((object.ReferenceEquals(this.CarnetField, value) != true)) {
                    this.CarnetField = value;
                    this.RaisePropertyChanged("Carnet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int FechaFicha {
            get {
                return this.FechaFichaField;
            }
            set {
                if ((this.FechaFichaField.Equals(value) != true)) {
                    this.FechaFichaField = value;
                    this.RaisePropertyChanged("FechaFicha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensaje {
            get {
                return this.MensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeField, value) != true)) {
                    this.MensajeField = value;
                    this.RaisePropertyChanged("Mensaje");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="VerificaFicha_042EL", Namespace="http://schemas.datacontract.org/2004/07/Ecoopsos.Entity.PromocionyPrevencion")]
    [System.SerializableAttribute()]
    public partial class VerificaFicha_042EL : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AfiliadoActivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CarnetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ExisteAfiliadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ExisteFichaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensajeField;
        
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
        public bool AfiliadoActivo {
            get {
                return this.AfiliadoActivoField;
            }
            set {
                if ((this.AfiliadoActivoField.Equals(value) != true)) {
                    this.AfiliadoActivoField = value;
                    this.RaisePropertyChanged("AfiliadoActivo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Carnet {
            get {
                return this.CarnetField;
            }
            set {
                if ((object.ReferenceEquals(this.CarnetField, value) != true)) {
                    this.CarnetField = value;
                    this.RaisePropertyChanged("Carnet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ExisteAfiliado {
            get {
                return this.ExisteAfiliadoField;
            }
            set {
                if ((this.ExisteAfiliadoField.Equals(value) != true)) {
                    this.ExisteAfiliadoField = value;
                    this.RaisePropertyChanged("ExisteAfiliado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool ExisteFicha {
            get {
                return this.ExisteFichaField;
            }
            set {
                if ((this.ExisteFichaField.Equals(value) != true)) {
                    this.ExisteFichaField = value;
                    this.RaisePropertyChanged("ExisteFicha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensaje {
            get {
                return this.MensajeField;
            }
            set {
                if ((object.ReferenceEquals(this.MensajeField, value) != true)) {
                    this.MensajeField = value;
                    this.RaisePropertyChanged("Mensaje");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IFicha_042")]
    public interface IFicha_042 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFicha_042/CargarFicha042", ReplyAction="http://tempuri.org/IFicha_042/CargarFicha042Response")]
        Coomuce.DirectorServicios.ServiceReference.ResultadoFicha_042EL[] CargarFicha042(Coomuce.DirectorServicios.ServiceReference.Ficha_042EL[] Ficha, string Usuario, string Contraseña);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFicha_042/CargarFicha042", ReplyAction="http://tempuri.org/IFicha_042/CargarFicha042Response")]
        System.Threading.Tasks.Task<Coomuce.DirectorServicios.ServiceReference.ResultadoFicha_042EL[]> CargarFicha042Async(Coomuce.DirectorServicios.ServiceReference.Ficha_042EL[] Ficha, string Usuario, string Contraseña);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFicha_042/VerificaFicha042", ReplyAction="http://tempuri.org/IFicha_042/VerificaFicha042Response")]
        Coomuce.DirectorServicios.ServiceReference.VerificaFicha_042EL VerificaFicha042(string Usuario, string Contraseña, string Carnet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IFicha_042/VerificaFicha042", ReplyAction="http://tempuri.org/IFicha_042/VerificaFicha042Response")]
        System.Threading.Tasks.Task<Coomuce.DirectorServicios.ServiceReference.VerificaFicha_042EL> VerificaFicha042Async(string Usuario, string Contraseña, string Carnet);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IFicha_042Channel : Coomuce.DirectorServicios.ServiceReference.IFicha_042, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Ficha_042Client : System.ServiceModel.ClientBase<Coomuce.DirectorServicios.ServiceReference.IFicha_042>, Coomuce.DirectorServicios.ServiceReference.IFicha_042 {
        
        public Ficha_042Client() {
        }
        
        public Ficha_042Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Ficha_042Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Ficha_042Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Ficha_042Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Coomuce.DirectorServicios.ServiceReference.ResultadoFicha_042EL[] CargarFicha042(Coomuce.DirectorServicios.ServiceReference.Ficha_042EL[] Ficha, string Usuario, string Contraseña) {
            return base.Channel.CargarFicha042(Ficha, Usuario, Contraseña);
        }
        
        public System.Threading.Tasks.Task<Coomuce.DirectorServicios.ServiceReference.ResultadoFicha_042EL[]> CargarFicha042Async(Coomuce.DirectorServicios.ServiceReference.Ficha_042EL[] Ficha, string Usuario, string Contraseña) {
            return base.Channel.CargarFicha042Async(Ficha, Usuario, Contraseña);
        }
        
        public Coomuce.DirectorServicios.ServiceReference.VerificaFicha_042EL VerificaFicha042(string Usuario, string Contraseña, string Carnet) {
            return base.Channel.VerificaFicha042(Usuario, Contraseña, Carnet);
        }
        
        public System.Threading.Tasks.Task<Coomuce.DirectorServicios.ServiceReference.VerificaFicha_042EL> VerificaFicha042Async(string Usuario, string Contraseña, string Carnet) {
            return base.Channel.VerificaFicha042Async(Usuario, Contraseña, Carnet);
        }
    }
}
