using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// a class representing  an entree plaate 
    /// </summary>
   public class TRexKingBurger : EntreeBase
    {
        private bool whole_wheat_bun = true;
        private bool Lettuce = true;
        private bool tomato = true;
        private bool Onion = true;
        private bool Pickle = true;
        private bool Ketchup = true;
        private bool Mustard = true;
        private bool Mayo = true;
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
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");

                for (int i=0;i<3;i++) { 
                     ingredients.Add("Steakburger Pattie");
                                       }
                if (whole_wheat_bun) ingredients.Add("Whole Wheat Bun");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Onion) ingredients.Add("Onion");
                if (Mayo) ingredients.Add("Mayo");
                if (tomato) ingredients.Add("Tomato");
                
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs a new instance of TrexKingBurger with price property sets to 8.45 and calories property sets to 728
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// A methode to hold the Bun and sets the whole_wheat_bun field to False 
        /// </summary>
        public void HoldBun()
        {
            this.whole_wheat_bun = false;
        }
        /// <summary>
        /// A methode to hold the Pickle and sets the Pickle field to False 
        /// </summary>

        public void HoldPickle()
        {
            this.Pickle = false;
        }
        /// <summary>
        /// A methode to hold the Ketchup and sets the Ketchup field to False 
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }
        /// <summary>
        /// A methode to hold the Mustard and sets the Mustard field to False 
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
        }
        /// <summary>
        /// A methode to hold the Tomato and sets the Tomato field to False 
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }
        /// <summary>
        /// A methode to hold the Onion and sets the Onion field to False 
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false;
        }
        /// <summary>
        /// A methode to hold the Lettuce and sets the Lettuce field to False 
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }
        /// <summary>
        ///  A methode to hold the Mayo and sets the Mayo field to False 
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
        }


    }

}
