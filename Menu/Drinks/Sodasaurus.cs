using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Sodasaurus : Drink
    {
        public Sodasaurus() {
            

        }
        public virtual SodasaurusFlavor Flavor { get; set; }

    }
}
