using SimuladorFacturacion.Models;
using SimuladorFacturacion.Services;
using System;

namespace SimuladorFacturacion.Interfaces
{
    public interface IFacturaBuilder : IBuilder<FacturacionModel>
    {
        IFacturaBuilder AddEmisor(string razonSocial, string cuit);
        IFacturaBuilder AddReceptor(string razonSocial, string cuit);
        IFacturaBuilder AddFecha(DateTime fecha);
        IFacturaBuilder AddPuntoVenta(int puntoVenta);
        IFacturaBuilder AddNumeroComprobante(int numero);
        IFacturaBuilder AddTipoComprobante(string tipo);
        IFacturaBuilder AddRenglon(RenglonModel renglon);
    }
}
