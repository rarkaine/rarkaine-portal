using Abp.AspNetZeroCore;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using Rarkaine.Portal.Configuration;
using Rarkaine.Portal.EntityFrameworkCore;
using Rarkaine.Portal.Migrator.DependencyInjection;

namespace Rarkaine.Portal.Migrator
{
    [DependsOn(typeof(PortalEntityFrameworkCoreModule))]
    public class PortalMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PortalMigratorModule(PortalEntityFrameworkCoreModule portalEntityFrameworkCoreModule)
        {
            portalEntityFrameworkCoreModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(PortalMigratorModule).GetAssembly().GetDirectoryPathOrNull(),
                addUserSecrets: true
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PortalConsts.ConnectionStringName
                );
            Configuration.Modules.AspNetZero().LicenseCode = _appConfiguration["AbpZeroLicenseCode"];

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PortalMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}