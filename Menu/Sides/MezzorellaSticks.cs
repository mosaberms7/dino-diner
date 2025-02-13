﻿using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
namespace DinoDiner.Menu
{
    /// <summary>
    /// a class representing a side plate with 3 ingrediants using string
    /// </summary>
    public class MezzorellaSticks : Side,IOrderItem,INotifyPropertyChanged
    {
        private Size size;
        /// <summary>
        /// constructs a new instance of Mezzorillastick with
        /// size,price and calories set to small, 0.99 and 540
        /// </summary>
        public MezzorellaSticks()
        {
            this.Size = Size.Small;
            this.Price = 0.99;
            this.Calories = 540;

        }
        /// <summary>
        ///sets and gets of size enum property
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
            get
            {

                return size;

            }


        }
        /// <summary>
        /// set and get of the property ingredients<string>
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Breading");
                ingredients.Add("Cheese Product");
                ingredients.Add("Vegetable Oil");
                return ingredients;

            }
        }
        /// <summary>
        /// return the name and the size of the side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Mezzorella Sticks";

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
