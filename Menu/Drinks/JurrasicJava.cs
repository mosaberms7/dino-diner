using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class JurrasicJava : Drink
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
        public JurrasicJava()
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

        public override string ToString()
        {
            return "Jurrasic-Java";


        }

    }
}
