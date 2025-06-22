using SimuladorFacturacion.Interfaces;
using SimuladorFacturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Services
{
    public class FacturacionService : IFacturacionService 
    {
        public FacturacionModel Factura { get; private set; }

        public FacturacionService(FacturacionModel factura)
        {
            this.Factura = factura;
        }

        public void UpdateEmisorData(string razonSocial, string cuit, string domicilio, string condicionIVA, DateTime fechaInicio, string cuitConGuion)
        {
            Factura.RazonSocialEmisor = razonSocial;
            Factura.CUITemisor = cuit;
            Factura.DomicilioComercialEmisor = domicilio;
            Factura.CondicionIVA_Emisor = condicionIVA;
            Factura.FechaInicioActividades = fechaInicio;
            Factura.CUITemisorConGuion = cuitConGuion;
        }

        public void UpdatePuntoVentaData(string puntoVenta, string tipoComprobante, string comprobanteNoLetra, string letraComprobante)
        {
            Factura.PuntoVentas = puntoVenta;
            Factura.TipoComprobante = tipoComprobante;
            Factura.ComprobanteNoLetra = comprobanteNoLetra;
            Factura.LetraComprobante = letraComprobante;
        }

        public void UpdateEmisionData(DateTime fechaEmision, string conceptos)
        {
            Factura.FechaEmision = fechaEmision;
            Factura.ConceptosIncluir = conceptos;
        }

        public void UpdateReceptorData(string condicionIVA, string cuit, string razonSocial, string domicilio, string email, string condicionesVenta)
        {
            Factura.CondicionIVA = condicionIVA;
            Factura.CUIT = cuit;
            Factura.RazonSocial = razonSocial;
            Factura.DomicilioComercial = domicilio;
            Factura.Email = email;
            Factura.CondicionesVenta = condicionesVenta;
        }

        public void UpdateOperacionData(string impOtrosTributos, string impNetoGravado, string iva27, string iva21, string iva10, string iva5, string iva2, string iva0, string impTotal)
        {
            Factura.ImpOtrosTributos = impOtrosTributos;
            Factura.ImpNetoGravado = impNetoGravado;
            Factura.IVA27 = iva27;
            Factura.IVA21 = iva21;
            Factura.IVA10 = iva10;
            Factura.IVA5 = iva5;
            Factura.IVA2 = iva2;
            Factura.IVA0 = iva0;
            Factura.ImpTotal = impTotal;
        }

        public void UpdateRenglon(int index, RenglonModel renglon)
        {
            if (index >= 0 && index < Factura.Renglones.Length)
            {
                Factura.Renglones[index] = renglon;
            }
        }
    }
}
