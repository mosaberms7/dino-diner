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
        public EntreeSelection()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
            this.DataContext = this;
        }

        private void Hotdog_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new Brontowurst());
            NavigationService.Navigate(new MenuCategorySelection());

        }

        private void Nuggets_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new DinoNuggets());
            NavigationService.Navigate(new MenuCategorySelection());

        }

        private void Trex_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new TRexKingBurger());
            NavigationService.Navigate(new MenuCategorySelection());

        }

        private void Steakburger_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new SteakosaurusBurger());
            NavigationService.Navigate(new MenuCategorySelection());

        }

        private void Wings_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new PterodactylWings());
            NavigationService.Navigate(new MenuCategorySelection());

        }

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

        private void Wrap_Click(object sender, RoutedEventArgs e)
        {
            AddItem(new VelociWrap());
            NavigationService.Navigate(new MenuCategorySelection());



        }
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
