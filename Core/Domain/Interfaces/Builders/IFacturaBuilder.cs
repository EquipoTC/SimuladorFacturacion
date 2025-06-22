using SimuladorFacturacion.Models;
using SimuladorFacturacion.Services;
using System;

namespace SimuladorFacturacion.Interfaces
{
    public interface IFacturaBuilder : IBuilder<FacturaModel>
    {
        IFacturaBuilder AddEmisor(string razonSocial, string cuit);
        IFacturaBuilder AddEmisor(string razonSocial, string cuit, string domicilio);
        IFacturaBuilder AddEmisor(string razonSocial, string cuit, string domicilio, string condicionIVA);
        IFacturaBuilder AddEmisor(string razonSocial, string cuit, string domicilio, string condicionIVA, DateTime fechaInicioActividades);
        IFacturaBuilder AddReceptor(string razonSocial, string cuit);
        IFacturaBuilder AddReceptor(string razonSocial, string cuit, string domicilio);
        IFacturaBuilder AddReceptor(string razonSocial, string cuit, string domicilio, string condicionIVA);
        IFacturaBuilder AddReceptor(string razonSocial, string cuit, string domicilio, string condicionIVA, string email);
        IFacturaBuilder AddComprobante(int puntoVenta, int numero, string tipo);
        IFacturaBuilder AddComprobante(int puntoVenta, int numero, string tipo, DateTime fecha);
        IFacturaBuilder AddComprobante(int puntoVenta, int numero, string tipo, string letra, DateTime fecha);
        IFacturaBuilder AddRenglon(string codigo, string descripcion, decimal cantidad, string unidadMedida, decimal precioUnitario);
        IFacturaBuilder AddRenglon(string codigo, string descripcion, decimal cantidad, string unidadMedida, decimal precioUnitario, decimal porcentajeBonificacion);
        IFacturaBuilder AddRenglon(string codigo, string descripcion, decimal cantidad, string unidadMedida, decimal precioUnitario, decimal porcentajeBonificacion, string alicuotaIVA);
        IFacturaBuilder SetIVA27(decimal importe);
        IFacturaBuilder SetIVA21(decimal importe);
        IFacturaBuilder SetIVA0(decimal importe);
        IFacturaBuilder SetTotales(decimal netoGravado, decimal total);
        IFacturaBuilder SetTotales(decimal netoGravado, decimal total, decimal otrosTributos);
    }
}
