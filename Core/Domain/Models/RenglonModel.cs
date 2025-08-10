namespace SimuladorFacturacion.Core.Domain.Models
{
    public class RenglonModel
    {
        public string Codigo { get; set; }
        public string ProductoServicio { get; set; }
        public string UnidadMedida { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal PorcentajeBonificacion { get; set; }
        public decimal AlicuotaIVA { get; set; }
        public decimal GetImporteBonificacion() => (PrecioUnitario * Cantidad) * (PorcentajeBonificacion / 100M);
        public decimal GetSubtotal() => (PrecioUnitario * Cantidad) + GetImporteBonificacion();
        public decimal GetImporteIVA() => GetSubtotal() * (AlicuotaIVA / 100M);
        public decimal GetSubtotalConIVA() => GetSubtotal() + GetImporteIVA();
        //RDLC
        public decimal ImporteBon => GetImporteBonificacion();
        public decimal Subtotal => GetSubtotal();
        public decimal ImporteIVA => GetImporteIVA();
        public decimal SubtotalconIVA => GetSubtotalConIVA();
        public decimal PorcentajeBon => PorcentajeBonificacion;
        public string AlicuotaNombre { get; set; }
        public bool EsVacio => string.IsNullOrWhiteSpace(ProductoServicio);
    }
}
