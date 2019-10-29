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
        public bool Lemon { get; private set; } = true;
        public bool Ice { get; private set; } = false;
        public bool sodachossen = false;
        public bool cofeechossen = false;

        public bool tea;


        /// <summary>
        /// construct a new instance of drinkn selection
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
            this.DataContext = this;
            tea = false;
        }


        /// <summary>
        /// click event handler 
        /// </summary> for the flavor
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Flavor_Click(object sender, RoutedEventArgs e)
        {
            if (sodachossen)
                NavigationService.Navigate(new FlavorSelection());
            else if(cofeechossen)
                NavigationService.Navigate(new FlavorSelection2());

        }
        /// <summary>
        /// when the small size clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// meduim size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// large size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
        /// <summary>
        /// cols is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cola_Click(object sender, RoutedEventArgs e)
        {
            drink = new Sodasaurus();
            sodachossen = true;
            AddItem(drink);

        }
        /// <summary>
        /// the trynoatea is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tea_Click(object sender, RoutedEventArgs e)
        {
            drink = new Tyrannotea();
            tea = true;
            drink.HoldIce();
            AddItem(drink);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Java_Click(object sender, RoutedEventArgs e)
        {
            drink = new JurassicJava();
            cofeechossen = true;
            AddItem(drink);


        }
        /// <summary>
        /// to add lemon oo the order item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLemon_Click(object sender, RoutedEventArgs e)
        {
            if (tea) { 

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is Tyrannotea tea)
                    {
                            tea.AddLemon();                    }
                    else if (drink is Water water)
                    {
                            water.AddLemon();                    }
                }
            }
            tea = false;
        }
            

        }
        /// <summary>
        /// hold the ice 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldIce_Click(object sender, RoutedEventArgs e)
        {
            if (Ice)
            {
                Ice = false;
            }
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    drink.HoldIce();
                }
            }

        }
        /// <summary>
        /// adding item to the list
        /// </summary>
        /// <param name="drink"></param>
        private void AddItem(Drink drink)
        {
            if (DataContext is Order order)
            {
                drink.Size = Size;
                order.addItems(drink);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
       
    }
}
