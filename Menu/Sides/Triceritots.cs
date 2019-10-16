using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;


namespace DinoDiner.Menu
{
    /// <summary>
    /// a class representing a side plate with 3 ingrediants using string
    /// </summary>
    public class Triceritots : Side
    {
        private Size size;
        /// <summary>
        /// constructs a new instance of Triceritots with
        /// size,price and calories set to small, 0.99 and 352
        /// </summary>
        public Triceritots()
        {

            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 352;

        }
        /// <summary>
        /// sets and gets of size enum property
        /// </summary>
        public override Size Size
        {

            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 352;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 410;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 590;
                        break;


                }
            }
            get
            {
                return size;
            }




        }
        /// <summary>
        /// set and get of the property ingredients
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
            return $"{size} Triceritots";
        }

    }
}
