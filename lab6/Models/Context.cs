using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab6.Models
{
    public class Context : DbContext
    {
        public Context() : base("name=BankContext") { }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}