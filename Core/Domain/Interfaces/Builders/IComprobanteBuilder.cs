using SimuladorFacturacion.Core.Domain.Models;
using System;

namespace SimuladorFacturacion.Core.Domain.Interfaces.Builders
{
    public interface IComprobanteBuilder : IBuilder<ComprobanteModel>
    {
        IComprobanteBuilder SetPuntoVenta(string puntoVenta);
        IComprobanteBuilder SetNumero(int numero);
        IComprobanteBuilder SetTipo(string tipo);
        IComprobanteBuilder SetLetra(string letra);
        IComprobanteBuilder SetFechaEmision(DateTime fecha);
        IComprobanteBuilder SetConceptos(string conceptos);
        IComprobanteBuilder SetCondicionesVenta(string condiciones);
        IComprobanteBuilder SetDatos(string puntoVenta, int numero, string tipo);
        IComprobanteBuilder SetDatos(string puntoVenta, int numero, string tipo, DateTime fecha);
        IComprobanteBuilder SetDatos(string puntoVenta, int numero, string tipo, string letra, DateTime fecha);
    }
}