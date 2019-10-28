using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu
{

    /// <summary>
    /// an abstract class represents the side plate with 5 properties
    /// </summary>
    public abstract class Side : MenuItem,IOrderItem
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public virtual List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public abstract string ToString();
        

  
    /// <summary>
    /// A list of special instructions to be used during Entree preparation.
    /// </summary>
    public virtual string[] Special { get; set; }
    
    /// <summary>
    /// Gets the description of the Entree.
    /// </summary>
    public virtual string Description{get;set;}

    }
}
