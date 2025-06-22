using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Core.Domain.Models
{
    public class ComprobanteModel
    {
        public int PuntoVenta { get; set; }
        public string TipoComprobante { get; set; }
        public int NumeroComprobante { get; set; }
        public string LetraComprobante { get; set; }
        public DateTime FechaEmision { get; set; }
        public string ConceptosIncluir { get; set; }
        public string CondicionesVenta { get; set; }
    }
}
