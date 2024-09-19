using Abp.Application.Services;
using Resumification.MultiTenancy.Dto;

namespace Resumification.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

