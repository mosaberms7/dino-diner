using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
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

   

    public abstract  class Drink
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
        /// Gets or sets the size
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public virtual bool Ice { get; set; }

        public virtual void HoldIce() {
            this.Ice = false;

        }
    }
}
