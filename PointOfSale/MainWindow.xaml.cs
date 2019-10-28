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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*       Order order = new Order();
                   OrderInterFace
                   order.items.add(new PrehistoricPBJ());
                   order.Navigationservice = OrderInterface.NavigationService;  
               */
//            OrderControl.uxListBox.SelectionChanged += SelectedItemChanged;


        }
       
        /// <summary>
        /// The method that handles passing down the DataContext through the pages.
        /// </summary>
        private void PassOnDataContext()
        {
            if (OrderUI.Content is Page page)  
            {
                page.DataContext = OrderUI.DataContext;

            }
        }
        public void OnLoadComplete(object sender,NavigationService navigationService)
        {
            PassOnDataContext();

        }


        private void OrderControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// Passes on the DataContext if the current DataContext is changed.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="args">The DependencyPropertyChangedEventArgs tied to this event.</param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            PassOnDataContext();
        }

    }
}
