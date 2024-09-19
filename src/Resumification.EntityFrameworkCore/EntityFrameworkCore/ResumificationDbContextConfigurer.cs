using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Resumification.EntityFrameworkCore
{
    public static class ResumificationDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ResumificationDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ResumificationDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
