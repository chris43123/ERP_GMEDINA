//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbHistorialPermisos
    {
        public int hper_Id { get; set; }
        public int emp_Id { get; set; }
        public int tper_Id { get; set; }
        public System.DateTime hper_fechaInicio { get; set; }
        public System.DateTime hper_fechaFin { get; set; }
        public int hper_Duracion { get; set; }
        public string hper_Observacion { get; set; }
        public int hper_PorcentajeIndemnizado { get; set; }
        public bool hper_Estado { get; set; }
        public string hper_RazonInactivo { get; set; }
        public int hper_UsuarioCrea { get; set; }
        public System.DateTime hper_FechaCrea { get; set; }
        public Nullable<int> hper_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> hper_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbEmpleados tbEmpleados { get; set; }
        public virtual tbTipoPermisos tbTipoPermisos { get; set; }
    }
}
