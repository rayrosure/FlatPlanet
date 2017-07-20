using FlatPlanet.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatPlanet.Data.Context
{
    public class FlatPlanetContext : DbContext
    {
        public FlatPlanetContext(): base("FlatPlanetContext") {

            Database.SetInitializer<FlatPlanetContext>(new CreateDatabaseIfNotExists<FlatPlanetContext>());
        }

        public DbSet<Counter> Counter { get; set; }
    }
}
