using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
   public class Menue
   {
      public  List<MenuItem> AvailableMenuItems {
            get
            {
                List<MenuItem> availableMenuItems = new List<MenuItem>();
                availableMenuItems.Add(new JurassicJava());
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
            



                 }
      public  List <Entree> AvailableEntrees {
            get
            {
                List<Entree> availableEntrees = new List<Entree>();
                availableEntrees.Add(new Brontowurst());
                availableEntrees.Add(new DinoNuggets());
                availableEntrees.Add(new PrehistoricPBJ());
                availableEntrees.Add(new SteakosaurusBurger());
                availableEntrees.Add(new TRexKingBurger());
                availableEntrees.Add(new VelociWrap());
                return availableEntrees;
            }


        }
       public List<Side> AvailableSides
        {
            get
            {
                List<Side> availableSides = new List<Side>();
                availableSides.Add(new Fryceritops());
                availableSides.Add(new MeteorMacAndCheese());
                availableSides.Add(new MezzorellaSticks());
                availableSides.Add(new Triceritots());
                return availableSides;
            }

        }
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> availableDrinks = new List<Drink>();
                availableDrinks.Add(new JurassicJava());
                availableDrinks.Add(new Sodasaurus());
                availableDrinks.Add(new Tyrannotea());
                availableDrinks.Add(new Water());
                return availableDrinks;
            }



        }
        public override string ToString()
        {
            return
             new JurassicJava().ToString() + " \n" + new Sodasaurus().ToString()
             + '\n' + new Tyrannotea().ToString() + '\n' + new Water().ToString()
             + '\n' + new Fryceritops().ToString() + '\n' + new MeteorMacAndCheese().ToString()+'\n'
             + new MezzorellaSticks().ToString()+'\n'+new Triceritots().ToString()+'\n'+ new DinoNuggets().ToString()+'\n'
             + new PrehistoricPBJ().ToString()+'\n'+ new PterodactylWings().ToString()
             ;
        }

    }
}
