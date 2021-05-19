using System.Collections.Generic;

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
        private string itemType = "Dakota Double Burger";

        /// <summary>
        /// Item Type for this certain item
        /// </summary>
        public override string ItemType
        {
            get
            {
                return itemType;
            }
        }

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
        /// Returns the name to string
        /// </summary>
        public override string Name
        {
            get
            {
                return "Dakota Double Burger";
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
                NotifyOfPropertyChange("Bun");
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
                NotifyOfPropertyChange("Cheese");
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
                NotifyOfPropertyChange("Ketchup");
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
                NotifyOfPropertyChange("Mustard");
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
                NotifyOfPropertyChange("Pickle");
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
                NotifyOfPropertyChange("Mayo");
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
                NotifyOfPropertyChange("Lettuce");
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
                NotifyOfPropertyChange("Tomato");
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
