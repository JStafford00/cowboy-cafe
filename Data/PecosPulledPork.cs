using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
    {
        private bool bread = true;
        private bool pickle = true;

        /// <summary>
        /// Price of a Pecos Pulled Pork.
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// Calories in a Pecos Pulled Pork.
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
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
            }
        }

        /// <summary>
        /// Special instructions for the making of an Pacos Pulled Pork
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
