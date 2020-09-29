using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace gatling.Controllers
{
    public abstract class gatlingControllerBase: AbpController
    {
        protected gatlingControllerBase()
        {
            LocalizationSourceName = gatlingConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
