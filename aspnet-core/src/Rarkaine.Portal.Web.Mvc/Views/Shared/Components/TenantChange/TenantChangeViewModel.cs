using Abp.AutoMapper;
using Rarkaine.Portal.Sessions.Dto;

namespace Rarkaine.Portal.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}