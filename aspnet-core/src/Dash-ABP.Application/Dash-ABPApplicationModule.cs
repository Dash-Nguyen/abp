using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dash-ABP.Authorization;

namespace Dash-ABP
{
    [DependsOn(
        typeof(Dash-ABPCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class Dash-ABPApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<Dash-ABPAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(Dash-ABPApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
