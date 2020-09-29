using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Dash-ABP.Configuration;

namespace Dash-ABP.Web.Host.Startup
{
    [DependsOn(
       typeof(Dash-ABPWebCoreModule))]
    public class Dash-ABPWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public Dash-ABPWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(Dash-ABPWebHostModule).GetAssembly());
        }
    }
}
