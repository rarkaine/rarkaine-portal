using Abp.AspNetCore.Mvc.Authorization;
using Rarkaine.Portal.Authorization;
using Rarkaine.Portal.Storage;
using Abp.BackgroundJobs;

namespace Rarkaine.Portal.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}