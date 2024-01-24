using System;

namespace Automarket.Domain.Entity
{
    public class Order
    {
        public Guid Id { get; set; }

        public Guid? CarId { get; set; }

        public DateTime DateCreated { get; set; }

        public string Address { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public virtual Basket Basket { get; set; }

        public Guid? BasketId { get; set; }

    }
}
