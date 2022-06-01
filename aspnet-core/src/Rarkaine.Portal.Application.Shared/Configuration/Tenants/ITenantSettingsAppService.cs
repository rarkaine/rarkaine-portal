using System.Threading.Tasks;
using Abp.Application.Services;
using Rarkaine.Portal.Configuration.Tenants.Dto;

namespace Rarkaine.Portal.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
