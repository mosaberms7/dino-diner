using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
   public class Menue
   {
        /// <summary>
        /// AvailableMenuItems property gets the value of AvailableMenuItems
        /// </summary>
        public List<MenuItem> AvailableMenuItems {
            get
            {
                List<MenuItem> availableMenuItems = new List<MenuItem>() {
                new CretaceousCombo(new Brontowurst()),
                    new CretaceousCombo(new DinoNuggets()),
                    new CretaceousCombo(new PrehistoricPBJ()),
                    new CretaceousCombo(new SteakosaurusBurger()),
                    new CretaceousCombo(new TRexKingBurger()),
                    new CretaceousCombo(new VelociWrap()),
                    new CretaceousCombo(new PrehistoricPBJ()),
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap(),
                    new PrehistoricPBJ(),
                    new JurassicJava(),
                    new Sodasaurus(),
                    new Tyrannotea(),
                    new Water(),
                    new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()};

                return availableMenuItems;


            }
            



                 }
        /// <summary>
        /// property for aviale entrees only get
        /// </summary>
      public  List <Entree> AvailableEntrees {
            get
            {
                List<Entree> availableEntrees = new List<Entree>
                {
                    new Brontowurst(),
                    new DinoNuggets(),
                    new PrehistoricPBJ(),
                    new SteakosaurusBurger(),
                    new TRexKingBurger(),
                    new VelociWrap(),
                    new PrehistoricPBJ()
                };
                return availableEntrees;
            }


        }/// <summary>
         /// AvailableSides property
         /// </summary>
        public List<Side> AvailableSides
        {
            get
            {
                List<Side> availableSides = new List<Side>()
                {
                     new Fryceritops(),
                    new MeteorMacAndCheese(),
                    new MezzorellaSticks(),
                    new Triceritots()

                };
                return availableSides;
                
            }

        }
        /// <summary>
        /// AvailableDrinks property with only getter
        /// </summary>
        public List<Drink> AvailableDrinks
        {
            get
            {
                List<Drink> availableDrinks = new List<Drink>() {
                     new Sodasaurus(),
                    new Tyrannotea(),
                    new JurassicJava(),
                    new Water()

                };
                


                return availableDrinks;
            }



        }
        /// <summary>
        /// AvailableCombos property with getter
        /// </summary>
        public List<CretaceousCombo> AvailableCombos
        {
            get
            {
                List<CretaceousCombo> availableCombos = new List<CretaceousCombo>
                {
                   new CretaceousCombo(new Brontowurst()),
                   new CretaceousCombo (new DinoNuggets()),
                   new CretaceousCombo (new PrehistoricPBJ()),
                   new CretaceousCombo (new SteakosaurusBurger()),
                   new CretaceousCombo (new TRexKingBurger()),
                   new CretaceousCombo (new VelociWrap()),
                   new CretaceousCombo (new PrehistoricPBJ())
                };
                return availableCombos;
            }
        }
        /// <summary>
        /// to string function
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// filteration function with 2 prameters
        /// </summary>
        /// <param name="searchRes"></param>
        /// <param name="menuCatogri"></param>
        /// <returns></returns>
        public List<MenuItem> ApplyFilter(List<MenuItem> searchRes, List<string> menuCatogri)
        {
            List<MenuItem> result = new List<MenuItem>();
            foreach (MenuItem item in searchRes)
            {
                if (item is Entree && menuCatogri.Contains("Entree"))
                {
                    result.Add(item);
                }
                else if (item is CretaceousCombo && menuCatogri.Contains("Combo"))
                {
                    result.Add(item);
                }
                else if (item is Side && menuCatogri.Contains("Side"))
                {
                    result.Add(item);
                }
                else if (item is Drink && menuCatogri.Contains("Drink"))
                {
                    result.Add(item);
                }
            }
            return result;
        }
        /// <summary>
        /// filter by minumum price function
        /// </summary>
        /// <param name="mi"></param>
        /// <param name="minPrice"></param>
        /// <returns></returns>
        public List<MenuItem> FilterByMinPrice(List<MenuItem> mi, float minPrice)
{
    List<MenuItem> results = new List<MenuItem>();
    foreach (MenuItem items in AvailableMenuItems)
    {
        if (items.Price != 0 && minPrice >= items.Price)
        {
            results.Add(items);
        }
    }
    return results;
}
        /// <summary>
        /// filter by maximum price function
        /// </summary>
        /// <param name="mi"></param>
        /// <param name="maxPrice"></param>
        /// <returns></returns>
   public List<MenuItem> FilterByMaxPrice(List<MenuItem> mi, float maxPrice)
   {
     List<MenuItem> results = new List<MenuItem>();
         foreach (MenuItem items in AvailableMenuItems)
         {
            if (items.Price != 0 && maxPrice <= items.Price)
                {
                results.Add(items);
                }
         }
    return results;
   }

    }
}
