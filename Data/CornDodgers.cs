using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /*
     * Author: Jordan Stafford
     * Class: CornDodgers
     * Purpose: Contains information on Corn Dodgers.
     */
    public class CornDodgers : Side
    {
        /// <summary>
        /// Price of Corn Dodgers
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Calroies in Corn Dodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
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
                        return "Small Corn Dodgers";
                    case Size.Medium:
                        return "Medium Corn Dodgers";
                    case Size.Large:
                        return "Large Corn Dodgers";
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
