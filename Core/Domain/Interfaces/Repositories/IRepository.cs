using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Infraestructure.Repositories
{
    public interface IRepository<T>
    {
        Task<T> GetAllAsync();
        Task<T> GetByIdAsync();
        Task<T> SaveAsync();
        Task<bool> DeleteAsync(int id);
    }
}
