using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    class Menue
    {
        List<MenuItem> AvailableMenuItems {
            get
            {
                List<MenuItem> availableMenuItems = new List<MenuItem>();
                availableMenuItems.Add(new JurrasicJava());
                availableMenuItems.Add(new Sodasaurus());
                availableMenuItems.Add(new Tyrannotea());
                availableMenuItems.Add(new TRexKingBurger());
                availableMenuItems.Add(new VelociWrap());
                availableMenuItems.Add(new Fryceritops());
                availableMenuItems.Add(new MezzorellaSticks());
                availableMenuItems.Add(new Triceritots());
                availableMenuItems.Add(new Water());
                availableMenuItems.Add(new Brontowurst());
                availableMenuItems.Add(new DinoNuggets());
                availableMenuItems.Add(new PrehistoricPBJ());
                availableMenuItems.Add(new SteakosaurusBurger());
                availableMenuItems.Add(new TRexKingBurger());
                availableMenuItems.Add(new VelociWrap());

                return availableMenuItems;


            }




                ; }
    }
}
