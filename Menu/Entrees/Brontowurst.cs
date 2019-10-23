using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// 
    /// </summary>    
    ///

   public class Brontowurst:Entree,IOrderItem,INotifyPropertyChanged
    {
        private bool brautwurst = true;
        private bool whole_wheat_bun = true;
        private bool peppers = true;
        private bool onions = true;
        /// <summary>
        /// setter and getter for the price property
        /// </summary>
        public override double Price { get; set; }
        /// <summary>
        /// setter and getter for the field calories
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// getter of th property Ingerdiants
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() ;
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                if (brautwurst) ingredients.Add("Brautwurst");
                if (whole_wheat_bun) ingredients.Add("Whole Wheat Bun");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs a new instance of TrexKingBurger with price property sets to 5.36 and calories property sets to 498
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// A methode to hold the papers  and sets the  papers field to False 
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Peppers");

        }
        /// <summary>
        /// A methode to hold the Onion  and sets the Onion field to False
        /// </summary>
        public void HoldOnion()
        {
            this.onions = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Onion");



        }
        /// <summary>
        /// A methode to hold the Bun and sets the Whole_wheat_bun fieldto False
        /// </summary>
        public void HoldBun()
        {
            this.whole_wheat_bun = false;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("whole_wheat_bun");



        }
        public override string ToString()
        {
            return "Brontowurst";

        }
        /// <summary>
        /// Gets the description of the combo.
        /// </summary>
        public virtual string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// A list of special instructions to be used during combo preparation.
        /// </summary>
        public virtual string[] Special
        {
            get
            {
                List<string> details = new List<string>();
                if (!whole_wheat_bun)
                    details.Add("Hold Bun");
              
                if (!peppers)
                    details.Add("Peppers");
                if (!onions)
                    details.Add("Onions");

                return details.ToArray();

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
