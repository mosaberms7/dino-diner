﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    public class JurassicJava : Drink,IOrderItem,INotifyPropertyChanged
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
        /// <summary>
        /// setter and getter for the RommForCream property
        /// </summary>
        public bool RoomForCream { get; set; }
        /// <summary>
        /// setter and getter for the Decaf property
        /// </summary>
        private bool decaf;
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChanged("Decaf");
                NotifyOfPropertyChanged("Description");



            }
        }
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
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ice");




        }
        /// <summary>
        /// setter and getter for the size property
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
        public override string[] Special
        {

            get
            {
                List<string> special = new List<string>();

                if (!Sweet)
                    special.Add("Hold Sweet");
                if (!Decaf)
                    special.Add("Hold Decaf");
                if (Ice)
                    special.Add("Add Ice");
                return special.ToArray();
            }
        }
        /// <summary>
        /// return the name of the side the size 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(Decaf)
                return $"{size} Decaf Jurassic Java";
            else 
                return $"{size} Jurassic Java";


        }

    }
}
