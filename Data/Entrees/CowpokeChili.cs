using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /*
     * Author: Jordan Stafford
     * Class: CowpokeChili.cs
     * Purpose: To hold information on the Cowpoke Chili Entree
     */
    public class CowpokeChili : Entree
    {

        private bool cheese = true;
        private bool sourCream = true;
        private bool greenOnions = true;
        private bool tortillaStrips = true;
        private string itemType = "Cowpoke Chili";

        /// <summary>
        /// Item Type for this certain item
        /// </summary>
        public override string ItemType
        {
            get
            {
                return itemType;
            }
        }

        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set 
            { 
                cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }

        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream
        {
            get { return sourCream; }
            set 
            { 
                sourCream = value;
                NotifyOfPropertyChange("SourCream");
            }
        }

        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions
        {
            get { return greenOnions; }
            set 
            { 
                greenOnions = value;
                NotifyOfPropertyChange("GreenOnions");
            }
        }

        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips
        {
            get 
            { 
                return tortillaStrips; 
            }
            set 
            { 
                tortillaStrips = value;
                NotifyOfPropertyChange("TortillaStrips");
            }
        }

        /// <summary>
        /// The price of the chili
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Returns the name to string
        /// </summary>
        public override string Name
        {
            get
            {
                return "Cowpoke Chili";
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese)
                    instructions.Add("hold cheese");
                if (!sourCream)
                    instructions.Add("hold sour cream");
                if (!greenOnions)
                    instructions.Add("hold green onions");
                if (!tortillaStrips)
                    instructions.Add("hold tortilla strips");

                return instructions;
            }
        }

        
    }
}

