using Microsoft.AspNetCore.Mvc;
using CRM.Web.Controllers;

namespace CRM.Web.Public.Controllers
{
    public class HomeController : CRMControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}