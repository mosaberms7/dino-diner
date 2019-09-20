using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;


namespace DinoDiner.Menu.Entrees
{
    class Fryceritops : EntreeBase
    {
        public Fryceritops(Size s)
        {
            switch (s)
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
            this.Ingredients.Add("potatoes");
            this.Ingredients.Add("salt");
            this.Ingredients.Add("vegtable oil");
        }

      
       

    }



    }

