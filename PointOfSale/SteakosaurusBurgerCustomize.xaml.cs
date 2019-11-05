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
    /// Interaction logic for SteakosaurusBurgerCustomize.xaml
    /// </summary>
    public partial class SteakosaurusBurgerCustomize : Page
    {
        private bool i;
        /// <summary>
        /// constructs anew instance of this class
        /// </summary>
        public SteakosaurusBurgerCustomize()
        {
            InitializeComponent();
            i = false;
        }
        SteakosaurusBurger s = new SteakosaurusBurger();
        /// <summary>
        /// constructs anew instance of this class
        /// </summary>
        /// <param name="s"></param>
        public SteakosaurusBurgerCustomize(SteakosaurusBurger s)
        {
            InitializeComponent();
            this.s = s;
            i = true;
        }
        /// <summary>
        /// when the HoldPickel button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPickel_Click(object sender, RoutedEventArgs e)
        {
           this.s.HoldPickle();
        }
        /// <summary>
        /// when the HoldKetchup button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldKetchup_Click(object sender, RoutedEventArgs e)
        {
            this.s.HoldKetchup();

        }
        /// <summary>
        /// when the HoldMustard button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldMustard_Click(object sender, RoutedEventArgs e)
        {
            this.s.HoldMustard();
        }
        /// <summary>
        /// when the HoldPattie button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPattie_Click(object sender, RoutedEventArgs e)
        {
            this.s.HoldPattie();
        }
        /// <summary>
        /// when the HoldBun button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldBun_Click(object sender, RoutedEventArgs e)
        {
           this.s.HoldBun();
        }
        /// <summary>
        /// when the Done button clicked
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
        /// <summary>
        /// when the HoldPeppers button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPeppers_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
