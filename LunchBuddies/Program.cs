using System.Collections.Generic;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var lunchBuddy = new LunchBuddy("Matthew","Gregory");
            lunchBuddy.Eat();
            lunchBuddy.Eat("all the pizza");
            lunchBuddy.Eat(new List<LunchBuddy>
            {
                new LunchBuddy("Barack","Obama"),
                new LunchBuddy("Dave","Chappelle"),
                new LunchBuddy("Norm","MacDonald")
            });
            lunchBuddy.Eat("Singapore Noodles", new List<LunchBuddy>
            {
                new LunchBuddy("Max","Verstappen"),
                new LunchBuddy("Checo","Perez")
            }) ;
        }
    }
}
