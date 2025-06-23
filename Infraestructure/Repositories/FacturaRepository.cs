using SimuladorFacturacion.Core.Domain.Interfaces.Repositories;
using SimuladorFacturacion.Core.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Infraestructure.Repositories
{
    public class FacturaRepository : IFacturaRepository
    {
        public decimal CalculateTotalAmount(FacturaModel factura)
        {
            if (factura.Renglones == null) return 0;
            decimal total = 0;
            foreach (var ren in factura.Renglones)
            {
                if (ren == null) continue;
                decimal alicuota = ren.AlicuotaIVA / 100;
                total += ren.Cantidad * ren.PrecioUnitario;
            }
            return total;
        }

        public decimal CalculateIVAAmount(FacturaModel factura, decimal alicuota)
        {
            if (factura.Renglones == null) return 0;
            decimal total = 0;
            foreach (var ren in factura.Renglones)
            {
                if (ren == null || ren.AlicuotaIVA != alicuota) continue;
                decimal alicuotaIVA = alicuota / 100;
                total += ren.Cantidad * ren.PrecioUnitario * alicuota;
            }
            return total;
        }

        // TODO: Implementar persistencia
        public async Task<bool> SaveAsync(FacturaModel facturacion)
        {
            throw new NotImplementedException();
        }

        public async Task<FacturaModel> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FacturaModel>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
