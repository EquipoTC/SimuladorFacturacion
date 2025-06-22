using SimuladorFacturacion;
using SimuladorFacturacion.Interfaces;
using SimuladorFacturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class FacturaBuilder : IFacturaBuilder
{
    private FacturaModel _factura;

    public FacturaBuilder() => Reset();

    public IFacturaBuilder AddEmisor(string razonSocial, string cuit)
    {
        _factura.Emisor.RazonSocial = razonSocial;
        _factura.Emisor.CUIT = cuit;
        return this;
    }

    public IFacturaBuilder AddEmisor(string razonSocial, string cuit, string domicilio)
    {
        AddEmisor(razonSocial, cuit);
        _factura.Emisor.DomicilioComercial = domicilio;
        return this;
    }

    public IFacturaBuilder AddEmisor(string razonSocial, string cuit, string domicilio, string condicionIVA)
    {
        AddEmisor(razonSocial, cuit, domicilio);
        _factura.Emisor.CondicionIVA = condicionIVA;
        return this;
    }

    public IFacturaBuilder AddEmisor(string razonSocial, string cuit, string domicilio, string condicionIVA, DateTime fechaInicioActividades)
    {
        AddEmisor(razonSocial, cuit, domicilio, condicionIVA);
        _factura.Emisor.FechaInicioActividades = fechaInicioActividades;
        return this;
    }

    // Métodos para Receptor
    public IFacturaBuilder AddReceptor(string razonSocial, string cuit)
    {
        _factura.Receptor.RazonSocial = razonSocial;
        _factura.Receptor.CUIT = cuit;
        return this;
    }

    public IFacturaBuilder AddReceptor(string razonSocial, string cuit, string domicilio)
    {
        AddReceptor(razonSocial, cuit);
        _factura.Receptor.DomicilioComercial = domicilio;
        return this;
    }

    public IFacturaBuilder AddReceptor(string razonSocial, string cuit, string domicilio, string condicionIVA)
    {
        AddReceptor(razonSocial, cuit, domicilio);
        _factura.Receptor.CondicionIVA = condicionIVA;
        return this;
    }

    public IFacturaBuilder AddReceptor(string razonSocial, string cuit, string domicilio, string condicionIVA, string email)
    {
        AddReceptor(razonSocial, cuit, domicilio, condicionIVA);
        _factura.Receptor.Email = email;
        return this;
    }

    public IFacturaBuilder AddComprobante(int puntoVenta, int numero, string tipo)
    {
        _factura.Comprobante.PuntoVenta = puntoVenta;
        _factura.Comprobante.NumeroComprobante = numero;
        _factura.Comprobante.TipoComprobante = tipo;
        return this;
    }

    public IFacturaBuilder AddComprobante(int puntoVenta, int numero, string tipo, DateTime fecha)
    {
        AddComprobante(puntoVenta, numero, tipo);
        _factura.Comprobante.FechaEmision = fecha;
        return this;
    }

    public IFacturaBuilder AddComprobante(int puntoVenta, int numero, string tipo, string letra, DateTime fecha)
    {
        AddComprobante(puntoVenta, numero, tipo, fecha);
        _factura.Comprobante.LetraComprobante = letra;
        return this;
    }

    public IFacturaBuilder AddRenglon(string codigo, string descripcion, decimal cantidad, string unidadMedida, decimal precioUnitario)
    {
        return AddRenglon(codigo, descripcion, cantidad, unidadMedida, precioUnitario, 0, 21);
    }

    public IFacturaBuilder AddRenglon(string codigo, string descripcion, decimal cantidad, string unidadMedida, decimal precioUnitario, decimal porcentajeBonificacion)
    {
        return AddRenglon(codigo, descripcion, cantidad, unidadMedida, precioUnitario, porcentajeBonificacion, 21);
    }

    public IFacturaBuilder AddRenglon(string codigo, string descripcion, decimal cantidad, string unidadMedida, decimal precioUnitario, decimal porcentajeBonificacion, decimal alicuotaIVA)
    {
        var importeBonificacion = (precioUnitario * cantidad * porcentajeBonificacion) / 100;
        var subtotal = (precioUnitario * cantidad) - importeBonificacion;
        var importeIVA = subtotal * (alicuotaIVA / 100);
        var subtotalConIVA = subtotal + importeIVA;

        var renglon = new RenglonModel
        {
            Codigo = codigo,
            ProductoServicio = descripcion,
            Cantidad = (int)cantidad,
            UnidadMedida = unidadMedida,
            PrecioUnitario = precioUnitario,
            PorcentajeBonificacion = porcentajeBonificacion,
            AlicuotaIVA = alicuotaIVA
        };

        _factura.Renglones.Add(renglon);
        return this;
    }
    public IFacturaBuilder SetIVA27(decimal importe)
    {
        _factura.Totales.IVA27 = importe;
        return this;
    }

    public IFacturaBuilder SetIVA21(decimal importe)
    {
        _factura.Totales.IVA21 = importe;
        return this;
    }

    public IFacturaBuilder SetIVA0(decimal importe)
    {
        _factura.Totales.IVA0 = importe;
        return this;
    }

    public IFacturaBuilder SetTotales(decimal netoGravado, decimal total)
    {
        _factura.Totales.NetoGravado = netoGravado;
        return this;
    }

    public IFacturaBuilder SetTotales(decimal netoGravado, decimal total, decimal otrosTributos)
    {
        _factura.Totales.NetoGravado = netoGravado;
        _factura.Totales.OtrosTributos = otrosTributos;
        return this;
    }

    public FacturaModel Build()
    {
        var result = _factura;
        Reset();
        return result;
    }

    public void Reset()
    {
        _factura = new FacturaModel
        {
            Renglones = new List<RenglonModel>(),
            FechaEmision = DateTime.Now
        };
    }
}