﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using gatling.Configuration;

namespace gatling.Web.Host.Startup
{
    [DependsOn(
       typeof(gatlingWebCoreModule))]
    public class gatlingWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public gatlingWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(gatlingWebHostModule).GetAssembly());
        }
    }
}
