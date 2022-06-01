using Abp.Auditing;
using Rarkaine.Portal.Configuration.Dto;

namespace Rarkaine.Portal.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}