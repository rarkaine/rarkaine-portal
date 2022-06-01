using System.Threading.Tasks;

namespace Rarkaine.Portal.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
