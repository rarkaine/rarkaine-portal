using System.Threading.Tasks;
using Abp.Application.Services;
using Rarkaine.Portal.Editions.Dto;
using Rarkaine.Portal.MultiTenancy.Dto;

namespace Rarkaine.Portal.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}