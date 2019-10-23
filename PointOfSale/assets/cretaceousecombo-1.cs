using System;
using System.Collections.Generic;
using System.Text;

//using DinoDiner.Menu.Entrees;
//using DinoDiner.Menu.Menue;
using DinoDiner.Menu;
//using DinoDiner.Menu.Drinks;
using System.ComponentModel;


namespace DinoDiner.Menu
{
    public class cretaceousecombo : MenuItem, INotifyPropertyChanged
    {
       

        private Size size = Size.Small;
        public Entree Entree { get
            { return Entree; }
            protected set
            {
                Entree = value;
                Entree.PropertyChanged+=(object sender ,PropertyChangedEventArgs args ) =>
                    {
                    NotifiyPropertyChanged(args.PropertyName);


                    };
                    
            }
        }
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
        private Drink drink = new Sodasaurus();

        public event PropertyChangedEventHandler PropertyChanged;

        

        public double Price
        {
            get
            {
                return (Entree.Price + side.Price + drink.Price- 0.25);
            }
            
        }

        public Size size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;



            }


        }

        protected void NotifiyPropertyChanged(String Prop);
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
        public virtual string ToString()
        {
            return "";

        }
        public string Description
        {

            get{
                return this.ToString();
            }

        }
        public string[] Special
        {

            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.description);
                special.AddRange(Drink.Special);

            }
        }


    }
    }

