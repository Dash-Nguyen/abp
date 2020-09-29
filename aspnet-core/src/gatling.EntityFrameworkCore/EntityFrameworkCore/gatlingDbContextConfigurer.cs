using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace gatling.EntityFrameworkCore
{
    public static class gatlingDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<gatlingDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<gatlingDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
