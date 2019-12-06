using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace lab6.Models
{
    public class Context : DbContext
    {
        public Context() : base("name=MatchContext") { }

        public DbSet<Match> Matches { get; set; }
        public DbSet<Stadium> Stadiums { get; set; }
    }
}