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
    
    public partial class V_Empleados_Sueldos
    {
        public int emp_Id { get; set; }
        public int per_Id { get; set; }
        public string per_Nombres { get; set; }
        public string per_Apellidos { get; set; }
        public string per_NombreCompleto { get; set; }
        public int car_Id { get; set; }
        public int area_Id { get; set; }
        public int depto_Id { get; set; }
        public int jor_Id { get; set; }
        public decimal sue_Cantidad { get; set; }
        public int cpla_IdPlanilla { get; set; }
        public int fpa_IdFormaPago { get; set; }
        public bool emp_Estado { get; set; }
    }
}
