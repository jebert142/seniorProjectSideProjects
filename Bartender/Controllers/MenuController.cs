using Bartender.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Mvc;

namespace Bartender.Controllers
{

    //MenuController contains all the methods which return the views
    public class MenuController : Controller
    {
    //moved to order controller
        private static List<Drink> _drinkList = new List<Drink>() 
        {
            new Drink
            {
                Name = "Bloody Bulldog", Description = "Gin and tomato-juice cocktail. No vodka here.", ABV = .11, Price = 7.50
            },
            new Drink
            {
                Name = "Jack and Coke", Description = "Jack Daniels + Coca-Cola", ABV = .08, Price = 4.50
            },
            new Drink
            {
                Name = "Eclipse", Description = "Tequilla and some other things. Sweet, sour, and served on the rocks.", ABV = .13, Price = 6.00
            },
            new Drink
            {
                Name = "Vodka Martini", Description = "Shaken, not Stirred should come to mind.", ABV = .12, Price = 9.50
            },
            new Drink
            {
                Name = "Mojito", Description = "Traditional Cuban Highball. Rum, lime, soda water, sugar, mint.", ABV = .11, Price = 5.50
            },
            new Drink
            {
                Name = "Margarita", Description = "Gin and tomato-juice cocktail. No Vodka here.", ABV = .15, Price = 7.00
            },
            new Drink
            {
                Name = "Manhattan", Description = "Whiskey, cherry, something else. Served straight up, no ice", ABV = .09, Price = 9.50
            }
        };


        // GET: Menu
        //Views have a red line under them?

        //returns the Index.cshtml view
        public ActionResult Index()
        {
            return View(_drinkList);
        }

        //returns the Prepared.cshtml view
        public ActionResult Prepared()
        {
            return View(_drinkList);
        }
    }

}