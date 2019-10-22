
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// a class representing a side plate contains 3 ingredients using list of strings
    /// </summary>
    public class MeteorMacAndCheese : Side
    {

        private Size size;
        /// <summary>
        /// constructs a new instance of MeteorMacAndCheese with
        /// size, price , calories set to small,0.99, 420
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Price = 0.99;
            this.Calories = 420;
            this.Size = Size.Small;
        }
        /// <summary>
        /// set and get the property Size
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
                        this.Calories = 420;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 520;
                        break;

                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// get the property ingredints
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");

                return ingredients;

            }
        }
        public override string ToString()
        {
            return $"{size} Meteor Mac and Cheese";

        }

    }
}
