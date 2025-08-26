using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICatFactService
    {
        Task<string> GetRandomFactAsync();
    }
}
