using SimuladorFacturacion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Interfaces
{
    public interface IFacturacionService
    {
        FacturaModel Factura { get; }
        void UpdateFacturacion(FacturaModel facturacion);
        void ResetFacturacion();
    }
}
