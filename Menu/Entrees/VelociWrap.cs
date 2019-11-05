using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{/// <summary>
/// a class representing an entree plate
/// </summary>
   public class VelociWrap : Entree,IOrderItem,INotifyPropertyChanged
    {
       
        private bool flour_tortilla = true;
        private bool chicken_breast = true;
        private bool romaine_lettuce= true;
        private bool Ceasar_dressing= true;
        private bool parmesan_cheese= true;

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
        public  override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                if (flour_tortilla) ingredients.Add("Flour Tortilla");
                if (chicken_breast) ingredients.Add("Chicken Breast");
                if (romaine_lettuce) ingredients.Add("Romaine Lettuce");
                if (Ceasar_dressing) ingredients.Add("Ceasar Dressing");
                if (parmesan_cheese) ingredients.Add("Parmesan Cheese");
                
                return ingredients;
            }
        }
        /// <summary>
        /// A list of special instructions to be used during Entree preparation.
        /// </summary>
      

        /// <summary>
        /// Constructs a new instance of Velociwrap with price property sets to 6.86 & calories property sets to 356
        /// </summary>
        public VelociWrap()
        {
            this.Price =6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// A methode to hold the Dressing and sets the Ceasser_dressing to False 
        /// </summary>
        public void HoldDressing()
        {
            this.Ceasar_dressing= false;
            NotifyOfPropertyChanged("Ceasar_dressing");
            NotifyOfPropertyChanged("Special");

        }
        /// <summary>
        /// A methode to hold the Lettuce and sets the romaine_lettuce to False
        /// </summary>
        public void HoldLettuce()
        {
            this.romaine_lettuce = false;
            NotifyOfPropertyChanged("romaine_lettuce");
            NotifyOfPropertyChanged("Special");



        }
        /// <summary>
        ///  A methode to hold Cheese and sets the parmesan_cheese to False
        /// </summary>
        public void HoldCheese()
        {
            this.parmesan_cheese = false;
            NotifyOfPropertyChanged("parmesan_cheese");
            NotifyOfPropertyChanged("Special");


        }
        public void HoldChicken()
        {
            this.chicken_breast = false;
            NotifyOfPropertyChanged("chicken_breast");
            NotifyOfPropertyChanged("Special");


        }
        /// <summary>
        /// return the name of the entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
        public override string[] Special
        {
            get
            {
                List<String> special = new List<string>();
                if (!flour_tortilla) special.Add("Flour Tortilla");
                if (!chicken_breast) special.Add("Chicken Breast");
                if (!romaine_lettuce) special.Add("Romaine Lettuce");
                if (!Ceasar_dressing) special.Add("Ceasar Dressing");
                if (!parmesan_cheese) special.Add("Parmesan Cheese");


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
