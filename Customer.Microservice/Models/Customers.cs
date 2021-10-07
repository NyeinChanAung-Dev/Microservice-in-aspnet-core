using System;
using System.Collections.Generic;

#nullable disable

namespace Customer.Microservice.Models
{
    public partial class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
    }
}
