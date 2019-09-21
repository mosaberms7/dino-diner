using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
   public class TRexKingBurger : EntreeBase
    {
        private bool whole_wheat_bun = true;
       // private bool steakburger_pattie = true;
        private bool Lettuce = true;
        private bool tomato = true;
        private bool Onion = true;
        private bool Pickle = true;
        private bool Ketchup = true;
        private bool Mustard = true;
        private bool Mayo = true;
        public override double Price { get; set; }
        public override uint Calories { get; set; }

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
            this.Pickle = false;
        }
        public void HoldKetchup()
        {
            this.Ketchup = false;
        }
        public void HoldMustard()
        {
            this.Mustard = false;
        }
        public void HoldTomato()
        {
            this.tomato = false;
        }
        public void HoldOnion()
        {
            this.Onion = false;
        }
        public void HoldLettuce()
        {
            this.Lettuce = false;
        }
        public void HoldMayo()
        {
            this.Mayo = false;
        }


    }

}
