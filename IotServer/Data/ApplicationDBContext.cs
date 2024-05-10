using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IotServer.Models;
using Microsoft.EntityFrameworkCore;

namespace IotServer.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) 
        : base(dbContextOptions)
        {
            
        }
        public DbSet<Sensor> Sensors { get; set; }
        public DbSet<AirConditioner> AirConditioners { get; set; }
    }
}