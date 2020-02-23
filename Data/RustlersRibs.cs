using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /*
     * Author: Jordan Stafford
     * Class: RustlerRibs.cs
     * Purpose: To hold information on the Rustler Ribs Entree
     */
    public class RustlersRibs : Entree
    {
        /// <summary>
        /// Price of Rustler Ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// Calories in a Rustler Ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        public override string Name
        {
            get
            {
                return "Rustler's Ribs";
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

                return instructions;
            }
        }
    }
}
