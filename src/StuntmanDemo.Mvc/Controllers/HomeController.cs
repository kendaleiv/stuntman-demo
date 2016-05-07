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
            if (User.Identity.IsAuthenticated == true)
            {
                return View();
            }
            else
            {
                return new HttpUnauthorizedResult();
            }
        }
    }
}
