using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Tyrannotea : Drink,IOrderItem,INotifyPropertyChanged
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
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Size");


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
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Lemon");


        }
        /// <summary>
        /// amethode to add sweet
        /// </summary>
        public void AddSweet()
        {
            this.Sweet = true;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Sweet");


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
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Sweet");
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
        /// <summary>
        /// the name and the size of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Sweet)
                return $"{size} Sweet Tyrannotea";
            else 
                return $"{size} Tyrannotea";

        }
        /// <summary>
        /// A list of special instructions to be used during Entree preparation.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<String> special = new List<string>();
                if (Lemon)
                    special.Add("Add Lemon");
                if (Sweet)
                    special.Add("Add Sweet");
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
