using System.Threading.Tasks;
using Abp.Application.Services;
using Rarkaine.Portal.Install.Dto;

namespace Rarkaine.Portal.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}