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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        
        public CustomizeCombo()
        {
            InitializeComponent();
        }

       
        private void Side_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection3());

        }

        private void Create_Drink2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());


        }

        private void Small_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Meduimcombo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LargeCombo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
