using System.Collections.Generic;
using System.Web.Mvc;
using Bartender.Models;

namespace Bartender.Controllers
{
    //This controller houses each method for each step in the order process and other necessary objects
    //Three methods that alter the lists, Two that push the data to the views, Two lists created
    public class OrderController : Controller
    {
        //creates the order list
        private static List<Drink> _drinkOrderList = new List<Drink>();

        //creates the Prepared list
        private static List<Drink> _preparedDrinkList = new List<Drink>();

        //instantiates integer for ID tracking
        private static int id = 0;


        //Uses RedirectToRouteResult instead of Action result because action result did not take the program to the Prepared page
        //add order method
        public RedirectToRouteResult MethodAddOrder(Drink drinkToAdd)
        {
            drinkToAdd.ID = ++id;
            _drinkOrderList.Add(drinkToAdd);
            return RedirectToAction("Ordered");
        }

        //remove from order method
        public RedirectToRouteResult MethodMoveFromOrderedToPrepared(Drink drinkPassedIn)
        {
            _drinkOrderList.RemoveAll(drink => drink.ID == drinkPassedIn.ID);
            _preparedDrinkList.Add(drinkPassedIn);
            //need remove statement here to consolidate methods into one. I don't need two buttons
            return RedirectToAction("Prepared");
        }

        //remove from prepare queue 
        public RedirectToRouteResult MethodRemoveFromPrepareQueue(Drink drinkPassedIn)
        {
            _preparedDrinkList.RemoveAll(drink => drink.ID == drinkPassedIn.ID);
            //need remove statement here to consolidate methods into one. I don't need two buttons
            return RedirectToAction("Prepared");
        }


        //Return View Methods
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