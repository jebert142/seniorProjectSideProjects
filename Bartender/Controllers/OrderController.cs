using System;
using System.Collections.Generic;
using System.EnterpriseServices;
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

        private static int id = 0;

        //add order method
        public ActionResult methodAddOrder(Drink drinkToAdd)
        {
            drinkToAdd.ID = ++id;
            _drinkOrderList.Add(drinkToAdd);
            return RedirectToAction("Ordered");
        }

        //remove from order method
        public ActionResult methodMoveFromOrderedToPrepared(Drink drinkPassedIn)
        {
            _preparedDrinkList.RemoveAll(Drink => Drink.ID == drinkPassedIn.ID);
            _preparedDrinkList.Add(drinkPassedIn);
            return RedirectToAction("Prepared");
        }

        //returns Ordered view and passes in the _drinkOrderList
        public ActionResult Ordered()
        {
            return View(_drinkOrderList);
        }



        //Methods for the Prepared Drinks Page
        //creates the Prepared list
        List<Drink> _preparedDrinkList = new List<Drink>();
        
        //remove from prepared method
        public ActionResult MethodRemovePreparedDrink(Drink removeDrink)
        {
            _preparedDrinkList.RemoveAll(Drink => Drink.ID == removeDrink.ID);
            return RedirectToAction("Prepared");
        }

        //returns Ordered view and passes in the _drinkOrderList
        public ActionResult Prepared()
        {
            return View(_preparedDrinkList);
        }

    }
}