using SimuladorFacturacion.Interfaces;
using SimuladorFacturacion.Interfaces.Services;
using SimuladorFacturacion.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Services
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

        public FacturaModel GetCurrentFactura()
        {
            return _builder.GetProduct();
        }

        public decimal GetFacturaTotal()
        {
            return _repository.CalculateTotalAmount(_builder.GetProduct());
        }
        public decimal GetFacturaIVA(decimal alicuota)
        {
            return _repository.CalculateIVAAmount(_builder.GetProduct(), alicuota);
        }
    }
}
