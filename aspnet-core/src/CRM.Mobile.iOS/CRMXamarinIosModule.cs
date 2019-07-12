using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CRM
{
    [DependsOn(typeof(CRMXamarinSharedModule))]
    public class CRMXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CRMXamarinIosModule).GetAssembly());
        }
    }
}