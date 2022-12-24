namespace Automarket.Domain.Entity
{
    public class Color
    {
        public int Id { get; set; }
        public string ColorCar { get; set; }
        public string Code { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
    }
}
