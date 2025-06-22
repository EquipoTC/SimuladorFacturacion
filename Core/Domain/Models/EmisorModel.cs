using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Core.Domain.Models
{
    public class EmisorModel : PersonaModel
    {
        public DateTime FechaInicioActividades { get; set; }
    }
}
