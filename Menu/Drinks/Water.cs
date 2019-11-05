using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    public class Water : Drink,IOrderItem,INotifyPropertyChanged
    {
        private Size size;

        /// <summary>
        /// setter and getter for the lemon property
        /// </summary>
        public bool Lemon { get; set; }
        public override Size Size
        {

            set
            {
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Special");
                


                                            size = value;
                switch (value)
                {
                    case Size.Small:
                        this.Price = 0.10;
                        break;
                    case Size.Medium:
                        this.Price = 0.10;
                        
                        break;
                    case Size.Large:
                        this.Price = 0.10;
                        break;


                }
            }
            get
            {
                return size;
            }
        }


        /// <summary>
        /// constructs anew instance of WAter with
        /// lemon = false
        /// price=0.10
        /// calories=0
        /// </summary>
        public Water()
        {
            this.Lemon = false;
            this.Ice = true;
            this.Price = 0.10;
            this.Calories = 0;
        }
        /// <summary>
        /// a methode to add a lemon by assigning a true value to lemon property
        /// </summary>
       
        public void AddLemon()
        {
            this.Lemon = true;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Lemon");

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
                if(Lemon)
                    ingredients.Add("Lemon");

                return ingredients;
            }
        }
        /// <summary>
        /// the name and the size of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{size} Water";

        }
        /// <summary>
        /// A list of special instructions to be used during Entree preparation.
        /// </summary>
        public string[] Special
        {
            get
            {
                List<String> special = new List<string>();
                if (!Lemon)
                    special.Add("Add Lemon");

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
        public override void HoldIce()
        {
            base.HoldIce();
            NotifyOfPropertyChanged("Description");
            NotifyOfPropertyChanged("Special");
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
