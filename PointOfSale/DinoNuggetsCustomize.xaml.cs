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
    /// Interaction logic for DinoNuggetsCustomize.xaml
    /// </summary>

    public partial class DinoNuggetsCustomize : Page
    {
        private bool i;
        /// <summary>
        /// construct a new instance of this class
        /// </summary>
        public DinoNuggetsCustomize()
        {
            InitializeComponent();
            i = false;
        }
        DinoNuggets d = new DinoNuggets();
        /// <summary>
        /// constructa a new instance of this class
        /// </summary>
        /// <param name="d"></param>
        public DinoNuggetsCustomize(DinoNuggets d)
        {
            InitializeComponent();
            this.d = d;
            i = true;
        }
        /// <summary>
        /// when the AddNuggets button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNuggets_Click(object sender, RoutedEventArgs e)
        {
            this.d.AddNugget();
        }
        /// <summary>
        /// when the Done button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Done_Click(object sender, RoutedEventArgs e)
        {

            if (i)
                NavigationService.Navigate(new CustomizeCombo());
            if (!i)
                NavigationService.Navigate(new MenuCategorySelection());
        }

       
    }
}
