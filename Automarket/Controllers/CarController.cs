using Automarket.DAL.Interfeces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Automarket.Controllers
{
    public class CarController
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var response = await _carRepository.Select();
            return View(response);
        }
    }
}
