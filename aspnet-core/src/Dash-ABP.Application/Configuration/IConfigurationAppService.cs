using System.Threading.Tasks;
using Dash-ABP.Configuration.Dto;

namespace Dash-ABP.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
