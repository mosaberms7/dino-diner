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
    /// Interaction logic for BrontowurstCustomize.xaml
    /// </summary>
    public partial class BrontowurstCustomize : Page
    {
        /// <summary>
        /// construct a new instance of this class
        /// </summary>
        private bool i { get; set; }
        public BrontowurstCustomize()
        {
              i = false;
            InitializeComponent();
            this.ShowsNavigationUI = false;
         

        }
        Brontowurst p = new Brontowurst();
        /// <summary>
        /// constructs anew instance of this class
        /// </summary>
        /// <param name="p"></param>
        public BrontowurstCustomize(Brontowurst p)
        {
            i = true;
            InitializeComponent();
            this.p = p;
            this.ShowsNavigationUI = false;
           
        }
        /// <summary>
        /// when the HoldPeppers button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldPeppers_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Entree entree)
                {
                    
                this.p.HoldPeppers();
                }
            }
           
        }
        /// <summary>
        /// when the HoldOnion button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldOnion_Click(object sender, RoutedEventArgs e)
        {
            this.p.HoldOnion();
        }
        /// <summary>
        /// when the HoldBun button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldBun_Click(object sender, RoutedEventArgs e)
        {
            this.p.HoldBun();
        }


        /// <summary>
        /// when the Done button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done_Click(object sender, RoutedEventArgs e)
        {
            if(i)
            NavigationService.Navigate(new CustomizeCombo());
            if(i==false)
                NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
