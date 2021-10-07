using Microsoft.EntityFrameworkCore;
using Product.Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product.Microservice.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Products> Products { get; set; }
        Task<int> SaveChanges();
    }
}
