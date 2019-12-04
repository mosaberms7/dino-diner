using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// 
    /// </summary>
    public interface MenuItem
    {
        /// <summary>
        /// property with a getter for Price
        /// </summary>
        double Price { get; }
        /// <summary>
        /// property with a getter for Calories
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// property with a getter for Ingredients
        /// </summary>
        List<string> Ingredients  { get; }
        string ToString();

    }
}
