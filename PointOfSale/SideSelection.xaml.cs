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

        /// <summary>
        /// constructs anew instance of the side page
        /// </summary>
        public SideSelection3()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
            this.DataContext = this;

        }

        private void SMALL_Click(object sender, RoutedEventArgs e)
        {
            Size = DinoDiner.Menu.Size.Small;

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Small;
                }
            }
        }

        private void Meduimsize_Click(object sender, RoutedEventArgs e)
        {
            Size = DinoDiner.Menu.Size.Medium;

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Medium;
                }
            }

        }

        private void Largesize_Click(object sender, RoutedEventArgs e)
        {
            Size = DinoDiner.Menu.Size.Large;

            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    side.Size = DinoDiner.Menu.Size.Large;
                }
            }
        }

        private void Metrozellachesse_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new MeteorMacAndCheese());
 
        }

        private void Metorcheese_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new MezzorellaSticks());
        }

        private void Frys_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new Fryceritops());
        }

        private void Tri_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new Triceritots());

        }

        /// <summary>
        /// Adds the passed in side to the order.
        /// </summary>
        /// <param name="side">The side to add to the order.</param>
        private void AddItem(Side side)
        {
            if (DataContext is Order order)
            {
                side.Size = Size;
                order.Items.Add(side);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }

    }
}
