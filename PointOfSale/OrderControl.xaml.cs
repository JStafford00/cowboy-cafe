﻿using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Cowpoke Chili");
        }

        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Rustler's Ribs");
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Pecos Pulled Pork");
        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Trail Burger");
        }

        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Dakota Double Burger");
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Texas Triple Burger");
        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Angry Chicken");
        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Chili Cheese Fries");
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Corn Dodgers");
        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Pan de Campo");
        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Baked Beans");
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Jerked Soda");
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Texas Tea");
        }

        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Cowboy Coffee");
        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add("Water");
        }
    }
}
