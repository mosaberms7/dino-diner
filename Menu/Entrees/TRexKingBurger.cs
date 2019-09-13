using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
   public class TRexKingBurger
    {
        private bool whole_wheat_bun = true;
        private bool steakburger_pattie = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool onion = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool mayo = true;
        public double Price { get; set; }
        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                if (pickle) ingredients.Add("Peanut Butter");
                if (ketchup) ingredients.Add("Jelly");
                if (mustard) ingredients.Add("Jelly");
                if (steakburger_pattie) ingredients.Add("Jelly");
                if (whole_wheat_bun) ingredients.Add("Jelly");
                if (lettuce) ingredients.Add("Jelly");
                if (onion) ingredients.Add("Jelly");
                if (mayo) ingredients.Add("Jelly");
                if (tomato) ingredients.Add("Jelly");
                
                return ingredients;
            }
        }

        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
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
        public void HoldTomato()
        {
            this.tomato = false;
        }
        public void HoldOnion()
        {
            this.onion = false;
        }
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        public void HoldMayo()
        {
            this.mayo = false;
        }


    }

}
