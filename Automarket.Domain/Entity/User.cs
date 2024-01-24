using Automarket.Domain.Enam;
using System;

namespace Automarket.Domain.Entity
{
    public class User
    {
        public Guid Id { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public Role Role { get; set; }

        public Profile Profile { get; set; }

        public Guid ProfileId { get; set; }

        public Basket Basket { get; set; }

        public Guid BasketId { get; set; }
    }
}
