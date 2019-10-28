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
        public static string image { get; set; } = "assets/cola.jpg";

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
        
    

        private void Cola_Click(object sender, RoutedEventArgs e)
        {
            string flavor = (string)(((Button)sender).Content);
            flavor = (SodasaurusFlavor.Cola).ToString();
            image = "assets/cola.jpg";
            NavigationService.Navigate(returnPage);
        }

        private void Cherry_Click(object sender, RoutedEventArgs e)
        {
            string flavor = (string)(((Button)sender).Content);
            flavor = (SodasaurusFlavor.Cherry).ToString();
            image = "assets/cherry.jpg";
            NavigationService.Navigate(returnPage);
        }

        private void Choco_Click(object sender, RoutedEventArgs e)
        {
            string flavor = (string)(((Button)sender).Content);
            flavor = (SodasaurusFlavor.Chocolate).ToString();
            image = "assets/choco.jpg";

            NavigationService.Navigate(returnPage);
        }

        private void Lemon_Click(object sender, RoutedEventArgs e)
        {
            string flavor = (string)(((Button)sender).Content);
            flavor = (SodasaurusFlavor.Lime).ToString();
            image = "assets/lime.jpg";

            NavigationService.Navigate(returnPage);
        }

        private void Rootbeer_Click(object sender, RoutedEventArgs e)
        {
            string flavor = (string)(((Button)sender).Content);
            flavor = (SodasaurusFlavor.RootBeer).ToString();
            image = "assets/rb.jpg";

            NavigationService.Navigate(returnPage);
        }

        private void Vanilla_Click(object sender, RoutedEventArgs e)
        {
            string flavor = (string)(((Button)sender).Content);
            flavor = (SodasaurusFlavor.Vanilla).ToString();
            image = "assets/VANILLA.jpeg";
            NavigationService.Navigate(returnPage);

        }

        private void Orange_Click(object sender, RoutedEventArgs e)
        {
            string flavor = (string)(((Button)sender).Content);
            flavor = (SodasaurusFlavor.Orange).ToString();
            image = "assets/orange.png";
            NavigationService.Navigate(returnPage);
        }
    }
}
