using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Rarkaine.Portal.Authorization.Permissions.Dto;

namespace Rarkaine.Portal.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
