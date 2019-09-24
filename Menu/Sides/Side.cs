using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// a enum represents the size of the side plate
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// represents the size small of the plate
        /// </summary>
        Small,
        /// <summary>
        /// represents the medium size of the side plate
        /// </summary>
        Medium, 
        /// <summary>
        /// representing the large size of the side plate
        /// </summary>
        Large
    }
    /// <summary>
    /// an abstract class represents the side plate with 5 properties
    /// </summary>
    public abstract class Side
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

    }
}
