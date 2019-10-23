using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
//using DinoDiner.Menu.Sides;


namespace DinoDiner.Menu
{

    /// <summary>
    /// a class representing a side plate with 3 ingridents using list of strings
    /// </summary>
    public class Fryceritops : Side,MenuItem,IOrderItem,INotifyPropertyChanged
    {
        private Size size;

        /// <summary>
        /// set and get of the size enum property
        /// </summary>
        public override Size Size
        {
            set
            {
                size = value;
                


                if (value == Size.Small)
                {
                    this.Price = 0.99;
                    this.Calories = 222;
                }
                if (size == Size.Medium)
                {
                    this.Price = 1.45;
                    this.Calories = 365;
                }
                if (size == Size.Large)
                {
                    this.Price = 1.95;
                    this.Calories = 480;
                }
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// constructs a new instance of Fryceritops with the supplied value for size, price, calories
        /// </summary>
        public Fryceritops()
        {
            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 222;



        }
        /// <summary>
        /// get the property ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Potato");
                ingredients.Add("Salt");
                ingredients.Add("Vegetable Oil");
                return ingredients;

            }
        }
        /// <summary>
        /// return the name and the size of the class
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return $"{this.size} Fryceritops";

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

