using Automarket.Domain.Enam;

namespace Automarket.Domain.Entity
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
    }
}
