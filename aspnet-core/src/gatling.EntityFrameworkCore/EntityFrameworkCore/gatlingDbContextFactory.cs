using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using gatling.Configuration;
using gatling.Web;

namespace gatling.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class gatlingDbContextFactory : IDesignTimeDbContextFactory<gatlingDbContext>
    {
        public gatlingDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<gatlingDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            gatlingDbContextConfigurer.Configure(builder, configuration.GetConnectionString(gatlingConsts.ConnectionStringName));

            return new gatlingDbContext(builder.Options);
        }
    }
}
