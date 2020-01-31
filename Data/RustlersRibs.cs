using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class RustlersRibs
    {
        /// <summary>
        /// Price of Rustler Ribs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// Calories in a Rustler Ribs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
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

                return instructions;
            }
        }
    }
}
