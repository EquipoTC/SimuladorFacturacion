using SimuladorFacturacion.Infraestructure.Repositories;
using SimuladorFacturacion.Models;
namespace SimuladorFacturacion.Interfaces.Services
{
    public interface IFacturaRepository : IRepository<FacturaModel>
    {
        decimal CalculateTotalAmount(FacturaModel facturacion);
        decimal CalculateIVAAmount(FacturaModel facturacion, decimal alicuota);
    }
}