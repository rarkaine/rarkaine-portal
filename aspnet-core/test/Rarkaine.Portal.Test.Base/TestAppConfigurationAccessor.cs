using Abp.Dependency;
using Abp.Reflection.Extensions;
using Microsoft.Extensions.Configuration;
using Rarkaine.Portal.Configuration;

namespace Rarkaine.Portal.Test.Base
{
    public class TestAppConfigurationAccessor : IAppConfigurationAccessor, ISingletonDependency
    {
        public IConfigurationRoot Configuration { get; }

        public TestAppConfigurationAccessor()
        {
            Configuration = AppConfigurations.Get(
                typeof(PortalTestBaseModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }
    }
}
