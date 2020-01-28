
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbCargos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbCargos()
        {
            this.tbAreas = new HashSet<tbAreas>();
            this.tbDepartamentos = new HashSet<tbDepartamentos>();
            this.tbEmpleados = new HashSet<tbEmpleados>();
            this.tbHistorialCargos = new HashSet<tbHistorialCargos>();
        }
    
        public int car_Id { get; set; }
        public string car_Descripcion { get; set; }
        public bool car_Estado { get; set; }
        public string car_RazonInactivo { get; set; }
        public int car_UsuarioCrea { get; set; }
        public System.DateTime car_FechaCrea { get; set; }
        public Nullable<int> car_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> car_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbAreas> tbAreas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDepartamentos> tbDepartamentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbHistorialCargos> tbHistorialCargos { get; set; }
    }
}
