using Automarket.Domain.Entity;
using System.Threading.Tasks;

namespace Automarket.DAL.Interfeces
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        Task<Car> GetByModelAsync(string model);
    }
}
