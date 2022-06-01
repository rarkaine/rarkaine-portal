using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Rarkaine.Portal.Configuration.Host.Dto;
using Rarkaine.Portal.Editions.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }

        public List<string> EnabledSocialLoginSettings { get; set; } = new List<string>();
    }
}