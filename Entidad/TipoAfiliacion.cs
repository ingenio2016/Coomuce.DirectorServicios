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
    
    public partial class TipoAfiliacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoAfiliacion()
        {
            this.Fuan = new HashSet<Fuan>();
        }
    
        public byte idTipoAfiliacion { get; set; }
        public string codigoTipoAfiliacion { get; set; }
        public string nombreTipoAfiliacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fuan> Fuan { get; set; }
    }
}
