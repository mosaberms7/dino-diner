using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {       
        public bool Lemon { get; set; }

        public Water()
        {
            this.Lemon = false;
        }
       
        public void AddLemon()
        {
            this.Lemon = true;
        }
       
       
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if(Lemon)
                    ingredients.Add("Lemon");

                return ingredients;
            }
        }
    }
}
