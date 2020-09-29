using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using gatling.Configuration.Dto;

namespace gatling.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : gatlingAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
