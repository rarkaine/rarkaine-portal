using Abp.Configuration;

namespace Rarkaine.Portal.Timing.Dto
{
    public class GetTimezonesInput
    {
        public SettingScopes DefaultTimezoneScope { get; set; }
    }
}
