using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    interface MenuItem
    {
       double Price { get; }
        uint Calories { get; }
        List<string> Ingredients  { get; }
        string ToString();

    }
}
