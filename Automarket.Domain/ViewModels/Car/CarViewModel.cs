﻿using Automarket.Domain.Enam;

namespace Automarket.Domain.ViewModels.Car
{
    public class CarViewModel
    {
        public int Id { get; set; }
        public string Brend { get; set; }
        public string Model { get; set; }
        public int Power { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public TypeCar TypeCar { get; set; }
    }
}
