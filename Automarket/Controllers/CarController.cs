using Automarket.DAL.Interfeces;
using Automarket.Domain.Enam;
using Automarket.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Automarket.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            //var response = await _carRepository.Select();
            //var response2 = await _carRepository.GetByModelAsync("3");
            //var response3 = await _carRepository.Get(2);
            //Car car = new Car()
            //{
            //    Brend = "BMW",
            //    Model = "X5M",
            //    Generation = "F90",
            //    Calour = "blue",
            //    Price = 6000000,
            //    Power = "340",
            //};
            //await _carRepository.Create(car);
            //var response4 = await _carRepository.Select();

            //await _carRepository.Delete(car);
            //var response5 = await _carRepository.Select();


            return View();
        }
    }
}
