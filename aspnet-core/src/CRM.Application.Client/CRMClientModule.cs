using Abp.Modules;
using Abp.Reflection.Extensions;

namespace CRM
{
    public class CRMClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CRMClientModule).GetAssembly());
        }
    }
}
