
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbFacturaDetalle
    {
        public long fact_Id { get; set; }
        public short factd_Id { get; set; }
        public string prod_Codigo { get; set; }
        public decimal factd_Cantidad { get; set; }
        public decimal factd_MontoDescuento { get; set; }
        public decimal factd_PorcentajeDescuento { get; set; }
        public decimal factd_Impuesto { get; set; }
        public decimal factd_PrecioUnitario { get; set; }
        public Nullable<int> factd_UsuarioAutoriza { get; set; }
        public Nullable<System.DateTime> factd_FechaAutoriza { get; set; }
        public int factd_UsuarioCrea { get; set; }
        public System.DateTime factd_FechaCrea { get; set; }
        public Nullable<int> factd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> factd_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbUsuario tbUsuario2 { get; set; }
        public virtual tbProducto tbProducto { get; set; }
        public virtual tbFactura tbFactura { get; set; }
    }
}
