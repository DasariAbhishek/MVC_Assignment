using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FootBallLeagueMVC.Models
{
    public class FootBallLeagueDBContext : DbContext
    {
        public FootBallLeagueDBContext() : base("name = FootBallLeagueDBContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FootBallLeague>().MapToStoredProcedures();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FootBallLeague> leagues { get; set; }
    }
}