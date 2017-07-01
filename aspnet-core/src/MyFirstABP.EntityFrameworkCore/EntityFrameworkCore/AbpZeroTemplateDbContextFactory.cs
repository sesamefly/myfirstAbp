using MyFirstABP.Configuration;
using MyFirstABP.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace MyFirstABP.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MyFirstABPDbContextFactory : IDbContextFactory<MyFirstABPDbContext>
    {
        public MyFirstABPDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<MyFirstABPDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MyFirstABPDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MyFirstABPConsts.ConnectionStringName));
            
            return new MyFirstABPDbContext(builder.Options);
        }
    }
}