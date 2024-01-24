using System;
using System.Collections.Generic;

namespace Automarket.Domain.Entity
{
    public class Basket
    {
        public Guid Id { get; set; }

        public User User { get; set; }

        public Guid UserId { get; set; }

        public List<Order> Orders { get; set; }
    }
}
