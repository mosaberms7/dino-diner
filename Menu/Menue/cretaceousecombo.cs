using System;
using System.Collections.Generic;
using System.Text;

//using DinoDiner.Menu.Entrees;
//using DinoDiner.Menu.Menue;
using DinoDiner.Menu;
//using DinoDiner.Menu.Drinks;



namespace DinoDiner.Menu
{
    public class cretaceousecombo : MenuItem
    {
       

        private Size size = Size.Small;
        public Entree Entree { get; set; }
        public Side side {
            get
            {
                return side;
            }
            set
            {
                side = value;
                side.Size = size;
            }
                         }
    public Drink drink { get; set; }
    public double Price {
            get
               {
                return (Entree.Price + side.Price + drink.Price- 0.25);
                }
            
            


      }

    
    public  List<string> Ingredients
    {
        get
        {
            List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(side.Ingredients);

                ingredients.AddRange(drink.Ingredients);
                    return ingredients;
        }
    }

    public uint Calories { get { return Entree.Calories + side.Calories + drink.Calories;  }    }
    public cretaceousecombo(Entree e) {
            this.Entree = e;
            side = new Fryceritops();
            drink = new Sodasaurus();
        }
        public virtual void ToString()
        {
            Console.WriteLine("");


        }


    }
    }

