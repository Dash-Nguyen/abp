using System.Threading.Tasks;
using Abp.Application.Services;
using Dash-ABP.Authorization.Accounts.Dto;

namespace Dash-ABP.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
