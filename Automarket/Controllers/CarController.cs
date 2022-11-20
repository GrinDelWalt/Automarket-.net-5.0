using Automarket.DAL.Interfeces;
using Automarket.Domain.Enam;
using Automarket.Domain.Entity;
using Automarket.Service.Interfeces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Automarket.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCars()
        {
            var response= await _carService.GetAllCars();


            return View(response.Data);
        }
    }
}
