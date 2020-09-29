using System.Threading.Tasks;
using gatling.Configuration.Dto;

namespace gatling.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
