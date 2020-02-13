
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbCuponDescuento
    {
        public int cdto_ID { get; set; }
        public int suc_Id { get; set; }
        public System.DateTime cdto_FechaEmision { get; set; }
        public System.DateTime cdto_FechaVencimiento { get; set; }
        public Nullable<decimal> cdto_PorcentajeDescuento { get; set; }
        public Nullable<decimal> cdto_MontoDescuento { get; set; }
        public decimal cdto_MaximoMontoDescuento { get; set; }
        public decimal cdto_CantidadCompraMinima { get; set; }
        public bool cdto_Redimido { get; set; }
        public Nullable<System.DateTime> cdto_FechaRedencion { get; set; }
        public Nullable<bool> cdto_Anulado { get; set; }
        public string cdto_RazonAnulado { get; set; }
        public bool cdto_EsImpreso { get; set; }
        public int cdto_UsuarioCrea { get; set; }
        public System.DateTime cdto_FechaCrea { get; set; }
        public Nullable<int> cdto_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> cdto_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbSucursales tbSucursales { get; set; }
    }
}
