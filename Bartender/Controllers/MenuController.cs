﻿using System.Web.Mvc;

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