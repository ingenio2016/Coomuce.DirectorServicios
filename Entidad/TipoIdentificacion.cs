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
    
    public partial class TipoIdentificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoIdentificacion()
        {
            this.FuanAfiliado = new HashSet<FuanAfiliado>();
            this.FuanAfiliado1 = new HashSet<FuanAfiliado>();
            this.FuanBeneficiariosAfiliado = new HashSet<FuanBeneficiariosAfiliado>();
            this.FuanEmpleadorAfiliado = new HashSet<FuanEmpleadorAfiliado>();
            this.Ips = new HashSet<Ips>();
            this.Usuario = new HashSet<Usuario>();
        }
    
        public byte idTipoIdentificacion { get; set; }
        public string codigoTipoIdentificacion { get; set; }
        public string nombreTipoIdentificacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanAfiliado> FuanAfiliado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanAfiliado> FuanAfiliado1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanBeneficiariosAfiliado> FuanBeneficiariosAfiliado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanEmpleadorAfiliado> FuanEmpleadorAfiliado { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ips> Ips { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
