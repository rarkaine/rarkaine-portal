using System.Collections.Generic;
using Rarkaine.Portal.Caching.Dto;

namespace Rarkaine.Portal.Web.Areas.Admin.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}