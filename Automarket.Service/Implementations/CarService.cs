using Automarket.DAL.Interfeces;
using Automarket.Domain.Enam;
using Automarket.Domain.Entity;
using Automarket.Domain.Interfeces;
using Automarket.Domain.Response;
using Automarket.Service.Interfeces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Automarket.Service.Implementations
{
	public class CarService : ICarService
	{
		private readonly ICarRepository _carRepository;

		public CarService(ICarRepository carRepository)
		{
			_carRepository = carRepository;
		}

		public async Task<IBaseResponse<IEnumerable<Car>>> GetAllCars()
		{
			var baseResponse = new BaseResponse<IEnumerable<Car>>();
			try
			{
				var cars = await _carRepository.Select();
				if (cars.Count == 0)
				{
					baseResponse.Description = "Найдено 0 элементов";
					baseResponse.StatusCode = StatusCode.OK;
					return baseResponse;
				}
				baseResponse.Data = cars;
                baseResponse.StatusCode = StatusCode.OK;
                return baseResponse;
			}
			catch (Exception ex)
			{
				return new BaseResponse<IEnumerable<Car>>()
				{
					Description = $"[GetAllCars] : {ex.Message}"
				};
				throw;
			}
		}
	}
}
