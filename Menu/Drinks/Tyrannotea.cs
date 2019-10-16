using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink
    {
        private Size size;
        /// <summary>
        /// setter and getter for the sweet property
        /// </summary>
        public bool Sweet { get; set; }
        /// <summary>
        /// setter and getter for the lemon flavor
        /// </summary>
        public bool Lemon { get; set; }
        /// <summary>
        /// constructs anew instance of Tyrannotea with default price=0.99,calories=8
        /// sweet =false
        /// lemon = false
        /// </summary>
        public Tyrannotea()
        {
            this.Price = 0.99;
            this.Calories = 8;
            this.Sweet = false;
            this.Lemon = false;
        }
        /// <summary>
        /// setter and getter for the flavor property
        /// </summary>
        public SodasaurusFlavor Flavor { get; set; }
        /// <summary>
        /// setter and getter for the sixe property
        /// </summary>
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
        /// <summary>
        /// a methode to set the lemon property to true
        /// </summary>
        public void AddLemon() {

            this.Lemon = true;
        }
        /// <summary>
        /// amethode to add sweet
        /// </summary>
        public void AddSweet()
        {
            this.Sweet = true;
            this.Calories *= 2;
        }
        /// <summary>
        /// methode to hold the sweet after adding
        /// </summary>
        public void ReHoldSweet()
        {
            if (this.Sweet)
            {
                this.Sweet = false;
                this.Calories /= 2;
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
                ingredients.Add("Tea");
                if(Lemon)
                 ingredients.Add("Lemon");
                if(Sweet)
                 ingredients.Add("Sweet");
                return ingredients;
            }
        }

        public override string ToString()
        {
            if (Sweet) return $"{size} Sweet Tyrannotea";
            else return $"{size} Tyrannotea";

        }
    }
}
