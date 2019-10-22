using System;
using System.Collections.Generic;
using System.Text;
//using DinoDiner.Menu.Drinks;
//using MenuTest.Drinks;

namespace DinoDiner.Menu
{
   
    public class Sodasaurus : Drink
    {

        private Size size;
        /// <summary>
        ///Constructs a new instance of TrexKingBurger with price property sets to 1.50 and calories property sets to 112 and the ice property to true 
        /// </summary>
        public Sodasaurus() {
            this.Price = 1.50;
            this.Calories = 112;
            this.Ice = true;

        }
        private SodasaurusFlavor flavor;
        /// <summary>
        /// the setter and getter of the sodasaurseFlavor property
        /// </summary>
        public  SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        /// <summary>
        ///setter and getter for the Size property 
        /// </summary>
        public override Size Size
        {

            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        this.Price = 1.50;
                        this.Calories = 112;
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    case Size.Large:
                        this.Price = 2.50;
                        this.Calories = 208;
                        break;


                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// getter fot the property ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                if(this.Ice)
                    ingredients.Add("Ice");

                return ingredients;
            }
        }
        public override string ToString()
        {
            return $"{size} {flavor} Sodasaurus";

        }


    }
}
