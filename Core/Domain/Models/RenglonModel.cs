using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFacturacion
{
    public class RenglonModel
    {
        public string Codigo { get; set; }
        public string ProductoServicio { get; set; }
        public int Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PorcentajeBonificacion { get; set; }
        public decimal AlicuotaIVA { get; set; }
        public decimal GetImporteBonificacion() => (PrecioUnitario * Cantidad) * (PorcentajeBonificacion / 100);
        public decimal GetSubtotal() => (PrecioUnitario * Cantidad) - GetImporteBonificacion();
        public decimal GetImporteIVA() => GetSubtotal() * (AlicuotaIVA / 100);
        public decimal GetSubtotalConIVA() => GetSubtotal() + GetImporteIVA();

        public bool EsVacio => string.IsNullOrWhiteSpace(ProductoServicio);
        /*
        public string Codigo { get; set; }
        public string ProductoServicio { get; set; }
        public string Cantidad { get; set; }
        public string UnidadMedida { get; set; }
        public string PrecioUnitario { get; set; }
        public string PorcentajeBon { get; set; }
        public string ImporteBon { get; set; }
        public string Subtotal { get; set; }
        public string AlicuotaIVA { get; set; }
        public string ImporteIVA { get; set; }
        public string SubtotalconIVA { get; set; }
        */
    }
}
