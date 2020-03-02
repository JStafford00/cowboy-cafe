using System;
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
using CowboyCafe.Data;

namespace PointOfSale
{
    /*
     * Author: Jordan Stafford
     * Class: MenuItemSelectionControl
     * Purpose: All the buttons for adding items to the order.
     */
    public partial class MenuItemSelectionControl : UserControl
    {

        /// <summary>
        /// Initializes MenuItemSelectionControl
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Click action for Cowpoke Chili button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            var entree = new CowpokeChili();

            if(DataContext is Order data)
            {
                data.Add(entree);
            }
            
        }

        /// <summary>
        /// Click action for Rusler's Ribs button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            var entree = new RustlersRibs();

            if(DataContext is Order data)
            {
                data.Add(entree);
            }
        }

        /// <summary>
        /// Click action for Pecos Pulled Pork button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            var entree = new PecosPulledPork();

            if(DataContext is Order data)
            {
                data.Add(entree);
            }
        }

        /// <summary>
        /// Click action for Trail Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            var entree = new TrailBurger();

            if(DataContext is Order data)
            {
                data.Add(entree);
            }
        }

        /// <summary>
        /// Click action for Dakota Double Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            var entree = new DakotaDoubleBurger();

            if(DataContext is Order data)
            {
                data.Add(entree);
            }
        }

        /// <summary>
        /// Click action for Texas Triple Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {

            var entree = new TexasTripleBurger();

            if(DataContext is Order data)
            {
                data.Add(entree);
            }
        }

        /// <summary>
        /// Click action for Angry Chicken button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {

            var entree = new AngryChicken();

            if(DataContext is Order data)
            {
                data.Add(entree);
            }
        }

        /// <summary>
        /// Click action for Chili Cheese Fries button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            var side = new ChiliCheeseFries();

            if(DataContext is Order data)
            {
                data.Add(side);
            }
        }

        /// <summary>
        /// Click action for Corn Dodgers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            var side = new CornDodgers();

            if(DataContext is Order data)
            {
                data.Add(side);
            }
        }

        /// <summary>
        /// Click action for Pan De Campo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            var side = new PanDeCampo();

            if(DataContext is Order data)
            {
                data.Add(side);
            }
        }

        /// <summary>
        /// Click action for Baked Beans button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            var side = new BakedBeans();

            if(DataContext is Order data)
            {
                data.Add(side);
            }
        }

        /// <summary>
        /// Click action for Jerked Sods button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            var drink = new JerkedSoda();

            if(DataContext is Order data)
            {
                data.Add(drink);
            }
        }

        /// <summary>
        /// Click action for Texas Tea button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            var drink = new TexasTea();

            if(DataContext is Order data)
            {
                data.Add(drink);
            }
        }

        /// <summary>
        /// Click action for Cowboy Coffee button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            var drink = new CowboyCoffee();

            if(DataContext is Order data)
            {
                data.Add(drink);
            }
        }

        /// <summary>
        /// Click action for water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            var drink = new Water();

            if(DataContext is Order data)
            {
                data.Add(drink);
            }
        }
    }
}
