using Automarket.DAL.Interfeces;
using Automarket.Domain.Enam;
using Automarket.Domain.Entity;
using Automarket.Domain.Interfeces;
using Automarket.Domain.Response;
using Automarket.Domain.ViewModels.Car;
using Automarket.Service.Interfeces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Automarket.Service.Implementations
{
    public class CarService : ICarService
    {
        private readonly IBaseRepository<Car> _carRepository;
        private readonly IBaseRepository<Image> _imageRepository;

        public CarService(IBaseRepository<Car> carRepository, IBaseRepository<Image> imageRepositiory)
        {
            _imageRepository = imageRepositiory;
            _carRepository = carRepository;
        }

        public async Task<IBaseResponse<CarViewModel>> GetCar(int id)
        {
            var baseResponse = new BaseResponse<CarViewModel>();
            try
            {
                List<Image> image = _imageRepository.GetAll()
                                                  .Include(x => x.Car)
                                                  .ThenInclude(x => x.Images)
                                                  .Where(x => x.CarId == id).ToList();

                List<string> images = new List<string>();
                foreach (var imageItem in image)
                {
                    images.Add(imageItem.Link);
                }
                Car car = await _carRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                CarViewModel carViewModel = new()
                {
                    Id = car.Id,
                    Brend = car.Brend,
                    Model = car.Model,
                    Power = car.Power,
                    Description = car.Description,
                    Price = car.Price,
                    TypeCar = car.TypeCar,
                    Images = images,
                    DateCreate = car.DateCreate,
                };

                if (car == null)
                {
                    baseResponse.Description = "Объект не найден";
                    baseResponse.StatusCode = StatusCode.ObjectNotFound;
                    return baseResponse;
                }
                baseResponse.Data = carViewModel;
                baseResponse.StatusCode = StatusCode.OK;
                return baseResponse;
            }
            catch (Exception ex)
            {
                baseResponse.Description = $"[GetCar : {ex.Message}]";
                return baseResponse;
            }
        }
        public async Task<IBaseResponse<Car>> GetCarByModel(string model)
        {
            var baseResponse = new BaseResponse<Car>();
            try
            {
                Car car = await _carRepository.GetAll().FirstOrDefaultAsync(x => x.Model == model);
                if (car == null)
                {
                    baseResponse.Description = "Объект не найден";
                    baseResponse.StatusCode = StatusCode.ObjectNotFound;
                    return baseResponse;
                }
                baseResponse.Data = car;
                baseResponse.StatusCode = StatusCode.OK;
                return baseResponse;
            }
            catch (Exception ex)
            {
                baseResponse.Description = $"[GetCar : {ex.Message}]";
                return baseResponse;
            }
        }
        public async Task<IBaseResponse<bool>> DeleteCar(int id)
        {
            var baseResponse = new BaseResponse<bool>();
            try
            {
                Car car = await _carRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                if (car == null)
                {
                    baseResponse.Description = "объект не найден";
                    baseResponse.StatusCode = StatusCode.ObjectNotFound;
                    return baseResponse;
                }
                await _carRepository.Delete(car);
                return baseResponse;
            }
            catch (Exception ex)
            {
                baseResponse.Description = $"[GetCar : {ex.Message}]";
                return baseResponse;
            }
        }
        public async Task<IBaseResponse<CarsViewModel>> CreateCar(CarsViewModel carViewModel)
        {
            var baseResponse = new BaseResponse<CarsViewModel>();
            try
            {
                Car car = new Car()
                {
                    Brend = carViewModel.Brend,
                    Model = carViewModel.Model,
                };
                await _carRepository.Create(car);
                return baseResponse;
            }
            catch (Exception ex)
            {
                baseResponse.Description = $"[GetCar : {ex.Message}]";
                return baseResponse;
            }
        }

        public async Task<IBaseResponse<IEnumerable<Car>>> GetAllCars()
        {
            var baseResponse = new BaseResponse<IEnumerable<Car>>();
            try
            {
                var cars = await _carRepository.GetAll().ToListAsync();
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
            }
        }

        public async Task<IBaseResponse<Car>> Edit(int id, CarsViewModel model)
        {
            var baseResponse = new BaseResponse<Car>();
            try
            {
                var car = await _carRepository.GetAll().FirstOrDefaultAsync(x => x.Id == id);
                if (car == null)
                {
                    baseResponse.Description = "Найдено 0 элементов";
                    baseResponse.StatusCode = StatusCode.ObjectNotFound;
                    return baseResponse;
                }
                car.Brend = model.Brend;
                car.Model = model.Model;

                await _carRepository.Update(car);

                return baseResponse;
            }
            catch (Exception ex)
            {
                return new BaseResponse<Car>()
                {
                    Description = $"[GetAllCars] : {ex.Message}"
                };
            }
        }
    }
}
