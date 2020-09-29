using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Dash-ABP.Configuration;
using Dash-ABP.Web;

namespace Dash-ABP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class Dash-ABPDbContextFactory : IDesignTimeDbContextFactory<Dash-ABPDbContext>
    {
        public Dash-ABPDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Dash-ABPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            Dash-ABPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(Dash-ABPConsts.ConnectionStringName));

            return new Dash-ABPDbContext(builder.Options);
        }
    }
}
