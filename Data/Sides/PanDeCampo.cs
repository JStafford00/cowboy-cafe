using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{

    /*
     * Author: Jordan Stafford
     * Class: PanDeCampo.cs
     * Purpose: To hold information on the Pan de Campo Side
     */
    public class PanDeCampo : Side
    {
        /// <summary>
        /// Price of Pan de Campo
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
        /// Calroies in Pan de Campo
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 227;
                    case Size.Medium:
                        return 269;
                    case Size.Large:
                        return 367;
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
                        return "Small Pan de Campo";
                    case Size.Medium:
                        return "Medium Pan de Campo";
                    case Size.Large:
                        return "Large Pan de Campo";
                    default:
                        throw new NotImplementedException();
                }
            }
        }
    }
}
