using DotNetCoreMVC_TaxCalculation.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DotNetCoreMVC_TaxCalculation.DBContext
{
   
        public class MyDBContext : DbContext
        {

        
            public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }

            public DbSet<Employee> Employees { get; set; }
        }

    }

