using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    abstract class  EntreeBase
    {
        public double Price { get; set; }
        public uint Calories { get; set; }
        public List<string> Ingredients { get; }

    }
}
