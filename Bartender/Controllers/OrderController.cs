using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bartender.Models;

namespace Bartender.Controllers
{
    //This controller houses each method for each step in the order process and other necessary objects
    //Those methods need to add...
    public class OrderController : Controller
    {
        //creates the order list
        List<Drink> _drinkOrderList = new List<Drink>();

        //add order method
        public ActionResult methodAddOrder(Drink drinkToAdd)
        {
            _drinkOrderList.Add(drinkToAdd);
            return RedirectToAction("Ordered");
        }

        //returns Ordered view and passes in the _drinkOrderList
        public ActionResult Ordered()
        {
            return View(_drinkOrderList);
        }

        //creates the Prepared list
        List<Drink> _preparedDrinkList = new List<Drink>();

        //add order method
        public ActionResult methodAddPreparedDrink(Drink addingDrink)
        {
            _preparedDrinkList.Add(addingDrink);
            return RedirectToAction("Ordered");
        }

        //returns Ordered view and passes in the _drinkOrderList
        public ActionResult Prepared()
        {
            return View(_drinkOrderList);
        }


    }
}