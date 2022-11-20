using Automarket.Domain.Entity;
using Automarket.Domain.Interfeces;
using Automarket.Domain.Response;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Automarket.Service.Interfeces
{
	public interface ICarService
	{
		Task<IBaseResponse<IEnumerable<Car>>> GetAllCars();
	}
}
