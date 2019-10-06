using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// an abstract class with 3 properties
    /// </summary>
   public abstract class  Entree : MenuItem
    {
        /// <summary>
        /// setter and getter fot the Price property
        /// </summary>
        public virtual double Price { get; set; }
        /// <summary>
        /// setter and getter fot the calories property
        /// </summary>
        public virtual uint Calories { get; set; }
        /// <summary>
        /// getter for the Ingrediants property
        /// </summary>
        public virtual List<string> Ingredients { get; }
        /// <summary>
        /// methode to print the name of the class
        /// </summary>
        public virtual string ToString()
        {
            return "";


        }

    }
}
