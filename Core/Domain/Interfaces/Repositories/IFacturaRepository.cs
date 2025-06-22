using SimuladorFacturacion.Infraestructure.Repositories;
using SimuladorFacturacion.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Interfaces.Services
{
    public interface IFacturaRepository : IRepository<FacturaModel>
    {
        decimal CalculateTotalAmount(FacturaModel facturacion);
        decimal CalculateIVAAmount(FacturaModel facturacion, decimal alicuota);
    }
}