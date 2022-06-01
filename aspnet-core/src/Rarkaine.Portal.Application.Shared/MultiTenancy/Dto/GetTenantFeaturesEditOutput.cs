using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Rarkaine.Portal.Editions.Dto;

namespace Rarkaine.Portal.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}