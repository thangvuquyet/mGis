using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using mGISv3.Configuration;
using mGISv3.Web;

namespace mGISv3.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class mGISv3DbContextFactory : IDesignTimeDbContextFactory<mGISv3DbContext>
    {
        public mGISv3DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<mGISv3DbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            mGISv3DbContextConfigurer.Configure(builder, configuration.GetConnectionString(mGISv3Consts.ConnectionStringName));

            return new mGISv3DbContext(builder.Options);
        }
    }
}
