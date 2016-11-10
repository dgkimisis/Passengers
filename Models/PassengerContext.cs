using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Passengers.Models
{
    public class PassengerContext : DbContext
    {
        public DbSet<Passenger> Passengers { get; set; }
    }
}
