using System;

namespace Automarket.Domain.Entity
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Link { get; set; }
        public Car Car { get; set; }
        public Guid CarId { get; set; }
    }
}
