
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbAreas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbAreas()
        {
            this.tbDepartamentos = new HashSet<tbDepartamentos>();
            this.tbEmpleados = new HashSet<tbEmpleados>();
        }
    
        public int area_Id { get; set; }
        public int car_Id { get; set; }
        public int suc_Id { get; set; }
        public string area_Descripcion { get; set; }
        public bool area_Estado { get; set; }
        public string area_Razoninactivo { get; set; }
        public int area_Usuariocrea { get; set; }
        public System.DateTime area_Fechacrea { get; set; }
        public Nullable<int> area_Usuariomodifica { get; set; }
        public Nullable<System.DateTime> area_Fechamodifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDepartamentos> tbDepartamentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbEmpleados> tbEmpleados { get; set; }
        public virtual tbCargos tbCargos { get; set; }
        public virtual tbSucursales tbSucursales { get; set; }
    }
}
