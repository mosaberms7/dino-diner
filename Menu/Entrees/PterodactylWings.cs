using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{ /// <summary>
/// a class representing an entree plate 
/// </summary>
   public class PterodactylWings : Entree,IOrderItem,INotifyPropertyChanged
    {
        /// <summary>
        /// setter and getter of the price property
        /// </summary>       

        public override double Price { get; set; }
        /// <summary>
        /// setter and getter of the calories property
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// getter of the Calories property
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Chicken", "Wing Sauce" };
                return ingredients;
            }
        }
        /// <summary>
        /// Constructs a new instance of PterodactylWings with price property sets to 7.21 and calories property sets to 318
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }
        /// <summary>
        /// return the name of the entree
        /// </summary>
        /// <returns></returns>
        public override string  ToString()
        {
            return "Pterodactyl Wings";

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
