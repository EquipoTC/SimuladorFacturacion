using SimuladorFacturacion.Interfaces;
using SimuladorFacturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Services
{
    public class FacturaBuilder : IFacturaBuilder
    {
        private FacturaModel factura;
        public FacturaBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            factura = new FacturaModel();
        }
        public FacturaModel Build()
        {
            FacturaModel product = this.factura;
            Reset();
            return product;
        }
        public FacturaModel GetProduct()
        {
            return factura;
        }
        public IFacturaBuilder AddEmisor(string razonSocial, string cuit)
        {
            factura.RazonSocialEmisor = razonSocial;
            factura.CUITemisor = cuit;
            return this;
        }

        public IFacturaBuilder AddReceptor(string razonSocial, string cuit)
        {
            factura.RazonSocial = razonSocial;
            factura.CUIT = cuit;
            return this;
        }

        public IFacturaBuilder AddFecha(DateTime fecha)
        {
            factura.FechaEmision = fecha;
            return this;
        }

        public IFacturaBuilder AddTipoComprobante(string tipo)
        {
            factura.TipoComprobante = tipo.ToString();
            return this;
        }

        public IFacturaBuilder AddPuntoVenta(int puntoVenta)
        {
            factura.PuntoVentas = puntoVenta.ToString();
            return this;
        }

        public IFacturaBuilder AddNumeroComprobante(int numero)
        {
            factura.ComprobanteNoLetra = numero.ToString();
            return this;
        }

        public IFacturaBuilder AddRenglon(RenglonModel renglon)
        {
            for (int i = 0; i < factura.Renglones.Length; i++)
            {
                if (factura.Renglones[i] == null)
                {
                    factura.Renglones[i] = renglon;
                    break;
                }
            }
            return this;
        }
    }
}
