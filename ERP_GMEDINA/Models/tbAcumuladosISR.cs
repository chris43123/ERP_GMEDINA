//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbAcumuladosISR
    {
        public int aisr_Id { get; set; }
        public string aisr_Descripcion { get; set; }
        public decimal aisr_Monto { get; set; }
        public int aisr_UsuarioCrea { get; set; }
        public System.DateTime aisr_FechaCrea { get; set; }
        public Nullable<int> aisr_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> aisr_FechaModifica { get; set; }
        public bool aisr_Activo { get; set; }
        public Nullable<bool> aisr_DeducirISR { get; set; }
        public int emp_Id { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbEmpleados tbEmpleados { get; set; }
    }
}
