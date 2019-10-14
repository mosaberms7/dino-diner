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
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }






        private void Create_drink_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());

        }

        private void Side_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection3());

        }

        private void Create_entree_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreeSelection());

        }

        private void Combo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboSelection());

        }
    }
}