using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public Drink drink { get; private set; }
        public DinoDiner.Menu.Size Size { get; private set; }
        public bool Lemon { get; private set; } = false;
        public bool Ice { get; private set; } = true;



        /// <summary>
        /// construct a new instance of drinkn selection
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
            this.DataContext = this;


        }


        /// <summary>
        /// click event handler 
        /// </summary> for the flavor
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Flavor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }

        private void SmallDrink_Click(object sender, RoutedEventArgs e)
        {
            Size = DinoDiner.Menu.Size.Small;
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = DinoDiner.Menu.Size.Small;
                }

            }
        }

        private void MeduimDrink_Click(object sender, RoutedEventArgs e)
        {
            Size = DinoDiner.Menu.Size.Medium;
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = DinoDiner.Menu.Size.Medium;
                }
            }
        }


        private void LargeDrink_Click(object sender, RoutedEventArgs e)
        {
            Size = DinoDiner.Menu.Size.Large;

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }

        private void Cola_Click(object sender, RoutedEventArgs e)
        {
            drink = new Sodasaurus();
            AddItem(drink);

        }

        private void Tea_Click(object sender, RoutedEventArgs e)
        {
            drink = new Tyrannotea();
            
            drink.HoldIce();
            AddItem(drink);
        }

        private void Java_Click(object sender, RoutedEventArgs e)
        {
            drink = new JurassicJava();
            AddItem(drink);


        }

        private void AddLemon_Click(object sender, RoutedEventArgs e)
        {
            

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is Tyrannotea tea)
                    {
                        tea.Lemon = Lemon;
                    }
                    else if (drink is Water water)
                    {
                        water.Lemon = Lemon;
                    }
                }
            }
        }

        private void HoldIce_Click(object sender, RoutedEventArgs e)
        {
            if (!Ice)
            {
                Ice = false;
            }
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.Ice = Ice;
                }
            }

        }
        private void AddItem(Drink drink)
        {
            if (DataContext is Order order)
            {
                drink.Size = Size;
                order.Items.Add(drink);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
       
    }
}
