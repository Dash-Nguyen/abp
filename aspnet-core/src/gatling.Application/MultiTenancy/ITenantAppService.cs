using Abp.Application.Services;
using gatling.MultiTenancy.Dto;

namespace gatling.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

