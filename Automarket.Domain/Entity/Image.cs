namespace Automarket.Domain.Entity
{
    public class Image
    {
        public int Id { get; set; }
        public string Link { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
    }
}
