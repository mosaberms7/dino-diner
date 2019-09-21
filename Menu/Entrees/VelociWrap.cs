using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{/// <summary>
/// a class representing an entree plate
/// </summary>
   public class VelociWrap : EntreeBase
    {
       
        private bool flour_tortilla = true;
        private bool chicken_breast = true;
        private bool romaine_lettuce= true;
        private bool Ceasar_dressing= true;
        private bool parmesan_cheese= true;
        /// <summary>
        /// Sets and Get the price property
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// sets and gets the calories properties
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// getter of the Ingerdiants property
        /// </summary>
        public  override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                if (flour_tortilla) ingredients.Add("Flour Tortilla");
                if (chicken_breast) ingredients.Add("Chicken Breast");
                if (romaine_lettuce) ingredients.Add("Romaine Lettuce");
                if (Ceasar_dressing) ingredients.Add("Ceasar Dressing");
                if (parmesan_cheese) ingredients.Add("Parmesan Cheese");
                
                return ingredients;
            }
        }

        /// <summary>
        /// Constructs a new instance of Velociwrap with price property sets to 6.86 & calories property sets to 356
        /// </summary>
        public VelociWrap()
        {
            this.Price =6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// A methode to hold the Dressing and sets the Ceasser_dressing to False 
        /// </summary>
        public void HoldDressing()
        {
            this.Ceasar_dressing= false;
        }
        /// <summary>
        /// A methode to hold the Lettuce and sets the romaine_lettuce to False
        /// </summary>
        public void HoldLettuce()
        {
            this.romaine_lettuce = false;


        }
        /// <summary>
        ///  A methode to hold Cheese and sets the parmesan_cheese to False
        /// </summary>
        public void HoldCheese()
        {
            this.parmesan_cheese = false;

        }
    }
}
