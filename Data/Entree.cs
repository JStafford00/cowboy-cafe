using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /*
     * Author: Nathan Bean
     * Edited By: Jordan Stafford
     * Class: Entree.cs
     * Purpose: Entree Abstract Class
     */
    public abstract class Entree
    {

        /// <summary>
        /// Price of a entree.
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Calories in the entree.
        /// </summary>
        public abstract uint Calories { get; }

        public abstract string Name
        {
            get;
        }

        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Special Instructions for the entree.
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }
    }
}
