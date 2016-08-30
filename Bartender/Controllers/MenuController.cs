using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bartender.Views.Menu;

namespace Bartender.Controllers
{

    
    public class MenuController : Controller
    {
        // GET: Menu
        //View has a red line under itself?
        public ActionResult Index()
        {
            return View();
        }
    }

}