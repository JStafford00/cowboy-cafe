using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree
    {
        /// <summary>
        /// Price of a entree.
        /// </summary>
        public abstract double Price { get; set; }

        /// <summary>
        /// Calories in the entree.
        /// </summary>
        public abstract uint Calories { get; set; }

        /// <summary>
        /// Special Instructions for the entree.
        /// </summary>
        public abstract List<String> SpecialInstructions { get; set; }
    }
}
