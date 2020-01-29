using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTriple
    {
        private bool bacon = true;
        private bool egg = true;

        /// <summary>
        /// Price of a Texas Triple
        /// </summary>
        public double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// Calories in a Texas Triple
        /// </summary>
        public uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// If bacon is on a Texas Triple
        /// </summary>
        public bool Bacon
        {
            get
            {
                return bacon;
            }

            set
            {
                bacon = value;
            }
        }

        /// <summary>
        /// If egg is on your Texas Triple
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }

            set
            {
                egg = value;
            }
        }

        /// <summary>
        /// Special Instructions 
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bacon)
                    instructions.Add("hold bacon");
                if (!egg)
                    instructions.Add("hold egg");

                return instructions;
            }
        }
    }
}
