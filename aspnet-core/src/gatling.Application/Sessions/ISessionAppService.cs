using System.Threading.Tasks;
using Abp.Application.Services;
using gatling.Sessions.Dto;

namespace gatling.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
