using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurrasicJava : Drink
    {
        private Size size;
        public bool Sweet { get; set; }
        public bool Lemon { get; set; }

        public JurrasicJava()
        {
            this.Price = 0.59;
            this.Calories = 2;
            this.Ice = false;
            this.RoomForCream = false;
            this.Decaf = false;
        }
        public bool RoomForCream { get; set; }
        public bool Decaf { get; set; }
        public void LeaveRoomForCream()
        {
            this.RoomForCream = true;
        }
        public void AddIce()
        {
            this.Ice = true;
        }
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
        
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Coffee");
                
                return ingredients;
            }
        }
    }
}
