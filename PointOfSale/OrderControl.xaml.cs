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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Initializes Component
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }

        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            var entree = new CowpokeChili();

            OrderList.Items.Add(entree);
        }

        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            var entree = new RustlersRibs();

            OrderList.Items.Add(entree);
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            var entree = new PecosPulledPork();

            OrderList.Items.Add(entree);
        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            var entree = new TrailBurger();

            OrderList.Items.Add(entree);
        }

        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            var entree = new DakotaDoubleBurger();

            OrderList.Items.Add(entree);
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {

            var entree = new TexasTripleBurger();

            OrderList.Items.Add(entree);
        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {

            var entree = new AngryChicken();

            OrderList.Items.Add(entree);
        }

        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            var side = new ChiliCheeseFries();

            OrderList.Items.Add(side);
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            var side = new CornDodgers();

            OrderList.Items.Add(side);
        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            var side = new PanDeCampo();

            OrderList.Items.Add(side);
        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            var side = new BakedBeans();

            OrderList.Items.Add(side);
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            var drink = new JerkedSoda();

            OrderList.Items.Add(drink);
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            var drink = new TexasTea();

            OrderList.Items.Add(drink);
        }

        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            var drink = new CowboyCoffee();

            OrderList.Items.Add(drink);
        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            var drink = new Water();

            OrderList.Items.Add(drink);
        }
    }
}
