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
    /// Interaction logic for TRexBurgerCustomize.xaml
    /// </summary>
    public partial class TRexBurgerCustomize : Page
    {
        private bool i;
        /// <summary>
        /// constructs a new instance of this class
        /// </summary>
        public TRexBurgerCustomize()
        {
            InitializeComponent();
            i = false;
        }
        TRexKingBurger t = new TRexKingBurger();
        /// <summary>
        /// constructs a new instance of this class
        /// </summary>
        /// <param name="t"></param>
        public TRexBurgerCustomize(TRexKingBurger t)
        {
            InitializeComponent();
            this.t = t;
            i = true;
        }
        /// <summary>
        /// when the HoldOnion button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldOnion_Click(object sender, RoutedEventArgs e)
        {
            t.HoldOnion();
        }
        /// <summary>
        /// when the HoldMayo button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldMayo_Click(object sender, RoutedEventArgs e)
        {
            t.HoldMayo();
        }
        /// <summary>
        /// when the HoldTomato button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldTomato_Click(object sender, RoutedEventArgs e)
        {
            t.HoldTomato();
        }

        /// <summary>
        /// when the HoldPickel button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void HoldPickel_Click(object sender, RoutedEventArgs e)
        {
            t.HoldPickle();
        }
        /// <summary>
        /// when the HoldKetchup button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldKetchup_Click(object sender, RoutedEventArgs e)
        {
            t.HoldKetchup();
        }
        /// <summary>
        /// when the HoldMustard button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldMustard_Click(object sender, RoutedEventArgs e)
        {
            t.HoldMustard();
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
        /// <summary>
        /// when the HoldBun button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldBun_Click(object sender, RoutedEventArgs e)
        {
            t.HoldBun();
        }
    }
}
