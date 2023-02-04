using Automarket.Domain.Enam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.Domain.ViewModels.Car
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Brend { get; set; }
        public string Model { get; set; }
        public string Power { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public TypeCar TypeCar { get; set; }
        public List<string> Images { get; set; }
        public DateTime DateCreate { get; set; }
    }
}
