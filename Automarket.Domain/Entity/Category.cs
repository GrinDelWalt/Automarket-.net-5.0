using System.Collections.Generic;

namespace Automarket.Domain.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string RequestId { get; set; }
        public string NameCategori { get; set; }
        public string Desc { get; set; }
        public List<Car> Cars { get; set; }
    }
}
