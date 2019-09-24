using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuTest.Sides
{
    /// <summary>
    /// a class representing a side plate with 3 ingrediants using string
    /// </summary>
    public class MezzorellaSticks : Side
    {
        private Size size;
        /// <summary>
        /// constructs a new instance of Mezzorillastick with
        /// size,price and calories set to small, 0.99 and 540
        /// </summary>
        public MezzorellaSticks()
        {
            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 540;

        }
        /// <summary>
        ///sets and gets of size enum property
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
                        this.Calories = 540;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 610;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 720;
                        break;

                }
            }
            get
            {

                return size;

            }


        }
        /// <summary>
        /// set and get of the property ingredients<string>
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Breading");
                ingredients.Add("Cheese Product");
                ingredients.Add("Vegetable Oil");
                return ingredients;

            }
        }



    }
}
