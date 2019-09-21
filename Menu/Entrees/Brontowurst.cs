using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
   public class Brontowurst:EntreeBase
    {
        private bool brautwurst = true;
        private bool whole_wheat_bun = true;
        private bool peppers = true;
        private bool onions = true;

        public override double Price { get; set; }
        public override uint Calories { get; set; }
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

        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }

        public void HoldPeppers()
        {
            this.peppers = false;
        }

        public void HoldOnion()
        {
            this.onions = false;


        }
        public void HoldBun()
        {
            this.whole_wheat_bun = false;

        }
    }
}
