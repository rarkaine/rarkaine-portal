using Abp.AutoMapper;
using Rarkaine.Portal.MultiTenancy;
using Rarkaine.Portal.MultiTenancy.Dto;
using Rarkaine.Portal.Web.Areas.Admin.Models.Common;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}