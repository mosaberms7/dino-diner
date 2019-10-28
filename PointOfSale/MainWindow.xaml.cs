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
            OrderInterface.Navigate(new MenuCategorySelection());
            Order.NavigationService = OrderInterface.NavigationService;
           


        }
       
        /// <summary>
        /// The method that handles passing down the DataContext through the pages.
        /// </summary>
        private void PassOnDataContext()
        {
            setFrameDataContext();
        }
        public void OnLoadComplete(object sender,NavigationService navigationService)
        {
            setFrameDataContext();
        }


        private void OrderControl_Loaded(object sender, RoutedEventArgs e)
        {
            setFrameDataContext();

        }
        /// <summary>
        /// Passes on the DataContext if the current DataContext is changed.
        /// </summary>
        /// <param name="sender">The sender object.</param>
        /// <param name="args">The DependencyPropertyChangedEventArgs tied to this event.</param>
        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            setFrameDataContext();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            OrderInterface.NavigationService.Navigate(new MenuCategorySelection());

        }

        private void setFrameDataContext()
        {
            var content = OrderInterface.Content as FrameworkElement;
            if (content == null)
                return;
            content.DataContext = OrderInterface.DataContext;

        }
       
        private void OrderInterface_LoadCompleted_1(object sender, NavigationEventArgs e)
        {
            setFrameDataContext();

        }
    }
}
