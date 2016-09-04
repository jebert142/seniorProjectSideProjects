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
        public double ABV { get; set; } //Alcohol By Volume
        public double Price { get; set; }  
        public int ID { get; set; }
    }

}