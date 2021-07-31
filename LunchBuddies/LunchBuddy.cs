using System;
using System.Collections.Generic;

namespace LunchBuddies
{
    class LunchBuddy
    {
        public string FirstName { get; set; }
        public string LastName {get; set; }

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public void Eat()
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} enjoying themselves.");
        }
        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} {LastName} is eating {food} at the office.");

        }
        public void Eat(List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} with ");
            foreach(var person in companions)
            {
                Console.Write($"{person.FirstName}, ");
            }
            Console.WriteLine();
        }
        public void Eat(string food, List<LunchBuddy> companions)
        {
            var restaurant = new Restaurant();
            Console.WriteLine($"{FirstName} {LastName} is at {restaurant.Name} ordering {food} with ");
            foreach (var person in companions)
            {
                Console.Write($"{person.FirstName}, ");
            }
            Console.WriteLine();
        }
    }
}
