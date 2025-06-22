using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Core.Domain.Models
{
    public class ImporteModel
    {
        public decimal OtrosTributos { get; set; }
        public decimal NetoGravado { get; set; }
        public decimal IVA27 { get; set; }
        public decimal IVA21 { get; set; }
        public decimal IVA10 { get; set; }
        public decimal IVA5 { get; set; }
        public decimal IVA2 { get; set; }
        public decimal IVA0 { get; set; }
        public decimal GetTotalIVA() => IVA27 + IVA21 + IVA10 + IVA5 + IVA2 + IVA0;
        public decimal GetImporteTotal() => NetoGravado + GetTotalIVA() + OtrosTributos;
    }
}
