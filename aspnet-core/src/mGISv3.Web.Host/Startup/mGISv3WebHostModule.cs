using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using mGISv3.Configuration;

namespace mGISv3.Web.Host.Startup
{
    [DependsOn(
       typeof(mGISv3WebCoreModule))]
    public class mGISv3WebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public mGISv3WebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(mGISv3WebHostModule).GetAssembly());
        }
    }
}
