using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// a class 
    /// </summary>
   public class DinoNuggets:EntreeBase
    {
       private uint Nuggets = 6;
       ///setter and getter for the price property 
        public override double Price { get; set; }
        /// <summary>
        /// setter and getter for the calories property
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// getter for the Ingerdiants property 
        /// </summary>
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
        /// <summary>
        ///Constructs a new instance of TrexKingBurger with price property sets to 4.25 and calories property sets to the number of the nuggets multiplaied with the calory of one(59 calories) 
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories =Nuggets*59;
        }
        /// <summary>
        /// A methode to add Nuggets to the order it increments the field Nuggets by one and olso update the price and the calories
        /// </summary>
        public void AddNugget() {

            Price += 0.25;
            Calories += 59; ;
            this.Nuggets++;

        }


        
    }
}

