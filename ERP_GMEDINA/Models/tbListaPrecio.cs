
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbListaPrecio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbListaPrecio()
        {
            this.tbListadoPrecioDetalle = new HashSet<tbListadoPrecioDetalle>();
        }
    
        public int listp_Id { get; set; }
        public string listp_Nombre { get; set; }
        public bool listp_EsActivo { get; set; }
        public int listp_UsuarioCrea { get; set; }
        public System.DateTime listp_FechaCrea { get; set; }
        public Nullable<int> listp_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> listp_FechaModifica { get; set; }
        public Nullable<System.DateTime> listp_FechaInicioVigencia { get; set; }
        public Nullable<System.DateTime> listp_FechaFinalVigencia { get; set; }
        public Nullable<short> listp_Prioridad { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbListadoPrecioDetalle> tbListadoPrecioDetalle { get; set; }
    }
}
