using SimuladorFacturacion.Core.Domain.Models;
using SimuladorFacturacion.Core.Domain.Interfaces.Builders;
using System;

namespace SimuladorFacturacion.Infraestructure.Builders
{
    public class ComprobanteBuilder : IComprobanteBuilder
    {
        private ComprobanteModel _comprobante;

        public ComprobanteBuilder() => Reset();

        public ComprobanteModel Build()
        {
            var result = _comprobante;
            Reset();
            return result;
        }

        public ComprobanteModel GetProduct()
        {
            return _comprobante;
        }

        public void Reset()
        {
            _comprobante = new ComprobanteModel();
        }

        public IComprobanteBuilder SetPuntoVenta(int puntoVenta)
        {
            _comprobante.PuntoVenta = puntoVenta;
            return this;
        }

        public IComprobanteBuilder SetNumero(int numero)
        {
            _comprobante.NumeroComprobante = numero;
            return this;
        }

        public IComprobanteBuilder SetTipo(string tipo)
        {
            _comprobante.TipoComprobante = tipo;
            return this;
        }

        public IComprobanteBuilder SetLetra(string letra)
        {
            _comprobante.LetraComprobante = letra;
            return this;
        }

        public IComprobanteBuilder SetFechaEmision(DateTime fecha)
        {
            _comprobante.FechaEmision = fecha;
            return this;
        }

        public IComprobanteBuilder SetDatos(int puntoVenta, int numero, string tipo)
        {
            _comprobante.PuntoVenta = puntoVenta;
            _comprobante.NumeroComprobante = numero;
            _comprobante.TipoComprobante = tipo;
            return this;
        }

        public IComprobanteBuilder SetDatos(int puntoVenta, int numero, string tipo, DateTime fecha)
        {
            SetDatos(puntoVenta, numero, tipo);
            _comprobante.FechaEmision = fecha;
            return this;
        }

        public IComprobanteBuilder SetDatos(int puntoVenta, int numero, string tipo, string letra, DateTime fecha)
        {
            SetDatos(puntoVenta, numero, tipo, fecha);
            _comprobante.LetraComprobante = letra;
            return this;
        }

    }
}
