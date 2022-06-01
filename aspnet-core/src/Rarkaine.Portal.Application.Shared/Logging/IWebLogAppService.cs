using Abp.Application.Services;
using Rarkaine.Portal.Dto;
using Rarkaine.Portal.Logging.Dto;

namespace Rarkaine.Portal.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
