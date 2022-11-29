using Automarket.Domain.Entity;
using Automarket.Domain.Interfeces;
using Automarket.Domain.Response;
using Automarket.Domain.ViewModels.Car;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Automarket.Service.Interfeces
{
	public interface ICarService
	{
		Task<IBaseResponse<IEnumerable<Car>>> GetAllCars();

		Task<IBaseResponse<Car>> GetCar(int id);

		Task<IBaseResponse<Car>> GetCarByModel(string model);
		Task<IBaseResponse<bool>> DeleteCar(int id);
		Task<IBaseResponse<CarViewModel>> CreateCar(CarViewModel carViewModel);
		Task<IBaseResponse<Car>> Edit(int id, CarViewModel model);

    }
}
