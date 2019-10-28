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
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
     /// <summary>
     /// constructs anew instance of menue catogery page
     /// </summary>
     public MenuCategorySelection()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;

        }





        /// <summary>
        /// click event handler for the drink choice
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Create_drink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());

        }
        /// <summary>
        /// click event handler for the side cjhoice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Side_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection3());

        }
        /// <summary>
        /// click event handler for the entree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Create_entree_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreeSelection());

        }
        /// <summary>
        /// click event handler for the combo selection
        /// </summary> 
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Combo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboSelection());

        }
    }
}