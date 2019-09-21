using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Text;

namespace MenuTest.Sides
{
  public  class MezzorellaSticks : Side
    {
        public MezzorellaSticks()
        {
           
            this.Ingredients.Add("breading");
            this.Ingredients.Add("cheese product");
            this.Ingredients.Add("vegtable oil");
        }
        public override Size Size
        {
            set
            {
                switch (Size)
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




    }
}
