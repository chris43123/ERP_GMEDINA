
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_Liquidaciones_RPT
    {
        public int emp_Id { get; set; }
        public string per_Identidad { get; set; }
        public string NombreCompleto { get; set; }
        public string depto_descripcion { get; set; }
        public string area_Descripcion { get; set; }
        public int cpla_IdPlanilla { get; set; }
        public string cpla_DescripcionPlanilla { get; set; }
        public System.DateTime hliq_fechaIngreso { get; set; }
        public System.DateTime hliq_fechaLiquidacion { get; set; }
        public int hliq_PorcentajeLiquidacion { get; set; }
        public string hliq_Observaciones { get; set; }
    }
}
