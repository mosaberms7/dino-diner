using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
   public class VelociWrap
    {
        private bool flour_tortilla = true;
        private bool chicken_breast = true;
        private bool romaine_lettuce= true;
        private bool Ceasar_dressing= true;
        private bool parmesan_cheese= true;
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                if (flour_tortilla) ingredients.Add("flou tortilla");
                if (chicken_breast) ingredients.Add("chiken breast");
                if (romaine_lettuce) ingredients.Add("romaine lettuce");
                if (Ceasar_dressing) ingredients.Add("Ceasar dressing");
                if (parmesan_cheese) ingredients.Add("parmesan cheese");
                
                return ingredients;
            }
        }

        public VelociWrap()
        {
            this.Price =6.86;
            this.Calories = 356;
        }

        public void HoldDressing()
        {
            this.Ceasar_dressing= false;
        }

        public void HoldLettuce()
        {
            this.romaine_lettuce = false;


        }
        public void HoldCheese()
        {
            this.parmesan_cheese = false;

        }
    }
}
