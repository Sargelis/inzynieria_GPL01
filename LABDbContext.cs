using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LAB.Authorization.Roles;
using LAB.Authorization.Users;
using LAB.MultiTenancy;
using LAB.Cars;
using LAB.Games;
using LAB.Shops;

namespace LAB.EntityFrameworkCore
{
    public class LABDbContext : AbpZeroDbContext<Tenant, Role, User, LABDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Car> Cars { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Shop> Shop { get; set; }

        public LABDbContext(DbContextOptions<LABDbContext> options)
            : base(options)
        {
        }
    }
}
