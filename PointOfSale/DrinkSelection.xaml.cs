﻿using System;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
     /// <summary>
     /// construct a new instance of drinkn selection
     /// </summary>
     public DrinkSelection()
        {
            InitializeComponent();
        }


        /// <summary>
        /// click event handler 
        /// </summary> for the flavor
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Flavor_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
    }
}
