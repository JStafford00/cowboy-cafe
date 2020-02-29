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
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            var entree = new CowpokeChili();

            
        }

        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            var entree = new RustlersRibs();

        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            var entree = new PecosPulledPork();

            
        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            var entree = new TrailBurger();

            
        }

        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            var entree = new DakotaDoubleBurger();

            
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {

            var entree = new TexasTripleBurger();

            
        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {

            var entree = new AngryChicken();

            
        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            var side = new ChiliCheeseFries();

            
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            var side = new CornDodgers();

            
        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            var side = new PanDeCampo();

            
        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            var side = new BakedBeans();

           
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            var drink = new JerkedSoda();

            
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            var drink = new TexasTea();

            
        }

        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            var drink = new CowboyCoffee();

            
        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            var drink = new Water();

            
        }
    }
}
