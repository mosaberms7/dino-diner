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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection3 : Page
    {
        public DinoDiner.Menu.Size Size { get; private set; }
        public bool sidechoosen = false;
        public bool sizechoosen = false;


        /// <summary>
        /// constructs anew instance of the side page
        /// </summary>
        public SideSelection3()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
            this.DataContext = this;

        }
        /// <summary>
        /// chosse the Small size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SMALL_Click(object sender, RoutedEventArgs e)
        {
            sizechoosen = true;
            Size = DinoDiner.Menu.Size.Small;

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
            }
            if (sidechoosen)
                NavigationService.GoBack();
        }
        /// <summary>
        /// chosse the Med size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Meduimsize_Click(object sender, RoutedEventArgs e)
        {
            sizechoosen = true;

            Size = DinoDiner.Menu.Size.Medium;

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
            }
            if (sidechoosen)
                NavigationService.GoBack();
        }
        /// <summary>
        /// chosse the large size
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Largesize_Click(object sender, RoutedEventArgs e)
        {

            sizechoosen = true;

            Size = DinoDiner.Menu.Size.Large;

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
            }
            if (sidechoosen)
                NavigationService.GoBack();

        }
        /// <summary>
        /// add new side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Metrozellachesse_Click(object sender, RoutedEventArgs e)
        {
            sidechoosen = true;

            AddItem(new MeteorMacAndCheese());
            if (sizechoosen)
                NavigationService.GoBack();

        }
        /// <summary>
        /// add new side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Metorcheese_Click(object sender, RoutedEventArgs e)
        {
            sidechoosen = true;

            AddItem(new MezzorellaSticks());
            if (sizechoosen)
                NavigationService.GoBack();
        }
        /// <summary>
        /// add new side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frys_Click(object sender, RoutedEventArgs e)
        {
            sidechoosen = true;

            AddItem(new Fryceritops());
            if (sizechoosen)
                NavigationService.GoBack();
        }
        /// <summary>
        /// add new side to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tri_Click(object sender, RoutedEventArgs e)
        {
            sidechoosen = true;

            AddItem(new Triceritots());
            if (sizechoosen)
                NavigationService.GoBack();

        }

        /// <summary>
        /// Adds the side  to the order.
        /// </summary>
        /// <param name="side">The side to add to the order.</param>
        private void AddItem(Side side)
        {
            if (DataContext is Order order)
            {
                side.Size = Size;
                order.addItems(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

    }
}
