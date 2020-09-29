using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using gatling.Authorization.Roles;
using gatling.Authorization.Users;
using gatling.MultiTenancy;

namespace gatling.EntityFrameworkCore
{
    public class gatlingDbContext : AbpZeroDbContext<Tenant, Role, User, gatlingDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public gatlingDbContext(DbContextOptions<gatlingDbContext> options)
            : base(options)
        {
        }
    }
}
