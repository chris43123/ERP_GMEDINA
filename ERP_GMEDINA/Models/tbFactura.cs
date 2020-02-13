
namespace ERP_GMEDINA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbFactura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbFactura()
        {
            this.tbSalida = new HashSet<tbSalida>();
            this.DatosConsumidorFinal = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal1 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal2 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal3 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal4 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal5 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal6 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal7 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal8 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal9 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal10 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal11 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal12 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal13 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal14 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal15 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal16 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal17 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal18 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal19 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal20 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal21 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal22 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal23 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal24 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal25 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal26 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal27 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal28 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal29 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal30 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal31 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal32 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal33 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal34 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal35 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal36 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal37 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal38 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal39 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal40 = new HashSet<DatosConsumidorFinal>();
            this.DatosConsumidorFinal41 = new HashSet<DatosConsumidorFinal>();
            this.tbDevolucion = new HashSet<tbDevolucion>();
            this.tbFacturaHistorica = new HashSet<tbFacturaHistorica>();
            this.tbPago = new HashSet<tbPago>();
            this.tbPedido = new HashSet<tbPedido>();
            this.tbFacturaDetalle = new HashSet<tbFacturaDetalle>();
        }
    
        public long fact_Id { get; set; }
        public string fact_Codigo { get; set; }
        public System.DateTime fact_Fecha { get; set; }
        public byte esfac_Id { get; set; }
        public short cja_Id { get; set; }
        public int suc_Id { get; set; }
        public int clte_Id { get; set; }
        public string pemi_NumeroCAI { get; set; }
        public bool fact_AlCredito { get; set; }
        public int fact_DiasCredito { get; set; }
        public decimal fact_PorcentajeDescuento { get; set; }
        public string fact_Vendedor { get; set; }
        public string clte_Identificacion { get; set; }
        public string clte_Nombres { get; set; }
        public string fact_IdentidadTE { get; set; }
        public string fact_NombresTE { get; set; }
        public Nullable<System.DateTime> fact_FechaNacimientoTE { get; set; }
        public Nullable<int> fact_UsuarioAutoriza { get; set; }
        public Nullable<System.DateTime> fact_FechaAutoriza { get; set; }
        public bool fact_EsAnulada { get; set; }
        public string fact_RazonAnulado { get; set; }
        public int fact_UsuarioCrea { get; set; }
        public System.DateTime fact_FechaCrea { get; set; }
        public Nullable<int> fact_UsuarioModifica { get; set; }
        public Nullable<System.DateTime> fact_FechaModifica { get; set; }
    
        public virtual tbUsuario tbUsuario { get; set; }
        public virtual tbUsuario tbUsuario1 { get; set; }
        public virtual tbUsuario tbUsuario2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbSalida> tbSalida { get; set; }
        public virtual tbSucursales tbSucursales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal6 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal7 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal8 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal9 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal10 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal11 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal12 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal13 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal14 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal15 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal16 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal17 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal18 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal19 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal20 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal21 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal22 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal23 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal24 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal25 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal26 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal27 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal28 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal29 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal30 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal31 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal32 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal33 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal34 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal35 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal36 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal37 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal38 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal39 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal40 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosConsumidorFinal> DatosConsumidorFinal41 { get; set; }
        public virtual tbCaja tbCaja { get; set; }
        public virtual tbCliente tbCliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbDevolucion> tbDevolucion { get; set; }
        public virtual tbEstadoFactura tbEstadoFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFacturaHistorica> tbFacturaHistorica { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPago> tbPago { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbPedido> tbPedido { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbFacturaDetalle> tbFacturaDetalle { get; set; }
    }
}
