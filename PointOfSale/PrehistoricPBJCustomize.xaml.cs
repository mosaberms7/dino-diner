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
    /// Interaction logic for PrehistoricPBJCustomize.xaml
    /// </summary>
    public partial class PrehistoricPBJCustomize : Page
    {
        private bool i;
        /// <summary>
        /// constructs anew instance of this class
        /// </summary>
        public PrehistoricPBJCustomize()
        {
            InitializeComponent();
            i = false;
        }
        PrehistoricPBJ p = new PrehistoricPBJ();
        /// <summary>
        /// constructs anew instance of this class
        /// </summary>
        /// <param name="p"></param>
        public PrehistoricPBJCustomize(PrehistoricPBJ p)
        {
            InitializeComponent();
            this.p = p;
            i = true;
        }
        /// <summary>
        /// when the HoldJelly button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldJelly_Click(object sender, RoutedEventArgs e)
        {
          this.p.HoldJelly();

        }
        /// <summary>
        /// when the HoldButter button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldButter_Click(object sender, RoutedEventArgs e)
        {
          this.p.HoldPeanutButter();
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
    }
}
