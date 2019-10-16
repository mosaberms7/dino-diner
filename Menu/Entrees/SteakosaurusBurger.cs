using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// a class representing a Entree plate
    /// </summary>
   public class SteakosaurusBurger : Entree
    {
        private bool whole_wheat_bun = true;
        private bool steakburger_pattie = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        /// <summary>
        /// getter of the price property
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// getter of the Calories property
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// getter of the Ingerdiants property
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (steakburger_pattie) ingredients.Add("Steakburger Pattie");
                if (whole_wheat_bun) ingredients.Add("Whole Wheat Bun");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs a new instance of steakosaaurusburger with price property sets to 5.15 and calories property sets to 621
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        ///  A methode to hold the Bun and sets the Whole_wheat_bun field to False 
        /// </summary>
        public void HoldBun()
        {
            this.whole_wheat_bun = false;
        }
        /// <summary>
        ///  A methode to hold the Pickle and sets the  Pickle field to False 
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        ///  A methode to hold the Ketchup and sets the Ketchup field to False 
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        ///  A methode to hold the Mustard and sets the Mustard field to False 
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        public override string ToString()
        {
            return "Steakosaurus Burger";

        }
    }
}
