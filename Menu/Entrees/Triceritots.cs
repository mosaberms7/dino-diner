using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Text;


namespace MenuTest.Sides
{
  public  class Triceritots : Side
    {
        private Size size;

        public Triceritots()
        {

            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 352;

        }
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


    }
}
