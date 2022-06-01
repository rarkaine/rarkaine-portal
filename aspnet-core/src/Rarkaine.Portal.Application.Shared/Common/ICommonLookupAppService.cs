using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Rarkaine.Portal.Common.Dto;
using Rarkaine.Portal.Editions.Dto;

namespace Rarkaine.Portal.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}