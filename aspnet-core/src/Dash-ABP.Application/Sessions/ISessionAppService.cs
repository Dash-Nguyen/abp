using System.Threading.Tasks;
using Abp.Application.Services;
using Dash-ABP.Sessions.Dto;

namespace Dash-ABP.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
