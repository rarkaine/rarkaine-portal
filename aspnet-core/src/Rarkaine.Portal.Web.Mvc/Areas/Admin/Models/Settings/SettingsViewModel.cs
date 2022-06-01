using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Rarkaine.Portal.Configuration.Tenants.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
        
        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}