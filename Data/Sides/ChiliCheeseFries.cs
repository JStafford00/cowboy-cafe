using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /*
     * Author: Nathan Bean 
     * Edited By: Jordan Stafford
     * Class: ChiliCheeseFries.cs
     * Purpose: Chili Cheese Fries Side
    */
    public class ChiliCheeseFries : Side
    {
        private string itemType = "Chili Cheese Fries";

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
        /// Price of Chili Cheese Fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Calroies in Chili Cheese Fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
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
                        return "Small Chili Cheese Fries";
                    case Size.Medium:
                        return "Medium Chili Cheese Fries";
                    case Size.Large:
                        return "Large Chili Cheese Fries";
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
