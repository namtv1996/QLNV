using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CRM
{
    [DependsOn(typeof(CRMClientModule), typeof(AbpAutoMapperModule))]
    public class CRMXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CRMXamarinSharedModule).GetAssembly());
        }
    }
}