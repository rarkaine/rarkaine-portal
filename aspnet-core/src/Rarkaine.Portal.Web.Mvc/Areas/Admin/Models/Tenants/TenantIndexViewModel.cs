using System.Collections.Generic;
using Rarkaine.Portal.Editions.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}