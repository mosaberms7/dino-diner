using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{ /// <summary>
/// a class representing an entree plate 
/// </summary>
   public class PterodactylWings : EntreeBase
    {
        /// <summary>
        /// setter and getter of the price property
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// setter and getter of the calories property
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// getter of the Calories property
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs a new instance of PterodactylWings with price property sets to 7.21 and calories property sets to 318
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }

        
}
}
