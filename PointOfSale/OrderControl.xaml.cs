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
    /// Interaction logic for OrderList.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public NavigationService NavigationService { get; set; }

        public OrderControl()
        {
            InitializeComponent();
        }

     

      
        /// <summary>
        /// remove the item from th elist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            IOrderItem item = b.Tag as IOrderItem;

            if (DataContext is Order order && item != null)
            {


                order.removeItems(item);
            }
        }


      
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void UxListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (uxListBox.SelectedItem is Side side) {

                //make aconstrurtor taking 
                NavigationService?.Navigate(new SideSelection3(side));


            }
            if (uxListBox.SelectedItem is Drink drink)
            {

                //make aconstrurtor taking 
                NavigationService?.Navigate(new DrinkSelection(drink));


            }
        }
    }
    }

