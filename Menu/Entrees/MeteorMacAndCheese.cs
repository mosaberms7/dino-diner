using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    class MeteorMacAndCheese : Side
    {
        public MeteorMacAndCheese(Size s)
        {
            switch (s)
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
            this.Ingredients.Add("macaroni noodles");
            this.Ingredients.Add("cheese product");
            this.Ingredients.Add("pork sausage");
        }




    }
}
