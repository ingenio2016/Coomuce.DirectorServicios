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
    
    public partial class TipoRegimen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoRegimen()
        {
            this.Fuan = new HashSet<Fuan>();
        }
    
        public byte idTipoRegimen { get; set; }
        public string codigoTipoRegimen { get; set; }
        public string nombreTipoRegimen { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fuan> Fuan { get; set; }
    }
}