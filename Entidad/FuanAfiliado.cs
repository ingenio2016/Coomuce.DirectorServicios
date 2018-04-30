//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coomuce.DirectorServicios.Entidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class FuanAfiliado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FuanAfiliado()
        {
            this.EncuestaEps = new HashSet<EncuestaEps>();
            this.EncuestaIps = new HashSet<EncuestaIps>();
            this.FuanBeneficiariosAfiliado = new HashSet<FuanBeneficiariosAfiliado>();
            this.FuanEmpleadorAfiliado = new HashSet<FuanEmpleadorAfiliado>();
            this.FuanIpsPrimariaAfiliado = new HashSet<FuanIpsPrimariaAfiliado>();
            this.FuanReporteNovedad = new HashSet<FuanReporteNovedad>();
            this.InfoHfdfr = new HashSet<InfoHfdfr>();
            this.InfoIfppir = new HashSet<InfoIfppir>();
            this.ListaAsistenciaGeneral = new HashSet<ListaAsistenciaGeneral>();
            this.Purisu = new HashSet<Purisu>();
        }
    
        public int idFuanAfiliado { get; set; }
        public Nullable<int> idFuan { get; set; }
        public string tipoFuanAfiliado { get; set; }
        public string primerApellidoFuanAfiliado { get; set; }
        public string segundoApellidoFuanAfiliado { get; set; }
        public string primerNombreFuanAfiliado { get; set; }
        public string segundoNombreFuanAfiliado { get; set; }
        public byte idTipoIdentificacion { get; set; }
        public string identificacionFuanAfiliado { get; set; }
        public byte idTipoSexo { get; set; }
        public System.DateTime fechaNacimientoFuanAfiliado { get; set; }
        public byte idTipoEtnia { get; set; }
        public Nullable<byte> idTipoDiscapacidad { get; set; }
        public Nullable<byte> idCondicionDiscapacidad { get; set; }
        public Nullable<decimal> puntajeSisbenFuanAfiliado { get; set; }
        public string numCarnetFuanAfiliado { get; set; }
        public Nullable<byte> idGrupoPoblacional { get; set; }
        public string arlFuanAfiliado { get; set; }
        public string pensionFuanAfiliado { get; set; }
        public Nullable<decimal> ibcFuanAfiliado { get; set; }
        public string direccionFuanAfiliado { get; set; }
        public string telefonoFuanAfiliado { get; set; }
        public string celularFuanAfiliado { get; set; }
        public string emailFuanAfiliado { get; set; }
        public Nullable<short> idCiudad { get; set; }
        public byte idTipoZona { get; set; }
        public string barrioFuanAfiliado { get; set; }
        public string primerApellidoConyugueFuanAfiliado { get; set; }
        public string segundoApellidoConyugueFuanAfiliado { get; set; }
        public string primerNombreConyugueFuanAfiliado { get; set; }
        public string segundoNombreConyugueFuanAfiliado { get; set; }
        public Nullable<byte> idTipoIdentificacionConyugue { get; set; }
        public string identificacionConyugueFuanAfiliado { get; set; }
        public Nullable<byte> idTipoSexoConyugue { get; set; }
        public Nullable<System.DateTime> fechaNacimientoConyugueFuanAfiliado { get; set; }
        public Nullable<decimal> upcFuanAfiliado { get; set; }
        public string firmaFuanAfiliado { get; set; }
        public Nullable<int> cabezafamilia { get; set; }
        public Nullable<int> grupofamiliar { get; set; }
    
        public virtual Ciudad Ciudad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncuestaEps> EncuestaEps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EncuestaIps> EncuestaIps { get; set; }
        public virtual Fuan Fuan { get; set; }
        public virtual CondicionDiscapacidad CondicionDiscapacidad { get; set; }
        public virtual GrupoPoblacional GrupoPoblacional { get; set; }
        public virtual TipoDiscapacidad TipoDiscapacidad { get; set; }
        public virtual TipoEtnia TipoEtnia { get; set; }
        public virtual TipoIdentificacion TipoIdentificacion { get; set; }
        public virtual TipoIdentificacion TipoIdentificacion1 { get; set; }
        public virtual TipoSexo TipoSexo { get; set; }
        public virtual TipoSexo TipoSexo1 { get; set; }
        public virtual TipoZona TipoZona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanBeneficiariosAfiliado> FuanBeneficiariosAfiliado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanEmpleadorAfiliado> FuanEmpleadorAfiliado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanIpsPrimariaAfiliado> FuanIpsPrimariaAfiliado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanReporteNovedad> FuanReporteNovedad { get; set; }
        public virtual HistorialUltimosFormatos HistorialUltimosFormatos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoHfdfr> InfoHfdfr { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoIfppir> InfoIfppir { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ListaAsistenciaGeneral> ListaAsistenciaGeneral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purisu> Purisu { get; set; }
    }
}
