using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public static class Menu
    {
        /// <summary>
        /// All Cowboy Cafe Entrees
        /// </summary>
        /// <returns>All Entres</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            Order entrees = new Order();
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new TrailBurger());

            return entrees.Items;

        }

        /// <summary>
        /// All Cowboy Cafe Sides
        /// </summary>
        /// <returns>All Sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            Order sides = new Order();
            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());

            return sides.Items;
        }

        /// <summary>
        /// All Cowboy Cafe Drinks
        /// </summary>
        /// <returns>All Drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            Order drinks = new Order();
            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());

            return drinks.Items;
        }

        /// <summary>
        /// Complete Cowboy Cafe Menu
        /// </summary>
        /// <returns>The complete menu</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            Order menu = new Order();
            menu.Add(new AngryChicken());
            menu.Add(new CowpokeChili());
            menu.Add(new DakotaDoubleBurger());
            menu.Add(new PecosPulledPork());
            menu.Add(new RustlersRibs());
            menu.Add(new TexasTripleBurger());
            menu.Add(new TrailBurger());
            menu.Add(new BakedBeans());
            menu.Add(new ChiliCheeseFries());
            menu.Add(new CornDodgers());
            menu.Add(new PanDeCampo());
            menu.Add(new CowboyCoffee());
            menu.Add(new JerkedSoda());
            menu.Add(new TexasTea());
            menu.Add(new Water());

            return menu.Items;
        }
    }
}
