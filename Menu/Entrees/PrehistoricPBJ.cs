using System.Collections.Generic;
using System.Text;
using System;

namespace DinoDiner.Menu
{
    /// <summary>
    /// 
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;
        /// <summary>
        /// settter and getter of the price property
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// setter ang getter of the calories property
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// getter of the property Igrediants
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs a new instance of PterodactylWings with price property sets to 6.52 and calories property sets to 483
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// A methode to hold the peanutbutter and sets the beanubutter field to False 

        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// <summary>
        /// A methode to hold the Jelly and sets the Jelly field to False 
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
    
        public override string ToString()
        {
            return "Prehistoric PB&J";

        }

    }
}
