using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Rarkaine.Portal.Authorization.Users.Dto;

namespace Rarkaine.Portal.Authorization.Users
{
    public interface IUserLinkAppService : IApplicationService
    {
        Task LinkToUser(LinkToUserInput linkToUserInput);

        Task<PagedResultDto<LinkedUserDto>> GetLinkedUsers(GetLinkedUsersInput input);

        Task<ListResultDto<LinkedUserDto>> GetRecentlyUsedLinkedUsers();

        Task UnlinkUser(UnlinkUserInput input);
    }
}
