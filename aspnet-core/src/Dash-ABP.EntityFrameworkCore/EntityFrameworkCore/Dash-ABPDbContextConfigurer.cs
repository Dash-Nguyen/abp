using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Dash-ABP.EntityFrameworkCore
{
    public static class Dash-ABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<Dash-ABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<Dash-ABPDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
