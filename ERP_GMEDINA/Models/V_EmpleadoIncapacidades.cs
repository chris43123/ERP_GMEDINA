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
    
    public partial class V_EmpleadoIncapacidades
    {
        public int emp_Id { get; set; }
        public string emp_NombreCompleto { get; set; }
        public int car_Id { get; set; }
        public string car_Descripcion { get; set; }
        public int depto_Id { get; set; }
        public string depto_Descripcion { get; set; }
        public bool emp_Estado { get; set; }
    }
}
