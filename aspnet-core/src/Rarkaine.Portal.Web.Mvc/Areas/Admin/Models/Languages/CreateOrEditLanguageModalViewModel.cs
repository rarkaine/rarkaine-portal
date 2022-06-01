using Abp.AutoMapper;
using Rarkaine.Portal.Localization.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}