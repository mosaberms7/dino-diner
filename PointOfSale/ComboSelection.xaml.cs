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
    /// Interaction logic for ComboSelection2.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// constructs an ew instance of ComboSelection
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();
            this.ShowsNavigationUI = false;
        }




        /// <summary>
        /// click event handler for trex choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void TRex_King_BurgerC_Click(object sender, RoutedEventArgs e)
        {
            TRexKingBurger t = new TRexKingBurger();
            CretaceousCombo cc = new CretaceousCombo(t);
            AddItem(cc);
            NavigationService.Navigate(new TRexBurgerCustomize());

        }
        /// <summary>
        /// click event handler for pbj
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void PB_AND_J_Click(object sender, RoutedEventArgs e)
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            CretaceousCombo cc = new CretaceousCombo(pbj);
            AddItem(cc);
            NavigationService.Navigate(new PrehistoricPBJCustomize());

        }
        /// <summary>
        /// click event handler for steak burger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void Steakosarus_Burger_Click(object sender, RoutedEventArgs e)
        {
            SteakosaurusBurger s = new SteakosaurusBurger();
            CretaceousCombo cc = new CretaceousCombo(s);
            AddItem(cc);

            NavigationService.Navigate(new SteakosaurusBurgerCustomize());

        }
        /// <summary>
        /// click event handler for the nuggets 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void DIno_Nuggets_Click(object sender, RoutedEventArgs e)
        {
            DinoNuggets d = new DinoNuggets();
            CretaceousCombo cc = new CretaceousCombo(d);
            AddItem(cc);
            NavigationService.Navigate(new DinoNuggetsCustomize());

        }
        /// <summary>
        /// click event handler fot the wrap
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void Create_Veloci_Wrap_Click(object sender, RoutedEventArgs e)
        {
            VelociWrap v = new VelociWrap();
            CretaceousCombo cc = new CretaceousCombo(v);
            AddItem(cc);
            NavigationService.Navigate(new WrapCustomize());

        }
        /// <summary>
        /// click event handler for the wings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Create_Pterodactyl_Wing_Click(object sender, RoutedEventArgs e)
        {
            PterodactylWings p = new PterodactylWings();
            CretaceousCombo cc = new CretaceousCombo(p);
            AddItem(cc);
            NavigationService.Navigate(new CustomizeCombo());

        }
        /// <summary>
        /// click event handler for the bronwrust
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Create_BrontowurstC_Click(object sender, RoutedEventArgs e)
        {
            Brontowurst b = new Brontowurst();
            CretaceousCombo cc = new CretaceousCombo(b);
            AddItem(cc);
            NavigationService.Navigate(new BrontowurstCustomize());

        }
        /// <summary>
        /// adds a new item to the order
        /// </summary>
        /// <param name="combo"></param>
        private void AddItem(CretaceousCombo combo)
        {
            if (DataContext is Order order)
            {
                order.addItems(combo);
                CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
            }
        }
    }
}
