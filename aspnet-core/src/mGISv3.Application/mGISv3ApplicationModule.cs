using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using mGISv3.Authorization;

namespace mGISv3
{
    [DependsOn(
        typeof(mGISv3CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class mGISv3ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<mGISv3AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(mGISv3ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
