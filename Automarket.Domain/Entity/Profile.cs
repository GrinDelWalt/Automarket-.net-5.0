using System;

namespace Automarket.Domain.Entity
{
    public class Profile
    {
        public Guid Id { get; set; }

        public byte Age { get; set; }

        public string Address { get; set; }

        public User User { get; set; }

        public Guid UserId { get; set; }
    }
}
