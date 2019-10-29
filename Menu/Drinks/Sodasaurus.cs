using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
//using DinoDiner.Menu.Drinks;
//using MenuTest.Drinks;

namespace DinoDiner.Menu
{
   
    public class Sodasaurus : Drink,IOrderItem,INotifyPropertyChanged
    {

        private Size size;
        /// <summary>
        ///Constructs a new instance of TrexKingBurger with price property sets to 1.50 and calories property sets to 112 and the ice property to true 
        /// </summary>
        public Sodasaurus() {
            this.Price = 1.50;
            this.Calories = 112;
            this.Ice = true;

        }
        private SodasaurusFlavor flavor;
        /// <summary>
        /// the setter and getter of the sodasaurseFlavor property
        /// </summary>
        public override void HoldIce()
        {
            base.HoldIce();
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ice");
            NotifyOfPropertyChanged("Description");



        }
        /// <summary>
        /// flavor property
        /// </summary>
        public  SodasaurusFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Flavor");



            }
        }
        /// <summary>
        ///setter and getter for the Size property 
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
                        this.Price = 1.50;
                        this.Calories = 112;
                        break;
                    case Size.Medium:
                        this.Price = 2.00;
                        this.Calories = 156;
                        break;
                    case Size.Large:
                        this.Price = 2.50;
                        this.Calories = 208;
                        break;


                }
            }
            get
            {
                return size;
            }
        }
        /// <summary>
        /// getter fot the property ingredients
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                if(this.Ice)
                    ingredients.Add("Ice");

                return ingredients;
            }
        }
        /// <summary>
        /// return the size, name and the flavor of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string flavorString = this.Flavor.ToString();
            if (this.Flavor == SodasaurusFlavor.RootBeer)
            {
                flavorString = "Root Beer";
            }

            return $"{this.Size} {flavorString}\n Sodasaurus";
        }


    
    /// <summary>
    /// A list of special instructions to be used during Entree preparation.
    /// </summary>
    public string[] Special
        {
            get
            {
                List<String> special = new List<string>();
                if (!Ice)
                    special.Add("Hold Ice");

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
