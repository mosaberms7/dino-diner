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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private Entree entree { get; }
        public DinoDiner.Menu.Size Size { get; private set; }

        /// <summary>
        /// construct a new instance of thiks class
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();
        }
        /// <summary>
        /// when the side button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Side_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection3());

        }
        /// <summary>
        /// when the Drink button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Create_Drink2_Click(object sender, RoutedEventArgs e)
        {
           
            NavigationService.Navigate(new DrinkSelection());


        }
        /// <summary>
        /// when the small size button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Small_Click(object sender, RoutedEventArgs e)
        {
            Size = DinoDiner.Menu.Size.Small;
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Size = DinoDiner.Menu.Size.Small;
                }

            }
        }
        /// <summary>
        /// when the meduim size button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Meduimcombo_Click(object sender, RoutedEventArgs e)
        {
            Size = DinoDiner.Menu.Size.Medium;
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Size = DinoDiner.Menu.Size.Medium;
                }

            }
        }
        /// <summary>
        /// when the Large size button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeCombo_Click(object sender, RoutedEventArgs e)
        {
            Size = DinoDiner.Menu.Size.Large;
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Size = DinoDiner.Menu.Size.Large;
                }

            }
        }
    }
}
