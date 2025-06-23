using SimuladorFacturacion.Core.Domain.Interfaces.Builders;
using SimuladorFacturacion.Core.Domain.Interfaces.Repositories;
using SimuladorFacturacion.Core.Domain.Models;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Core.Application.Services
{
    public class FacturacionService
    {
        private readonly IFacturaRepository _repository;
        private readonly IFacturaBuilder _builder;

        public FacturacionService(IFacturaRepository repository, IFacturaBuilder builder)
        {
            this._builder = builder;
            this._repository = repository;
        }
        public IFacturaBuilder GetBuilder()
        {
            return _builder;
        }
        public IFacturaBuilder CreateNewFactura()
        {
            _builder.Reset();
            return _builder;
        }

        public async Task<bool> SaveCurrentFacturaAsync()
        {
            return await _repository.SaveAsync(_builder.Build());
        }

        public FacturaModel GetFactura()
        {
            return _builder.GetProduct();
        }

        public FacturaModel FinishFactura()
        {
            return _builder.Build();
        }

        public decimal GetFacturaTotal()
        {
            return _repository.CalculateTotalAmount(_builder.Build());
        }
        public decimal GetFacturaIVA(decimal alicuota)
        {
            return _repository.CalculateIVAAmount(_builder.Build(), alicuota);
        }
    }
}
