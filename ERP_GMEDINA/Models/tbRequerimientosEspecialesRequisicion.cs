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
    
    public partial class tbRequerimientosEspecialesRequisicion
    {
        public int rer_Id { get; set; }
        public int req_Id { get; set; }
        public int resp_Id { get; set; }
        public bool rer_Estado { get; set; }
        public string rer_RazonInactivo { get; set; }
        public int rer_UsuarioCrea { get; set; }
        public System.DateTime rer_FechaCrea { get; set; }
        public Nullable<int> rer_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> rer_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbRequerimientosEspeciales tbRequerimientosEspeciales { get; set; }
        public virtual tbRequisiciones tbRequisiciones { get; set; }
    }
}
