﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
   public class DinoNuggets
    {
       
        private uint Nuggets = 6;
        
        

        public double Price { get; set; }
        public uint Calories { get; set; }


            

        public List<string> Ingredients
        {
            get
            { 
                List<string> ingredients = new List<string>();
                for (int i = 0; i < Nuggets; i++) {


                    ingredients.Add("Chicken Nugget");

                }
                return ingredients;
            }
        }

        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories =Nuggets*59;
        }
        public void AddNugget() {

            Price += 0.25;
            Calories += 59; ;
            this.Nuggets++;

        }


        
    }
}

