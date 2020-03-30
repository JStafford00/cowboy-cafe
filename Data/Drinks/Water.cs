using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {

        private bool lemon = false;
        private string itemType = "Water";

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
        /// Price override for a Water
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 0.12;
                    case Size.Medium:
                        return 0.12;
                    case Size.Large:
                        return 0.12;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Calories override for a Water
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
                    default:
                        throw new NotImplementedException();
                }
            }
        }


        /// <summary>
        /// If lemon is included.
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }

            set
            {
                lemon = value;
                NotifyOfPropertyChange("Lemon");
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

                if(!Ice)
                    instructions.Add("Hold Ice");
                if(lemon)
                    instructions.Add("Add Lemon");

                return instructions;
            }
        }

        /// <summary>
        /// Returns the name to string based on size
        /// </summary>
        public override string Name
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return "Small Water";
                    case Size.Medium:
                        return "Medium Water";
                    case Size.Large:
                        return "Large Water";
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
