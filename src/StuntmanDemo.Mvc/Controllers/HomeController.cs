using System.Web.Mvc;

namespace StuntmanDemo.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Secure()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return new HttpUnauthorizedResult();
            }

            return View();
        }

        public ActionResult ApiEndpoint()
        {
            if (!User.Identity.IsAuthenticated || !User.IsInRole("Administrator"))
            {
                return new HttpUnauthorizedResult();
            }

            return Json(new { Data = "some_data" }, JsonRequestBehavior.AllowGet);
        }
    }
}
