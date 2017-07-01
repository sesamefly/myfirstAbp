using Microsoft.EntityFrameworkCore;

namespace MyFirstABP.EntityFrameworkCore
{
    public static class MyFirstABPDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyFirstABPDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }
    }
}