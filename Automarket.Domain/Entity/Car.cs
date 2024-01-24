using Automarket.Domain.Enam;
using System;
using System.Collections.Generic;

namespace Automarket.Domain.Entity
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Brend { get; set; }
        public string Model { get; set; }
        public string Generation { get; set; }
        public DateTime DateCreate { get; set; }
        public string Power { get; set; }
        public decimal Price { get; set; }
        public Color Color { get; set; }
        public Guid ColorId { get; set; }
        public ICollection<Image> Images { get; set; }
        public string Img { get; set; }
        public TypeCar TypeCar { get; set; }
        public string Description { get; set; }
    }
}
