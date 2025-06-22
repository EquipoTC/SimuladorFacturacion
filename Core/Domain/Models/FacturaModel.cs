using SimuladorFacturacion.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Models
{
    public class FacturaModel
    {
        public EmisorModel Emisor { get; set; }
        public ReceptorModel Receptor { get; set; }
        public ComprobanteModel Comprobante { get; set; }
        public List<RenglonModel> Renglones { get; set; }
        public ImporteModel Totales { get; set; }

        public FacturaModel()
        {
            Emisor = new EmisorModel();
            Receptor = new ReceptorModel();
            Comprobante = new ComprobanteModel();
            Renglones = new List<RenglonModel>();
            Totales = new ImporteModel();
        }

        /*public string RazonSocialEmisor { get; set; }
        public string CUITemisor { get; set; }
        public string DomicilioComercialEmisor { get; set; }
        public string CondicionIVA_Emisor { get; set; }
        public DateTime FechaInicioActividades { get; set; }
        public string CUITemisorConGuion { get; set; }
        public string PuntoVenta { get; set; }
        public string TipoComprobante { get; set; }
        public string NumeroComprobante { get; set; }
        public string LetraComprobante { get; set; }
        public DateTime FechaEmision { get; set; }
        public string ConceptosIncluir { get; set; }
        public string CondicionIVA { get; set; }
        public string CUIT { get; set; }
        public string RazonSocial { get; set; }
        public string DomicilioComercial { get; set; }
        public string Email { get; set; }
        public string CondicionesVenta { get; set; }
        public RenglonModel[] Renglones { get; set; }
        public string ImpOtrosTributos { get; set; }
        public string ImpNetoGravado { get; set; }
        public string IVA27 { get; set; }
        public string IVA21 { get; set; }
        public string IVA10 { get; set; }
        public string IVA5 { get; set; }
        public string IVA2 { get; set; }
        public string IVA0 { get; set; }
        public string ImpTotal { get; set; }
        public FacturaModel()
        {
            Renglones = new RenglonModel[3];
            for (int i = 0; i < Renglones.Length; i++)
            {
                Renglones[i] = new RenglonModel();
            }
        }
    }*/
    }
}
