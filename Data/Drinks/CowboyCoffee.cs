using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{

    /*
     * Author: Jordan Stafford
     * Class: CowboyCoffee
     * Purpose: Contains information on Cowboy Coffee.
     */
    public class CowboyCoffee : Drink
    {
        private bool ice = false;
        private bool roomForCream = false;
        private bool decaf;
        private string itemType = "Cowboy Coffee";

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
        /// Price override for a Cowboy Coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Calories override for a Cowboy Coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// If there is room for creamer.
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }

            set
            {
                roomForCream = value;
                NotifyOfPropertyChange("Room For Cream");
            }
        }

        /// <summary>
        /// If the coffee is decaf.
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }

            set
            {
                decaf = value;
                NotifyOfPropertyChange("Decaf");
            }
        }

        /// <summary>
        /// If ice is in the Cowboy coffee.
        /// </summary>
        public override bool Ice
        {
            get
            {
                return ice;
            }

            set
            {
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }

        /// <summary>
        /// Returns the name to string based on size
        /// </summary>
        public override string Name
        {
            get
            {
                if(!decaf)
                {
                    switch(Size)
                    {
                        case Size.Small:
                            return "Small Cowboy Coffee";
                        case Size.Medium:
                            return "Medium Cowboy Coffee";
                        case Size.Large:
                            return "Large Cowboy Coffee";
                        default:
                            throw new NotImplementedException();
                    }
                }

                else
                {
                    switch(Size)
                    {
                        case Size.Small:
                            return "Small Decaf Cowboy Coffee";
                        case Size.Medium:
                            return "Medium Decaf Cowboy Coffee";
                        case Size.Large:
                            return "Large Decaf Cowboy Coffee";
                        default:
                            throw new NotImplementedException();

                    }
                }
            }
        }

        /// <summary>
        /// Special instructions
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if(ice)
                    instructions.Add("Add Ice");
                if(roomForCream)
                    instructions.Add("Room for Cream");

                return instructions;
            }
        }
    }
}
