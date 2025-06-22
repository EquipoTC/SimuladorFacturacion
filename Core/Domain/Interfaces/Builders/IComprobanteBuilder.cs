using SimuladorFacturacion.Core.Domain.Models;
using System;

namespace SimuladorFacturacion.Interfaces
{
    public interface IComprobanteBuilder : IBuilder<ComprobanteModel>
    {
        IComprobanteBuilder SetPuntoVenta(int puntoVenta);
        IComprobanteBuilder SetNumero(int numero);
        IComprobanteBuilder SetTipo(string tipo);
        IComprobanteBuilder SetLetra(string letra);
        IComprobanteBuilder SetFechaEmision(DateTime fecha);
        IComprobanteBuilder SetDatos(int puntoVenta, int numero, string tipo);
        IComprobanteBuilder SetDatos(int puntoVenta, int numero, string tipo, DateTime fecha);
        IComprobanteBuilder SetDatos(int puntoVenta, int numero, string tipo, string letra, DateTime fecha);
    }
}