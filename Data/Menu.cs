using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;

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

        /// <summary>
        /// Searches for items that contain the terms
        /// </summary>
        /// <param name="terms">terms being searched for</param>
        /// <returns>List of items that contain the terms</returns>
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            IEnumerable<IOrderItem> items = CompleteMenu();

            if(terms == null)
                return items;

            foreach(IOrderItem item in items)
            {
                if(item.ItemType.Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }

            return results;
        }

        public static string[] ItemTypes
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }

        public static IEnumerable<IOrderItem> FilterByItemType(IEnumerable<IOrderItem> items, IEnumerable<string> types)
        {
            if(types == null || types.Count() == 0)
                return items;

            List<IOrderItem> results = new List<IOrderItem>();

            if(types.Contains("Entree"))
            {
                foreach(CowboyCafe.Data.Entree entree in items.OfType<CowboyCafe.Data.Entree>())
                {
                    results.Add(entree);
                }
            }

            if(types.Contains("Side"))
            {
                foreach(CowboyCafe.Data.Side side in items.OfType<CowboyCafe.Data.Side>())
                {
                    results.Add(side);
                }
            }

            if(types.Contains("Drink"))
            {
                foreach(CowboyCafe.Data.Drink drink in items.OfType<CowboyCafe.Data.Drink>())
                {
                    results.Add(drink);
                }
            }

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, string calMin, string calMax)
        {
            int min = 0;
            int max = 1000;
            List<IOrderItem> results = new List<IOrderItem>();

            try
            {
                min = Int32.Parse(calMin);
            }

            catch
            {
                
            }

            try
            {
                max = Int32.Parse(calMax);
            }

            catch
            {

            }

            foreach(CowboyCafe.Data.Entree entree in items.OfType<CowboyCafe.Data.Entree>())
            {
                if(entree.Calories >= min && entree.Calories <= max)
                    results.Add(entree);
            }

            foreach(CowboyCafe.Data.Side side in items.OfType<CowboyCafe.Data.Side>())
            {
                if(side.Calories >= min && side.Calories <= max)
                    results.Add(side);
            }

            foreach(CowboyCafe.Data.Drink drink in items.OfType<CowboyCafe.Data.Drink>())
            {
                if(drink.Calories >= min && drink.Calories <= max)
                    results.Add(drink);
            }

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, string priceMin, string priceMax)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            double min = 0;
            double max = 20;

            try
            {
                min = Double.Parse(priceMin);
            }

            catch
            {

            }

            try
            {
                max = Double.Parse(priceMax);
            }

            catch
            {

            }

            foreach(IOrderItem item in items)
            {
                if(item.Price >= min && item.Price <= max)
                    results.Add(item);
            }

            return results;
        }
    }
}
