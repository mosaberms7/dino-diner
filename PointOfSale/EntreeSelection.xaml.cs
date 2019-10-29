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
    /// Interaction logic for MenuCategorySelection2.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// constructs a new page of the entree selection 
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
            this.DataContext = this;
        }
        /// <summary>
        /// when the browntrust is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hotdog_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new Brontowurst());
            NavigationService.Navigate(new MenuCategorySelection());

        }
        /// <summary>
        /// when the Dino nuggets is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Nuggets_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new DinoNuggets());
            NavigationService.Navigate(new MenuCategorySelection());

        }
        /// <summary>
        /// when the trex is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Trex_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new TRexKingBurger());
            NavigationService.Navigate(new MenuCategorySelection());

        }
        /// <summary>
        /// when the steakburger is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Steakburger_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new SteakosaurusBurger());
            NavigationService.Navigate(new MenuCategorySelection());

        }
        /// <summary>
        /// when the Wings is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wings_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new PterodactylWings());
            NavigationService.Navigate(new MenuCategorySelection());

        }
        /// <summary>
        /// when the pbj is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pbj_Click(object sender, RoutedEventArgs e)
        {
          //the class work 10/28  
            if (DataContext is Order order)
            {
                PrehistoricPBJ pbj = new PrehistoricPBJ();
                AddItem(pbj);
                NavigationService.Navigate(new customoizepbj(pbj));
            }


        }
        /// <summary>
        /// when the wrap is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Wrap_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new VelociWrap());
            NavigationService.Navigate(new MenuCategorySelection());



        }
        /// <summary>
        /// add entree to the order items
        /// </summary>
        /// <param name="entree"></param>
        private void AddItem(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.addItems(entree);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
    }
}
