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
    /// Interaction logic for ComboSelection2.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// constructs an ew instance of ComboSelection
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
        }



      
        /// <summary>
        /// click event handler for trex choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TRex_King_BurgerC_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }
        /// <summary>
        /// click event handler for pbj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void PB_AND_J_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }
        /// <summary>
        /// click event handler for steak burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void Steakosarus_Burger_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }
        /// <summary>
        /// click event handler for the nuggets 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DIno_Nuggets_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }
        /// <summary>
        /// click event handler fot the wrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void Create_Veloci_Wrap_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }
        /// <summary>
        /// click event handler for the wings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Create_Pterodactyl_Wing_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }
        /// <summary>
        /// click event handler for the bronwrust
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Create_BrontowurstC_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CustomizeCombo());

        }
    }
}
