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
    
    public partial class tbSolicitudEfectivoDetalle
    {
        public int soled_Id { get; set; }
        public int solef_Id { get; set; }
        public short deno_Id { get; set; }
        public short soled_CantidadSolicitada { get; set; }
        public short soled_CantidadEntregada { get; set; }
        public decimal soled_MontoEntregado { get; set; }
        public int soled_UsuarioCrea { get; set; }
        public System.DateTime soled_FechaCrea { get; set; }
        public Nullable<int> soled_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> soled_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbDenominacion tbDenominacion { get; set; }
        public virtual tbSolicitudEfectivo tbSolicitudEfectivo { get; set; }
    }
}
