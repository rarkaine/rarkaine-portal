using Microsoft.Extensions.Configuration;

namespace Rarkaine.Portal.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
