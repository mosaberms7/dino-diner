using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    /// <summary>
    /// a class representing a Entree plate
    /// </summary>
   public class SteakosaurusBurger : Entree,IOrderItem,INotifyPropertyChanged
    {
        private bool whole_wheat_bun = true;
        private bool steakburger_pattie = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;
        /// <summary>
        /// getter of the price property
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// getter of the Calories property
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// getter of the Ingerdiants property
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (steakburger_pattie) ingredients.Add("Steakburger Pattie");
                if (whole_wheat_bun) ingredients.Add("Whole Wheat Bun");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs a new instance of steakosaaurusburger with price property sets to 5.15 and calories property sets to 621
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        ///  A methode to hold the Bun and sets the Whole_wheat_bun field to False 
        /// </summary>
        public void HoldBun()
        {
            this.whole_wheat_bun = false;
            NotifyOfPropertyChanged("whole_wheat_bun");

            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        ///  A methode to hold the Pickle and sets the  Pickle field to False 
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
            NotifyOfPropertyChanged("pickle");

            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        ///  A methode to hold the Ketchup and sets the Ketchup field to False 
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
            NotifyOfPropertyChanged("ketchup");

            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        ///  A methode to hold the Mustard and sets the Mustard field to False 
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
            NotifyOfPropertyChanged("mustard");

            NotifyOfPropertyChanged("Special");

        }
        public void HoldPattie()
        {
            this.steakburger_pattie = false;
            NotifyOfPropertyChanged("steakburger_pattie");
            NotifyOfPropertyChanged("Special");

        }
        public override string ToString()
        {
            return "Steakosaurus Burger";

        }
        public override string[] Special
        {
            get
            {
                List<String> special = new List<string>();
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!steakburger_pattie) special.Add("Hold Steakburger Pattie");
                if (!whole_wheat_bun) special.Add("Hold Whole Wheat Bun");

                return special.ToArray();

            }
        }
        /// <summary>
        /// Gets the description of the Entree.
        /// </summary>
        public override string Description
        {
            get
            {
                return this.ToString();
            }


        }


        /// <summary>
        /// The event handler that handles if any properties of the combo were changed.
        /// </summary>
        public new event PropertyChangedEventHandler PropertyChanged;

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
