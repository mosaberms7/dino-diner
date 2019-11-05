using System;
using System.Collections.Generic;
using DinoDiner.Menu;
using System.ComponentModel;

using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// a class representing  an entree plaate 
    /// </summary>
   public class TRexKingBurger : Entree,IOrderItem,INotifyPropertyChanged
    {
        private bool whole_wheat_bun = true;
        private bool Lettuce = true;
        private bool tomato = true;
        private bool Onion = true;
        private bool Pickle = true;
        private bool Ketchup = true;
        private bool Mustard = true;
        private bool Mayo = true;
        /// <summary>
        /// Sets and Get the price property
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// sets and gets the calories properties
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// getter of the Ingerdiants property
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                if (Pickle) ingredients.Add("Pickle");
                if (Ketchup) ingredients.Add("Ketchup");
                if (Mustard) ingredients.Add("Mustard");

                for (int i=0;i<3;i++) { 
                     ingredients.Add("Steakburger Pattie");
                                       }
                if (whole_wheat_bun) ingredients.Add("Whole Wheat Bun");
                if (Lettuce) ingredients.Add("Lettuce");
                if (Onion) ingredients.Add("Onion");
                if (Mayo) ingredients.Add("Mayo");
                if (tomato) ingredients.Add("Tomato");
                
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs a new instance of TrexKingBurger with price property sets to 8.45 and calories property sets to 728
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// A methode to hold the Bun and sets the whole_wheat_bun field to False 
        /// </summary>
        public void HoldBun()
        {
            this.whole_wheat_bun = false;
            NotifyOfPropertyChanged("whole_wheat_bun");
            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        /// A methode to hold the Pickle and sets the Pickle field to False 
        /// </summary>

        public void HoldPickle()
        {
            this.Pickle = false;
            NotifyOfPropertyChanged("Pickle");
            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        /// A methode to hold the Ketchup and sets the Ketchup field to False 
        /// </summary>
        public void HoldKetchup()
        {
            this.Ketchup = false;
            NotifyOfPropertyChanged("Ketchup");
            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        /// A methode to hold the Mustard and sets the Mustard field to False 
        /// </summary>
        public void HoldMustard()
        {
            this.Mustard = false;
            NotifyOfPropertyChanged("Mustard");
            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        /// A methode to hold the Tomato and sets the Tomato field to False 
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
            NotifyOfPropertyChanged("tomato");
            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        /// A methode to hold the Onion and sets the Onion field to False 
        /// </summary>
        public void HoldOnion()
        {
            this.Onion = false;
            NotifyOfPropertyChanged("Onion");
            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        /// A methode to hold the Lettuce and sets the Lettuce field to False 
        /// </summary>
        public void HoldLettuce()
        {
            this.Lettuce = false;
            NotifyOfPropertyChanged("Lettuce");
            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        ///  A methode to hold the Mayo and sets the Mayo field to False 
        /// </summary>
        public void HoldMayo()
        {
            this.Mayo = false;
            NotifyOfPropertyChanged("Mayo");
            NotifyOfPropertyChanged("Special");

        }
        public override string ToString()
        {
            return "T-Rex King Burger";

        }
        /// <summary>
        /// A list of special instructions to be used during Entree preparation.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<String> special = new List<string>();
                if (!Pickle) special.Add("Hold Pickle");
                if (!Ketchup) special.Add("Hold Ketchup");
                if (!Mustard) special.Add("Hold Mustard");
                if (!whole_wheat_bun) special.Add("Hold Whole Wheat Bun");
                if (!Lettuce) special.Add("Hold Lettuce");
                if (!Onion) special.Add("Hold Onion");
                if (!Mayo) special.Add("Hold Mayo");
                if (!tomato) special.Add("Hold Tomato");

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
