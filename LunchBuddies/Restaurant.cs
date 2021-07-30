using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class Restaurant
    {
        private List<string> RestaurantNames { get; set; }
        public string Name { get; set; }

        if(RestaurantNames == null) 
        {
            RestaurantNames = new List<string> {"Pink Flamingo", "The Rusty Bucket", "The Lady's Hankerchief"};
        }   
        int index = Random.Next(RestaurantNames.Count);
        
    }
}
