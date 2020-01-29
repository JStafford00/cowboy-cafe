using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken
    {

        private bool bread = true;
        private bool pickle = true;

        public double Price
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
        public uint Calories
        {
            get
            {
                return 190;
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
            }
        }

        /// <summary>
        /// Special instructions for the making of an Angry Chicken
        /// </summary>
        public List<string> SpecialInstructions
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
