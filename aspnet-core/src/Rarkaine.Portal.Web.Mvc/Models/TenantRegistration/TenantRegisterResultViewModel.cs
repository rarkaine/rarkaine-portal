using Abp.AutoMapper;
using Rarkaine.Portal.MultiTenancy.Dto;

namespace Rarkaine.Portal.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}