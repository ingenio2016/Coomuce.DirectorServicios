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
    
    public partial class Vista
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vista()
        {
            this.Menu = new HashSet<Menu>();
        }
    
        public short idVista { get; set; }
        public string nombreVista { get; set; }
        public string idDomVista { get; set; }
        public string rutaVista { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Menu> Menu { get; set; }
    }
}
