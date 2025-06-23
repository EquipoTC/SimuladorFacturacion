using SimuladorFacturacion.Core.Domain.Models;

namespace SimuladorFacturacion.Core.Domain.Interfaces.Repositories
{
    public interface IFacturaRepository : IRepository<FacturaModel>
    {
        decimal CalculateTotalAmount(FacturaModel facturacion);
        decimal CalculateIVAAmount(FacturaModel facturacion, decimal alicuota);
    }
}