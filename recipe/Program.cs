using System;
using System.Collections.Generic;

namespace recipe
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine(food1.ToString());
            Console.WriteLine(food2.ToString());
            Console.WriteLine(food3.ToString());
            Console.WriteLine(food4.ToString());
            Console.WriteLine(food5.ToString());
            */
            Recipe food1 = new Recipe(12345, "Ham&Eggs", new List<string> { "ham", "eggs", "oil", "salt", "pan" });
            Recipe food2 = new Recipe(21398, "Cottage Cheese Pancake", new List<string> { "cottage cheese", "eggs", "oil", "salt", "sugar", "sour cream", "flour" });
            Recipe food3 = new Recipe(92748, "Food3", new List<string> { "Food3 ingredient 1", "Food3 ingredient 2" });
            Recipe food4 = new Recipe(44729, "Food4", new List<string> { "Food4 ingredient 1", "Food4 ingredient 2" });
            Recipe food5 = new Recipe(39182, "Food5", new List<string> { "Food5 ingredient 1", "Food5 ingredient 2" });
            food1.DisplayOutput();
            food2.DisplayOutput();
            food3.DisplayOutput();
            food4.DisplayOutput();
            food5.DisplayOutput();


            Recipe food1copy = (Recipe)food1.ShallowCopy();
            food1copy.ID = 99182;
            food1copy.name = "NyamiKaja";
            food1copy.DisplayOutput();

        }
    }
}
