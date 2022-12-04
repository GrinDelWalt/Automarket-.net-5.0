using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.Domain.Entity
{
    public class Color
    {
        public int Id { get; set; }
        public string ColorCar { get; set; }
        public string Code { get; set; }
        public Car Car { get; set; }
    }
}
