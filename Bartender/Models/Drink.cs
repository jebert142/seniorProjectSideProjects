using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bartender.Models
{
    //Drink model includes drink name, description, alcohol content, and price.
    public class Drink
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double AlcoholContent { get; set; }
        public double Price { get; set; }  
    }

    //not sure that the code below belongs here

    //private static List<Drink> menu = new List<Drink>()
    //        {
    //            new Drink { }
    //        }

}