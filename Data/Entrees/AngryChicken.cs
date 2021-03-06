﻿using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /*
     * Author: Jordan Stafford
     * Class: AngryChicken
     * Purpose: To hold information on the Angry Chicken
     */
    public class AngryChicken : Entree
    {

        private bool bread = true;
        private bool pickle = true;
        private string itemType = "Angry Chicken";

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

        public override double Price
        {

            /// <summary>
            /// The price for an Angry Chicken
            /// </summary>
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calroies in an Angry Chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Returns the name to stringe
        /// </summary>
        public override string Name
        {
            get
            {
                return "Angry Chicken";
            }
        }

        /// <summary>
        /// If you want bread.
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
        /// If you want pickles on your Angry Chicken.
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
        /// Special instructions for the making of an Angry Chicken
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
