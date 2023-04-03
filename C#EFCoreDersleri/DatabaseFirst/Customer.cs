﻿using System;
using System.Collections.Generic;

namespace DatabaseFirst
{
    public partial class Customer
    {
        public Customer()
        {
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();
        }

        public ushort CustomerId { get; set; }
        public byte StoreId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Email { get; set; }
        public ushort AddressId { get; set; }
        public bool? Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LastUpdate { get; set; }

        public virtual Address Address { get; set; } = null!;
        public virtual Store Store { get; set; } = null!;
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
