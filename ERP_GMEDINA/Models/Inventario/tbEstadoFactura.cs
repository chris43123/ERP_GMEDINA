//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models.Inventario
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbEstadoFactura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbEstadoFactura()
        {
            this.tbFactura = new HashSet<tbFactura>();
            this.tbFacturaHistorica = new HashSet<tbFacturaHistorica>();
        }
    
        public byte esfac_Id { get; set; }
        public string esfac_Descripcion { get; set; }
        public int esfac_UsuarioCrea { get; set; }
        public System.DateTime esfac_FechaCrea { get; set; }
        public Nullable<int> esfac_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> esfac_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFactura> tbFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFacturaHistorica> tbFacturaHistorica { get; set; }
    }
}
