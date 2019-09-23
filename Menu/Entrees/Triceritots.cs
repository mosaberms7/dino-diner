﻿using DinoDiner.Menu.Sides;
using System;
using System.Collections.Generic;
using System.Text;


namespace MenuTest.Sides
{
  public  class Triceritots : Side
    {

        
        public Triceritots()
        {
            
            
            this.Ingredients.Add("potatoes");
            this.Ingredients.Add("salt");
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
