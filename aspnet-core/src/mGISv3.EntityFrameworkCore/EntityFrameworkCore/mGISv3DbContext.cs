using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using mGISv3.Authorization.Roles;
using mGISv3.Authorization.Users;
using mGISv3.MultiTenancy;
using mGISv3.FactHousing;
using System.Reflection;

namespace mGISv3.EntityFrameworkCore
{
    public class mGISv3DbContext : AbpZeroDbContext<Tenant, Role, User, mGISv3DbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<FactHousings> AbpFactHousing {  get; set; }
        
        public mGISv3DbContext(DbContextOptions<mGISv3DbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
