using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Dash-ABP.Configuration.Dto;

namespace Dash-ABP.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Dash-ABPAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
