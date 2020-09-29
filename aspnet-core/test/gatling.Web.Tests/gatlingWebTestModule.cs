using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using gatling.EntityFrameworkCore;
using gatling.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace gatling.Web.Tests
{
    [DependsOn(
        typeof(gatlingWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class gatlingWebTestModule : AbpModule
    {
        public gatlingWebTestModule(gatlingEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(gatlingWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(gatlingWebMvcModule).Assembly);
        }
    }
}