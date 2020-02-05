using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /*
     * Author: Jordan Stafford
     * Class: TexasTripleBurger.cs
     * Purpose: To hold information on the Texas Triple Burger Entree
     */
    public class TexasTripleBurger : Entree
    {
        private bool bun = true;
        private bool bacon = true;
        private bool egg = true;
        private bool ketchup = true;
        private bool lettuce = true;
        private bool tomato = true;
        private bool cheese = true;
        private bool mayo = true;
        private bool mustard = true;
        private bool pickle = true;


        /// <summary>
        /// Price of a Texas Triple
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// Calories in a Texas Triple
        /// </summary>
        public override uint Calories
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
        /// If a bun is on your Texas Triple
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
        /// If cheese is on your Texas Triple
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
        /// If ketchup is on your Texas Triple
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
        /// If lettuce is on your Texas Triple
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
        /// If mayo is on your Texas Triple
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
        /// If mustard is on your Texas Triple
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
        /// If tomato is on your Texas Triple
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
        /// If you want pickles on your Texas Triple
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
        /// Special Instructions 
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bacon)
                    instructions.Add("hold bacon");
                if (!egg)
                    instructions.Add("hold egg");
                if (!bun)
                    instructions.Add("hold bun");
                if (!cheese)
                    instructions.Add("hold cheese");
                if (!lettuce)
                    instructions.Add("hold lettuce");
                if (!mustard)
                    instructions.Add("hold mustard");
                if (!pickle)
                    instructions.Add("hold pickle");
                if (!ketchup)
                    instructions.Add("hold ketchup");
                if (!tomato)
                    instructions.Add("hold tomato");
                if (!mayo)
                    instructions.Add("hold mayo");

                return instructions;
            }
        }
    }
}
