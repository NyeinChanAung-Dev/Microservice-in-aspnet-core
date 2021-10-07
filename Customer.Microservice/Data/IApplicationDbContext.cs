using Microsoft.EntityFrameworkCore;
using Customer.Microservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Customer.Microservice.Data
{
    public interface IApplicationDbContext
    {
        DbSet<Customers> Customers { get; set; }
        Task<int> SaveChanges();
    }
}
