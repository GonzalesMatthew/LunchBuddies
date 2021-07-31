using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class Restaurant
    {
        public string Name;
        private List<string> RestaurantNames = new List<string> { "Pink Flamingo", "The Rusty Bucket", "The Lady's Hankerchief" };

        public Restaurant()
        {
            Random randomInteger = new();
            int r = randomInteger.Next(RestaurantNames.Count);
            Name = RestaurantNames[r];
        }
        
    }
}
