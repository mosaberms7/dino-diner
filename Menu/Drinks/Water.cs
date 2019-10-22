﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Water : Drink
    {
        private Size size;

        /// <summary>
        /// setter and getter for the lemon property
        /// </summary>
        public bool Lemon { get; set; }
        public override Size Size
        {

            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        this.Price = 0.10;
                        break;
                    case Size.Medium:
                        this.Price = 0.10;
                        
                        break;
                    case Size.Large:
                        this.Price = 0.10;
                        break;


                }
            }
            get
            {
                return size;
            }
        }


        /// <summary>
        /// constructs anew instance of WAter with
        /// lemon = false
        /// price=0.10
        /// calories=0
        /// </summary>
        public Water()
        {
            this.Lemon = false;
            this.Ice = true;
            this.Price = 0.10;
            this.Calories = 0;
        }
        /// <summary>
        /// a methode to add a lemon by assigning a true value to lemon property
        /// </summary>
       
        public void AddLemon()
        {
            this.Lemon = true;
        }
       
       /// <summary>
       /// getter for the ingredients property
       /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                if(Lemon)
                    ingredients.Add("Lemon");

                return ingredients;
            }
        }
        public override string ToString()
        {
            return $"{size} Water";

        }
    }
}
