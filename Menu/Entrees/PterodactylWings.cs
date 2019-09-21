using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{ 
   public class PterodactylWings : EntreeBase
    {
       
        public override double Price { get; set; }
        public override uint Calories { get; set; }

        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }

        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        
}
}
