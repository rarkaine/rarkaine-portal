using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Rarkaine.Portal
{
    public class PortalCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PortalCoreSharedModule).GetAssembly());
        }
    }
}