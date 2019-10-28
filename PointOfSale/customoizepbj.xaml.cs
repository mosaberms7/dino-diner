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
    /// Interaction logic for customoizepbj.xaml
    /// </summary>
    public partial class customoizepbj : Page
    {
       protected PrehistoricPBJ pbj = new PrehistoricPBJ();

        public customoizepbj(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            this.pbj = pbj;
        }

        private void Pb_Click(object sender, RoutedEventArgs e)
        {
            this.pbj.HoldPeanutButter();
        }

        private void Holdjelly_Click(object sender, RoutedEventArgs e)
        {
            this.pbj.HoldJelly();
        }

        private void Ondone_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
