using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
   public class SteakosaurusBurger
    {
        private bool whole_wheat_bun = true;
        private bool steakburger_pattie = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
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

        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }

        public void HoldBun()
        {
            this.whole_wheat_bun = false;
        }

        public void HoldPickle()
        {
            this.pickle = false;
        }
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
