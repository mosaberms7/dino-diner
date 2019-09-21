using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
   public class DinoNuggets:EntreeBase
    {
       
        private uint Nuggets = 6;
        
        

        public override double Price { get; set; }
        public override uint Calories { get; set; }


            

        public override List<string> Ingredients
        {
            get
            { 
                List<string> ingredients = new List<string>();
                for (int i = 0; i < Nuggets; i++) {


                    ingredients.Add("Chicken Nugget");

                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories =Nuggets*59;
        }
        public void AddNugget() {

            Price += 0.25;
            Calories += 59; ;
            this.Nuggets++;

        }


        
    }
}

