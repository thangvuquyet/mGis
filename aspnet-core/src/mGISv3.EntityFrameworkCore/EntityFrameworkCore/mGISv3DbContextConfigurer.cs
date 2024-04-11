using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace mGISv3.EntityFrameworkCore
{
    public static class mGISv3DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<mGISv3DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<mGISv3DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
