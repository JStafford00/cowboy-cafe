using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /*
     * Author: Jordan Stafford
     * Class: TrailBurger.cs
     * Purpose: To hold information on the Trail Burger Entree
     */
    public class TrailBurger : Entree
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool cheese = true;
        private bool mustard = true;
        private bool pickle = true;
        private string itemType = "Trail Burger";

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
        /// Price of a Trailburger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// Calories in a Trailburger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// Returns the name to string
        /// </summary>
        public override string Name
        {
            get
            {
                return "Trail Burger";
            }
        }

        /// <summary>
        /// If a bun is included.
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                bun = value;
                NotifyOfPropertyChange("Bun");
            }
        }

        /// <summary>
        /// If cheese is included
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }

            set
            {
                cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }

        /// <summary>
        /// If ketchup is included.
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }

            set
            {
                ketchup = value;
                NotifyOfPropertyChange("Ketchup");
            }
        }

        /// <summary>
        /// If mustard is included.
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }

            set
            {
                mustard = value;
                NotifyOfPropertyChange("Mustard");
            }
        }

        /// <summary>
        /// If pickles are included.
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }

            set
            {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }



        /// <summary>
        /// Special Instructions 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bun)
                    instructions.Add("hold bun");
                if (!cheese)
                    instructions.Add("hold cheese");
                if (!mustard)
                    instructions.Add("hold mustard");
                if (!pickle)
                    instructions.Add("hold pickle");
                if (!ketchup)
                    instructions.Add("hold ketchup");

                return instructions;
            }
        }
    }
}
