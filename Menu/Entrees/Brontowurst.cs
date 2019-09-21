using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// 
    /// </summary>
   public class Brontowurst:EntreeBase
    {
        private bool brautwurst = true;
        private bool whole_wheat_bun = true;
        private bool peppers = true;
        private bool onions = true;
        /// <summary>
        /// setter and getter for the price property
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// setter and getter for the field calories
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// getter of th property Ingerdiants
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() ;
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                if (brautwurst) ingredients.Add("Brautwurst");
                if (whole_wheat_bun) ingredients.Add("Whole Wheat Bun");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs a new instance of TrexKingBurger with price property sets to 5.36 and calories property sets to 498
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// A methode to hold the papers  and sets the  papers field to False 
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        /// <summary>
        /// A methode to hold the Onion  and sets the Onion field to False
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;

            
        }
        /// <summary>
        /// A methode to hold the Bun and sets the Whole_wheat_bun fieldto False
        /// </summary>
        public void HoldBun()
        {
            this.whole_wheat_bun = false;

        }
    }
}
