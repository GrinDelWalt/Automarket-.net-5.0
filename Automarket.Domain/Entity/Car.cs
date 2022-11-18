using Automarket.Domain.Enam;
using System;

namespace Automarket.Domain.Entity
{
    public class Car
    {
        public int Id { get; set; }
        public string Brend { get; set; }
        public string Model { get; set; }
        public string Generation { get; set; }
        public DateTime DareCreate { get; set; }
        public string Power { get; set; }
        public string Calour { get; set; }
        public int Price { get; set; }
        //public string Img { get; set; }
        public TypeCar TypeCar { get; set; }
    }
}
