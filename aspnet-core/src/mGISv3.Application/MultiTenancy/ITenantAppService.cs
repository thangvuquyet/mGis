using Abp.Application.Services;
using mGISv3.MultiTenancy.Dto;

namespace mGISv3.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

