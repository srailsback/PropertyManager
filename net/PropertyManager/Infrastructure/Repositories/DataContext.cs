using PropertyManager.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PropertyManager.Infrastructure.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DatabaseConnectionString") { }

        public DbSet<Parcel> Parcels { get; set; }
    }
}