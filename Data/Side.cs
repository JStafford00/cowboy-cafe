using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /*
     * Author: Nathan Bean
     * Edited By: Jordan Stafford
     * Class: Side.cs
     * Purpose: An abstract class for all the Sides
     */
    public abstract class Side : IOrderItem
    {

        public abstract string Name
        {
            get;
        }

        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get; set; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions for a Side
        /// </summary>
        public virtual List<string> SpecialInstructions
        {
            get;
        }

        /// <summary>
        /// Return the name of the side as a string
        /// </summary>
        /// <returns>Name of side</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
