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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {

        public DrinkSelection returnPage { get; set; }
        public SodasaurusFlavor flavor { get; private set; }

        /// <summary>
        /// constructs anew instance of the flavor
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
            flavor = SodasaurusFlavor.Cola;


        }

        DrinkSelection d = new DrinkSelection();
        
    
        /// <summary>
        /// select a cola flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cola_Click(object sender, RoutedEventArgs e)
        {
            string flavor = (string)(((Button)sender).Content);
            flavor = (SodasaurusFlavor.Cola).ToString();
            NavigationService.GoBack();
        }
        /// <summary>
        /// select a cherry flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cherry_Click(object sender, RoutedEventArgs e)
        {
            
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is Sodasaurus sodasaurus)
                    {
                        sodasaurus.Flavor = SodasaurusFlavor.Cherry;
                    }
                    
                }
            }
            NavigationService.GoBack();
        }
        /// <summary>
        /// select a choco flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Choco_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is Sodasaurus sodasaurus)
                    {
                        sodasaurus.Flavor = SodasaurusFlavor.Chocolate;
                    }

                }
            }
            NavigationService.GoBack();
        }
            /// <summary>
            /// Add lemon 
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void Lemon_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is Sodasaurus sodasaurus)
                    {
                        sodasaurus.Flavor = SodasaurusFlavor.Lime;
                    }

                }
            }
            NavigationService.GoBack();
        }
        /// <summary>
        /// select a Rootbeer flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Rootbeer_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is Sodasaurus sodasaurus)
                    {
                        sodasaurus.Flavor = SodasaurusFlavor.RootBeer;
                    }

                }
            }
            NavigationService.GoBack();
        }
        /// <summary>
        /// select a Vanilla flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Vanilla_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is Sodasaurus sodasaurus)
                    {
                        sodasaurus.Flavor = SodasaurusFlavor.Vanilla;
                    }

                }
            }
            NavigationService.GoBack();
        }
        /// <summary>
        /// select a Orange flavor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Orange_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is Sodasaurus sodasaurus)
                    {
                        sodasaurus.Flavor = SodasaurusFlavor.Orange;
                    }

                }
            }
            NavigationService.GoBack();
        }
    }
}
