using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimuladorFacturacion.Core.Domain.Interfaces.Repositories
{
    public interface IRepository<T>
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<bool> SaveAsync(T model);
        Task<bool> DeleteAsync(int id);
    }
}
