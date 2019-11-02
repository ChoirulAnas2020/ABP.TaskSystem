using Microsoft.AspNetCore.Mvc;

namespace ABP.TaskSystem.Web.Controllers
{
    public class HomeController : TaskSystemControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}