using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Airline.ModelClass;

namespace Airline.Data
{
    public class AirlineContext : DbContext
    {
        public AirlineContext (DbContextOptions<AirlineContext> options)
            : base(options)
        {
        }

        public DbSet<Airline.ModelClass.Customer> Customer { get; set; }

        public DbSet<Airline.ModelClass.Parking> Parking { get; set; }

        public DbSet<Airline.ModelClass.Payment> Payment { get; set; }
    }
}
