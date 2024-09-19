using System.Threading.Tasks;
using Abp.Application.Services;
using Resumification.Sessions.Dto;

namespace Resumification.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
