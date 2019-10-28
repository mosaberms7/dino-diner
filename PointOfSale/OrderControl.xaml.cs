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
        public NavigationService navigationService { get; set; }
        public NavigationService navigation;
        public OrderControl()
        {
            InitializeComponent();
        }

     

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                order.Items.Clear();
            }

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            IOrderItem item = b.Tag as IOrderItem;

            if (DataContext is Order order && item != null)
            {


                order.Items.Remove(item);
            }
        }


      
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
    }

