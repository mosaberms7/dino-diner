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
    /// Interaction logic for WrapCustomize.xaml
    /// </summary>
    public partial class WrapCustomize : Page
    {
        private bool i;
        /// <summary>
        /// constructs anew instance of this class
        /// </summary>
        public WrapCustomize()
        {
            InitializeComponent();
            i = false;
        }
        VelociWrap v = new VelociWrap();
        /// <summary>
        /// constructs anew instance of this class 
        /// </summary>
        /// <param name="v"></param>
        public WrapCustomize(VelociWrap v)
        {
            InitializeComponent();
            this.v = v;
            i = true;
        }
        /// <summary>
        /// when the HoldParmesn button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldParmesn_Click(object sender, RoutedEventArgs e)
        {
            v.HoldCheese();
        }
        /// <summary>
        /// when the HoldCesar button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldCesar_Click(object sender, RoutedEventArgs e)
        {
            v.HoldDressing();

        }
        /// <summary>
        /// when the Holdchicken button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldChicken_Click(object sender, RoutedEventArgs e)
        {

            v.HoldChicken();
        }
        /// <summary>
        /// when the HoldRomine button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldRomaine_Click(object sender, RoutedEventArgs e)
        {
            v.HoldLettuce();
        }
        /// <summary>
        /// when the done button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done_Click(object sender, RoutedEventArgs e)
        {
            if (i)
                NavigationService.Navigate(new CustomizeCombo());
            if (!i)
                NavigationService.Navigate(new MenuCategorySelection());
        }

        private void HoldFlour_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
