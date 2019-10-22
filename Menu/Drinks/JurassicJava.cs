﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurassicJava : Drink,IOrderItem
    {
        private Size size;
        /// <summary>
        /// setter and getter for the sweet property
        /// </summary>
        public bool Sweet { get; set; }
        /// <summary>
        /// setter and getter for the lemon property
        /// </summary>
        public bool Lemon { get; set; }
        /// <summary>
        /// constructs a new instance of JurrasicJava and sete the price property to 0.59
        /// the calories to 2
        /// the ice to false, the roomforcream to false, the decaf to false
        /// </summary>
        public JurassicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            this.Ice = false;
            this.RoomForCream = false;
            this.Decaf = false;
        }
        /// <summary>
        /// setter and getter for the RommForCream property
        /// </summary>
        public bool RoomForCream { get; set; }
        /// <summary>
        /// setter and getter for the Decaf property
        /// </summary>
        public bool Decaf { get; set; }
        /// <summary>
        /// A methode to set the roomforcream propertu to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }
        /// <summary>
        /// A methode to set the Ice propertu to true
        /// </summary>
        public void AddIce()
        {
            this.Ice = true;
        }
        /// <summary>
        /// setter and getter for the size property
        /// </summary>
        public override Size Size
        {

            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        this.Price = 0.59;
                        this.Calories = 2;
                        break;
                    case Size.Medium:
                        this.Price = 0.99;
                        this.Calories = 4;
                        break;
                    case Size.Large:
                        this.Price = 1.49;
                        this.Calories = 8;
                        break;


                }
            }
            get
            {
                return size;
            }
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
                ingredients.Add("Coffee");
                if (Ice)
                    ingredients.Add("Ice");
                return ingredients;
            }
        }
        public override string Description
        {
            get
            {
                return this.ToString();
            }
        }
        private string[] special;
        public override string[] Special
        {

            get
            {
                if(Sweet)
                special[0] = "Sweet";
                if (Decaf)
                    special[1] = "Decaf";
                return special;
            }
        }
        public override string ToString()
        {
<<<<<<< HEAD:Menu/Drinks/JurassicJava.cs
            if(Decaf)
            return $"{size} Decaf Jurassic Java";
            else 
                return $"{size} Jurassic Java";
=======
            if(Decaf) return $"{this.size} Decaf Jurassic Java";
           else return $"{this.size} Jurassic Java";

>>>>>>> 071f9f15c4d0254fc0dcdaee49d44aa69032f37c:Menu/Drinks/JurrasicJava.cs

        }

    }
}
