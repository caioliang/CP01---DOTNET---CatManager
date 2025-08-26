using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICatService
    {
        Task<IEnumerable<Cat>> GetAllAsync();
        Task<Cat> GetByIdAsync(int id);
        Task<Cat> CreateAsync(Cat cat);
        Task UpdateAsync(Cat cat);
        Task DeleteAsync(int id);
    }
}
