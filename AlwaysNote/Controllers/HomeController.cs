using System.Web.Mvc;

namespace AlwaysNote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            return View();
        }

        public ActionResult Manifest() {
            Response.ContentType = "text/cache-manifest";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
            return View();
        }
    }
}
