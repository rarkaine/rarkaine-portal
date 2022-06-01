using System.Collections.Generic;
using Abp.Localization;
using Rarkaine.Portal.Install.Dto;

namespace Rarkaine.Portal.Web.Models.Install
{
    public class InstallViewModel
    {
        public List<ApplicationLanguage> Languages { get; set; }

        public AppSettingsJsonDto AppSettingsJson { get; set; }
    }
}
