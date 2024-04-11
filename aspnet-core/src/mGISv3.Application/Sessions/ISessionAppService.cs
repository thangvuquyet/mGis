using System.Threading.Tasks;
using Abp.Application.Services;
using mGISv3.Sessions.Dto;

namespace mGISv3.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
