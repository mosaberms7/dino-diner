
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// a class representing a side plate contains 3 ingredients using list of strings
    /// </summary>
    public class MeteorMacAndCheese : Side,IOrderItem,INotifyPropertyChanged
    {

        private Size size;
        /// <summary>
        /// constructs a new instance of MeteorMacAndCheese with
        /// size, price , calories set to small,0.99, 420
        /// </summary>
        public MeteorMacAndCheese()
        {
            this.Price = 0.99;
            this.Calories = 420;
            this.Size = Size.Small;
        }
        /// <summary>
        /// set and get the property Size
        /// </summary>
        public override Size Size
        {

            set
            {
                size = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");
                switch (value)
                {
                    case Size.Small:
                        this.Price = 0.99;
                        this.Calories = 420;
                        break;
                    case Size.Medium:
                        this.Price = 1.45;
                        this.Calories = 490;
                        break;
                    case Size.Large:
                        this.Price = 1.95;
                        this.Calories = 520;
                        break;

                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// get the property ingredints
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");

                return ingredients;

            }
        }
        /// <summary>
        /// return the size and the name of the side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Meteor Mac and Cheese";

        }
        /// <summary>
        /// A list of special instructions to be used during Entree preparation.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<String> special = new List<string>();

                return special.ToArray();

            }
        }
        /// <summary>
        /// Gets the description of the Entree.
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }


        }


        /// <summary>
        /// The event handler that handles if any properties of the combo were changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// An accessor method for invoking a property change.
        /// </summary>
        /// <param name="name">The name of the property being changed.</param>
        protected void NotifyOfPropertyChanged(string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
