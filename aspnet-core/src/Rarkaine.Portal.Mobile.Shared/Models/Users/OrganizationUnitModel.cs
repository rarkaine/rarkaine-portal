using Abp.AutoMapper;
using Rarkaine.Portal.Organizations.Dto;

namespace Rarkaine.Portal.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}