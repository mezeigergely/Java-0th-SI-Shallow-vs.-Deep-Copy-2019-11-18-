using System;
using System.Collections.Generic;
using System.Text;

namespace recipe
{
    class Recipe
    {
        public int ID { get; set; }
        public string name { get; set; }
        public List<string> ingredients { get; set; }

        public Recipe(int i, string n, List<string> ingr)
        {
            ID = i;
            name = n;
            ingredients = ingr;

        }
        public override string ToString()
        {
            string ideiglenes = "";
            foreach (var item in ingredients)
            {
                ideiglenes += item + ", ";

            }
            return "Recipe: " + ID + ", name: " + name + ", ingredients: " + ideiglenes;
        }

        public void DisplayOutput()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + name);
            string ideiglenes = "";
            foreach (var item in ingredients)
            {
                ideiglenes += item + ", ";

            }
            Console.WriteLine("Ingredients: " + ideiglenes);
        }

        public object ShallowCopy()
        {
            return MemberwiseClone();
        }
    }
}
