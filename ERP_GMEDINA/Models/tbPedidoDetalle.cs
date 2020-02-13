
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbPedidoDetalle
    {
        public int pedd_Id { get; set; }
        public int ped_Id { get; set; }
        public string prod_Codigo { get; set; }
        public decimal pedd_Cantidad { get; set; }
        public decimal pedd_CantidadFacturada { get; set; }
        public int pedd_UsuarioCrea { get; set; }
        public System.DateTime pedd_FechaCrea { get; set; }
        public Nullable<int> pedd_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> pedd_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbProducto tbProducto { get; set; }
        public virtual tbPedido tbPedido { get; set; }
    }
}
