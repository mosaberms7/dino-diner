using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// an abstract class with 3 properties
    /// </summary>
   public abstract class  Entree : MenuItem,IOrderItem
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
        /// <summary>
        /// return the description of the entree
        /// </summary>
       
        public virtual string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// A list of special instructions to be used during Entree preparation.
        /// </summary>
        public virtual  string[] Special { get; }


    }
}
