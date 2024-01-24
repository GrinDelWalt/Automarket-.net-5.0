using System;
using System.Collections.Generic;

namespace Automarket.Domain.Entity
{
    public class Color
    {
        public Guid Id { get; set; }
        public string ColorCar { get; set; }
        public string Code { get; set; }
        public List<Car> Car { get; set; }
    }
}
