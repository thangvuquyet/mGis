using System.Threading.Tasks;
using Abp.Application.Services;
using mGISv3.Authorization.Accounts.Dto;

namespace mGISv3.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
