using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
//using DinoDiner.Menu.Sides;


namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// 
    /// </summary>
    public class Fryceritops : Side
    {
    /// <summary>
    /// 
    /// </summary>
        public Fryceritops()
        {

            this.Ingredients.Add("Potato");
            this.Ingredients.Add("Salt");
            this.Ingredients.Add("Vegetable Oil");
        }

        public override Size Size
        {
            set
            {
                switch (Size)
                {
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 222;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 365;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 480;
                        break;

                }
            }


        }



    }
}

