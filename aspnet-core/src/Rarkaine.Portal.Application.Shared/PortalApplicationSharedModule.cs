using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Rarkaine.Portal
{
    [DependsOn(typeof(PortalCoreSharedModule))]
    public class PortalApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PortalApplicationSharedModule).GetAssembly());
        }
    }
}