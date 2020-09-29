using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Dash-ABP.Controllers
{
    public abstract class Dash-ABPControllerBase: AbpController
    {
        protected Dash-ABPControllerBase()
        {
            LocalizationSourceName = Dash-ABPConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
