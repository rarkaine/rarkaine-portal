using System.Collections.Generic;
using Rarkaine.Portal.DynamicEntityProperties.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.DynamicEntityProperty
{
    public class CreateEntityDynamicPropertyViewModel
    {
        public string EntityFullName { get; set; }

        public List<string> AllEntities { get; set; }

        public List<DynamicPropertyDto> DynamicProperties { get; set; }
    }
}
