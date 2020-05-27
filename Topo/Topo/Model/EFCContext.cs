using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Topo.Model
{
    public class EFCContext : IdentityDbContext
    {
        public DbSet<Region> Regions { get; set; }
        public DbSet<Rock> Rocks { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Image> Images { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public EFCContext(DbContextOptions<EFCContext> options): base(options)
        { }
    }
}
