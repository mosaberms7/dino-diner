using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water : Drink
    {
        /// <summary>
        /// setter and getter for the lemon property
        /// </summary>
        public bool Lemon { get; set; }

        /// <summary>
        /// constructs anew instance of WAter with
        /// lemon = false
        /// price=0.10
        /// calories=0
        /// </summary>
        public Water()
        {
            this.Lemon = false;
            this.Ice = true;
            this.Price = 0.10;
            this.Calories = 0;
        }
        /// <summary>
        /// a methode to add a lemon by assigning a true value to lemon property
        /// </summary>
       
        public void AddLemon()
        {
            this.Lemon = true;
        }
       
       /// <summary>
       /// getter for the ingredients property
       /// </summary>
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
