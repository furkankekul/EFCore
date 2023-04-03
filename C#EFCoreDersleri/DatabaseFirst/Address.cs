﻿using System;
using System.Collections.Generic;

namespace DatabaseFirst
{
    public partial class Address
    {
        public Address()
        {
            Customers = new HashSet<Customer>();
            Stores = new HashSet<Store>();
            staff = new HashSet<staff>();
        }

        public ushort AddressId { get; set; }
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string District { get; set; } = null!;
        public ushort CityId { get; set; }
        public string? PostalCode { get; set; }
        public string Phone { get; set; } = null!;
        public DateTime LastUpdate { get; set; }

        public virtual City City { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
        public virtual ICollection<staff> staff { get; set; }
    }
}
