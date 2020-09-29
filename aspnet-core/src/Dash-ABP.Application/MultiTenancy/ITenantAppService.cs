using Abp.Application.Services;
using Dash-ABP.MultiTenancy.Dto;

namespace Dash-ABP.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

