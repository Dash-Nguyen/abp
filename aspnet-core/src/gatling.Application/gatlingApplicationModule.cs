using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using gatling.Authorization;

namespace gatling
{
    [DependsOn(
        typeof(gatlingCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class gatlingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<gatlingAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(gatlingApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
