using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YehudaWebDev.Models;

namespace YehudaWebDev.Data
{
    public class YehudaWebDevContext : DbContext
    {
        public YehudaWebDevContext (DbContextOptions<YehudaWebDevContext> options)
            : base(options)
        {
        }

        public DbSet<YehudaWebDev.Models.Airlines> Airlines { get; set; }

        public DbSet<YehudaWebDev.Models.Airplanes> Airplanes { get; set; }
    }
}
