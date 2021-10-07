using System;
using System.Collections.Generic;

#nullable disable

namespace Product.Microservice.Models
{
    public partial class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Rate { get; set; }
    }
}
