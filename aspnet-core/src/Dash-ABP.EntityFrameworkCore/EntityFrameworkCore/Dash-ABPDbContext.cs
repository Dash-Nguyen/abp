using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Dash-ABP.Authorization.Roles;
using Dash-ABP.Authorization.Users;
using Dash-ABP.MultiTenancy;

namespace Dash-ABP.EntityFrameworkCore
{
    public class Dash-ABPDbContext : AbpZeroDbContext<Tenant, Role, User, Dash-ABPDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public Dash-ABPDbContext(DbContextOptions<Dash-ABPDbContext> options)
            : base(options)
        {
        }
    }
}
