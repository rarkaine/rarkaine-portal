using Abp.AutoMapper;
using Rarkaine.Portal.MultiTenancy.Dto;

namespace Rarkaine.Portal.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
