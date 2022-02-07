using AtmBanking.Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AtmBanking.DAL.Data
{
    public class AtmDbContext:DbContext
    {
        public AtmDbContext(DbContextOptions<AtmDbContext> options) : base(options)
        {

        }
        public DbSet<CustomerInfo> customerInfo { get; set; }
        public DbSet<Customer> customer { get; set; }

    }
}
