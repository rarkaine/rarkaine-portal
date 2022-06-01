using Abp.AutoMapper;
using Rarkaine.Portal.Authorization.Roles.Dto;
using Rarkaine.Portal.Web.Areas.Admin.Models.Common;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class CreateOrEditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool IsEditMode => Role.Id.HasValue;
    }
}