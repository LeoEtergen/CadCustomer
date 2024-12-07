
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CadCustomer.Models;

namespace CadCustomer.Data
{
    public class CadCustomerContext : DbContext
    {
        public CadCustomerContext(DbContextOptions<CadCustomerContext> options)
            : base(options)
        {
        }

        public DbSet<CadCustomer.Models.Customer> Customer { get; set; } = default!;
    }
}
