using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace CRM.Web.Controllers
{
    public class HomeController : CRMControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
