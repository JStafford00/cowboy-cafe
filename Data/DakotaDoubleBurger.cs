using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /*
     * Author: Jordan Stafford
     * Class: DakotaDoubleBurger.cs
     * Purpose: To hold information on the Dakota Double Burger Entree
     */
    public class DakotaDoubleBurger : Entree
    {
        private bool bun = true;
        private bool ketchup = true;
        private bool cheese = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool mayo = true;
        private bool lettuce = true;
        private bool tomato = true;


        /// <summary>
        /// Price of a Dakota Double
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// Calories in a Dakota Double
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// If a bun is included.
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                bun = value;
            }
        }

        /// <summary>
        /// If cheese is included
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }

            set
            {
                cheese = value;
            }
        }

        /// <summary>
        /// If ketchup is included.
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }

            set
            {
                ketchup = value;
            }
        }

        /// <summary>
        /// If mustard is included.
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }

            set
            {
                mustard = value;
            }
        }

        /// <summary>
        /// If pickles are included.
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
        /// If mayo is included.
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }

            set
            {
                mayo = value;
            }
        }

        /// <summary>
        /// If lettuce is included.
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }

            set
            {
                lettuce = value;
            }
        }

        /// <summary>
        /// If tomato is included.
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }

            set
            {
                tomato = value;
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

                if (!bun)
                    instructions.Add("hold bun");
                if (!cheese)
                    instructions.Add("hold cheese");
                if (!mustard)
                    instructions.Add("hold mustard");
                if (!pickle)
                    instructions.Add("hold pickle");
                if (!ketchup)
                    instructions.Add("hold ketchup");
                if (!mayo)
                    instructions.Add("hold mayo");
                if (!lettuce)
                    instructions.Add("hold lettuce");
                if (!tomato)
                    instructions.Add("hold tomato");

                return instructions;
            }
        }
    }
}
