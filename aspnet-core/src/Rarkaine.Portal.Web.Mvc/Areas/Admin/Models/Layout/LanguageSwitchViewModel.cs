using System.Collections.Generic;
using Abp.Localization;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Layout
{
    public class LanguageSwitchViewModel
    {
        public IReadOnlyList<LanguageInfo> Languages { get; set; }

        public LanguageInfo CurrentLanguage { get; set; }
        
        public string CssClass { get; set; }
        
        public string IconClass { get; set; }
    }
}
