
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UDV_Vent_DescuentosporFecha
    {
        public Nullable<long> Id { get; set; }
        public Nullable<System.DateTime> Fecha_factura { get; set; }
        public string fact_Codigo { get; set; }
        public string clte_Identificacion { get; set; }
        public string Nombres { get; set; }
        public string Tipo_Factura { get; set; }
        public string TIPO_DE_CLIENTE { get; set; }
        public string TIPO_DESCUENTO { get; set; }
        public Nullable<decimal> Descuento { get; set; }
        public Nullable<decimal> TotalFactura { get; set; }
    }
}
