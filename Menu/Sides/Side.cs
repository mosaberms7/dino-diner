﻿using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;

namespace DinoDiner.Menu.Sides
{
   
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
