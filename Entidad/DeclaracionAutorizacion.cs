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
    
    public partial class DeclaracionAutorizacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeclaracionAutorizacion()
        {
            this.FuanDeclaracionAutorizacion = new HashSet<FuanDeclaracionAutorizacion>();
        }
    
        public byte idDeclaracionAutorizacion { get; set; }
        public string codigoDeclaracionAutorizacion { get; set; }
        public string descripcionDeclaracionAutorizacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuanDeclaracionAutorizacion> FuanDeclaracionAutorizacion { get; set; }
    }
}
