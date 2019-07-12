using Abp.AspNetCore.Mvc.ViewComponents;

namespace CRM.Web.Public.Views
{
    public abstract class CRMViewComponent : AbpViewComponent
    {
        protected CRMViewComponent()
        {
            LocalizationSourceName = CRMConsts.LocalizationSourceName;
        }
    }
}