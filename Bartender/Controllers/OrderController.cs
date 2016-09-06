using System.Collections.Generic;
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
        public RedirectToRouteResult MethodAddOrder(Drink drinkToAdd)
        {
            drinkToAdd.ID = ++id;
            _drinkOrderList.Add(drinkToAdd);
            return RedirectToAction("Ordered");
        }

        //remove from order method
        public ActionResult MethodMoveFromOrderedToPrepared(Drink drinkPassedIn)
        {
            _preparedDrinkList.RemoveAll(drink => drink.ID == drinkPassedIn.ID);
            _preparedDrinkList.Add(drinkPassedIn);
            //need remove statement here to consolidate methods into one. I don't need two buttons
            return RedirectToAction("Prepared");
        }

        //creates the Prepared list
        List<Drink> _preparedDrinkList = new List<Drink>();
        
        //remove from prepared method
        public ActionResult MethodRemovePreparedDrink(Drink removeDrink)
        {
            _preparedDrinkList.RemoveAll(drink => drink.ID == removeDrink.ID);
            return RedirectToAction("Prepared");
        }


        //returns Ordered view and passes in the _drinkOrderList
        public ActionResult Ordered()
        {
            return View(_drinkOrderList);
        }

        //returns Ordered view and passes in the _preparedDrinkList
        public ActionResult Prepared()
        {
            return View(_preparedDrinkList);
        }

    }
}