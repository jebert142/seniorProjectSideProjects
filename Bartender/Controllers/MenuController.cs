using System.Web.Mvc;

namespace Bartender.Controllers
{

    //MenuController contains all the methods which return the views
    public class MenuController : Controller
    {
        // GET: Menu
        //Views have a red line under them?

        //returns the Index.cshtml view
        public ActionResult Index()
        {
            return View();
        }

        //returns the Order.cshtml view
        public ActionResult Orders()
        {
            return View();
        }

        //returns the Prepared.cshtml view
        public ActionResult Prepared()
        {
            return View();
        }
    }

}