using SimuladorFacturacion.Models;

namespace SimuladorFacturacion.Interfaces
{
    public interface IRenglonBuilder
    {
        IRenglonBuilder SetCodigo(string codigo);
        IRenglonBuilder SetProductoServicio(string productoServicio);
        IRenglonBuilder SetCantidad(decimal cantidad);
        IRenglonBuilder SetUnidadMedida(string unidadMedida);
        IRenglonBuilder SetPrecioUnitario(decimal precio);
        IRenglonBuilder SetPorcentajeBonificacion(decimal porcentaje);
        IRenglonBuilder SetAlicuotaIVA(decimal alicuota);
        IRenglonBuilder SetDatos(string codigo, string productoServicio, decimal cantidad, string unidadMedida, decimal precioUnitario);
        IRenglonBuilder SetDatos(string codigo, string productoServicio, decimal cantidad, string unidadMedida, decimal precioUnitario, decimal porcentajeBonificacion);
        IRenglonBuilder SetDatos(string codigo, string productoServicio, decimal cantidad, string unidadMedida, decimal precioUnitario, decimal porcentajeBonificacion, decimal alicuotaIVA);
        RenglonModel Build();
    }
}