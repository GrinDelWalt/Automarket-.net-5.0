using Automarket.Domain.Entity;

namespace Automarket.DAL.Interfeces
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        Car GetByModel(string model);
    }
}
