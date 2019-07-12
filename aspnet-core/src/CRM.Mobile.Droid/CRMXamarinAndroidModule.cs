using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CRM
{
    [DependsOn(typeof(CRMXamarinSharedModule))]
    public class CRMXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CRMXamarinAndroidModule).GetAssembly());
        }
    }
}