using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Rarkaine.Portal.Editions.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}