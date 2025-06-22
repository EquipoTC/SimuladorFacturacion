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
        FacturacionModel Factura { get; }
        void UpdateFacturacion(FacturacionModel facturacion);
        void ResetFacturacion();
    }
}
