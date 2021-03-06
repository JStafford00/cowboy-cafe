﻿using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /*
     * Author: Jordan Stafford
     * Class: PecosPulledPork.cs
     * Purpose: To hold information on the Pecos Pulled Pork Entree
     */
    public class PecosPulledPork : Entree
    {
        private bool bread = true;
        private bool pickle = true;
        private string itemType = "Pecos Pulled Pork";

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
        /// Price of a Pecos Pulled Pork.
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// Calories in a Pecos Pulled Pork.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Returns the name to string
        /// </summary>
        public override string Name
        {
            get
            {
                return "Pecos Pulled Pork";
            }
        }

        /// <summary>
        /// If bread is included.
        /// </summary>
        public bool Bread
        {
            get
            {
                return bread;
            }

            set
            {
                bread = value;
                NotifyOfPropertyChange("Bread");
            }
        }

        /// <summary>
        /// If pickles are included;
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
        /// Special instructions for the making of an Pacos Pulled Pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread)
                    instructions.Add("hold bread");
                if (!pickle)
                    instructions.Add("hold pickle");


                return instructions;
            }
        }
    }
}
