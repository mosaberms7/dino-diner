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
    /// Interaction logic for FlavorSelection2.xaml
    /// </summary>
    public partial class FlavorSelection2 : Page
    {
        public FlavorSelection2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// make the cofee decaf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decaf_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is JurassicJava jurassic)
                    {
                        jurassic.notdecaf(); 
                    }

                }
            }
        }
        /// <summary>
        /// add sweet to the cofee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sweet_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (drink is JurassicJava jurassic)
                    {
                        jurassic.addsweet() ;                    }

                }
            }
        }

      
        /// <summary>
        /// back to preivious page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back2_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }
    }
}
