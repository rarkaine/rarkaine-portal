using System.Collections.Generic;
using Rarkaine.Portal.DynamicEntityProperties.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
