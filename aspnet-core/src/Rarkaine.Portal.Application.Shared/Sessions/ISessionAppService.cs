using System.Threading.Tasks;
using Abp.Application.Services;
using Rarkaine.Portal.Sessions.Dto;

namespace Rarkaine.Portal.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
