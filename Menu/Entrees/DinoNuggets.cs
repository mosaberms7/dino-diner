using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// a class 
    /// </summary>
   public class DinoNuggets:Entree,IOrderItem,INotifyPropertyChanged
    {
       private uint Nuggets = 6;
       ///setter and getter for the price property 
        public override double Price { get; set; }
        /// <summary>
        /// setter and getter for the calories property
        /// </summary>
        public override uint Calories { get; set; }
        /// <summary>
        /// getter for the Ingerdiants property 
        /// </summary>
        public override List<string> Ingredients
        {
            get
            { 
                List<string> ingredients = new List<string>();
                for (int i = 0; i < Nuggets; i++) {


                    ingredients.Add("Chicken Nugget");

                }
                return ingredients;
            }
        }
        /// <summary>
        ///Constructs a new instance of TrexKingBurger with price property sets to 4.25 and calories property sets to the number of the nuggets multiplaied with the calory of one(59 calories) 
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories =Nuggets*59;
        }
        /// <summary>
        /// A methode to add Nuggets to the order it increments the field Nuggets by one and olso update the price and the calories
        /// </summary>
        public void AddNugget() {

            Price += 0.25;
            Calories += 59; ;
            this.Nuggets++;
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Price");


        }

        /// <summary>
        /// <returns>Returns the name of the Entree.</returns>
        /// </summary>

        public override string ToString()
        {
            return "Dino-Nuggets";

        }
        /// <summary>
        /// Gets the description of the Entree.
        /// </summary>
        public virtual string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// A list of special instructions to be used during Entree preparation.
        /// </summary>
        public virtual string[] Special
        {
            get
            {
                List<string> details = new List<string>();
                if(Nuggets>6)
                details.Add($"{ Nuggets-6}Extra Nuggets");

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

