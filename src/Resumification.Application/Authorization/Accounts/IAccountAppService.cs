using System.Threading.Tasks;
using Abp.Application.Services;
using Resumification.Authorization.Accounts.Dto;

namespace Resumification.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
