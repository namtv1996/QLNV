using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace CRM.Web.Public.Views
{
    public abstract class CRMRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CRMRazorPage()
        {
            LocalizationSourceName = CRMConsts.LocalizationSourceName;
        }
    }
}
