using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CabManagement.Models;

namespace CabManagement.Data
{
    public class CabManagementContext : DbContext
    {
        public CabManagementContext (DbContextOptions<CabManagementContext> options)
            : base(options)
        {
        }

        public DbSet<CabManagement.Models.Bill> Bill { get; set; }

        public DbSet<CabManagement.Models.Booking> Booking { get; set; }

        public DbSet<CabManagement.Models.Cab> Cab { get; set; }

        public DbSet<CabManagement.Models.Route> Route { get; set; }
    }
}
