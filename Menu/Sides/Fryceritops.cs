using System;
using System.Collections.Generic;
using System.Text;
//using DinoDiner.Menu.Sides;


namespace DinoDiner.Menu
{

    /// <summary>
    /// a class representing a side plate with 3 ingridents using list of strings
    /// </summary>
    public class Fryceritops : Side
    {
        private Size size;

        /// <summary>
        /// set and get of the size enum property
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                if (value == Size.Small)
                {
                    this.Price = 0.99;
                    this.Calories = 222;
                }
                if (size == Size.Medium)
                {
                    this.Price = 1.45;
                    this.Calories = 365;
                }
                if (size == Size.Large)
                {
                    this.Price = 1.95;
                    this.Calories = 480;
                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// constructs a new instance of Fryceritops with the supplied value for size, price, calories
        /// </summary>
        public Fryceritops()
        {
            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 222;



        }
        /// <summary>
        /// get the property ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;

            }
        }
        public override string ToString()
        {
            return "Fryceritops";

        }




    }
}

