using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea : Drink
    {
        private Size size;
        public bool Sweet { get; set; }
        public bool Lemon { get; set; }

        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
            this.Sweet = false;
            this.Lemon = false;
        }
        public SodasaurusFlavor Flavor { get; set; }
        public override Size Size
        {

            set
            {
                size = value;
                switch (value)
                {
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 8;
                        break;
                    case Size.Medium:
                        this.Price = 1.49;
                        this.Calories = 16;
                        break;
                    case Size.Large:
                        this.Price = 1.99;
                        this.Calories = 32;
                        break;


                }
            }
            get
            {
                return size;
            }
        }
        public void AddLemon() {

            this.Lemon = true;
        }
        public void AddSweet()
        {
            this.Sweet = true;
            this.Calories *= 2;
        }
        public void ReHoldSweet()
        {
            if (this.Sweet)
            {
                this.Sweet = false;
                this.Calories /= 2;
            }
        }
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if(Lemon)
                 ingredients.Add("Lemon");
                if(Sweet)
                 ingredients.Add("Sweet");
                return ingredients;
            }
        }
    }
}
