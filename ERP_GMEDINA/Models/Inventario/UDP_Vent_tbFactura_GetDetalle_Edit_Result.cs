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
    
    public partial class UDP_Vent_tbFactura_GetDetalle_Edit_Result
    {
        public short factd_Id { get; set; }
        public string prod_Codigo { get; set; }
        public string prod_Descripcion { get; set; }
        public decimal factd_Cantidad { get; set; }
        public decimal factd_MontoDescuento { get; set; }
        public decimal factd_Impuesto { get; set; }
        public decimal factd_PrecioUnitario { get; set; }
        public int factd_UsuarioCrea { get; set; }
        public System.DateTime factd_FechaCrea { get; set; }
    }
}
