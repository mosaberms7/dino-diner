using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuTest.Sides
{
  public  class MezzorellaSticks : Side
    {
        private Size size;

        public MezzorellaSticks()
        {
            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 540;
           
        }
        public override Size Size
        {
            
            set
            {
                size = value;
                switch (size)
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


        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                this.Ingredients.Add("Breading");
                this.Ingredients.Add("Cheese Product");
                this.Ingredients.Add("Vegtable Oil");
                return ingredients;

            }
        }



    }
}
