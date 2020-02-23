using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /*
     * Author: Jordan Stafford
     * Class: JerkedSoda
     * Purpose: Contains information on Jerked Soda.
     */
    public class JerkedSoda : Drink
    {

        private SodaFlavor flavor;


        /// <summary>
        /// Price override for a Jerked Soda
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
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Calories override for a Jerked Soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }

            set
            {
                flavor = value;
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

                if (!Ice)
                    instructions.Add("Hold Ice");

                return instructions;
            }
        }

        public override string Name
        {
            get
            {
                if(flavor == SodaFlavor.CreamSoda)
                {
                    switch(Size)
                    {
                        case Size.Small:
                            return "Small Cream Soda Jerked Soda";
                        case Size.Medium:
                            return "Medium Cream Soda Jerked Soda";
                        case Size.Large:
                            return "Large Cream Soda Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                }

                else if(flavor == SodaFlavor.OrangeSoda)
                {
                    switch(Size)
                    {
                        case Size.Small:
                            return "Small Orange Soda Jerked Soda";
                        case Size.Medium:
                            return "Medium Orange Soda Jerked Soda";
                        case Size.Large:
                            return "Large Orange Soda Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                }

                else if(flavor == SodaFlavor.Sarsparilla)
                {
                    switch(Size)
                    {
                        case Size.Small:
                            return "Small Sarsparilla Jerked Soda";
                        case Size.Medium:
                            return "Medium Sarsparilla Jerked Soda";
                        case Size.Large:
                            return "Large Sarsparilla Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                }

                else if(flavor == SodaFlavor.BirchBeer)
                {
                    switch(Size)
                    {
                        case Size.Small:
                            return "Small Birch Beer Jerked Soda";
                        case Size.Medium:
                            return "Medium Birch Beer Jerked Soda";
                        case Size.Large:
                            return "Large Birch Beer Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                }

                else
                {
                    switch(Size)
                    {
                        case Size.Small:
                            return "Small Root Beer Jerked Soda";
                        case Size.Medium:
                            return "Medium Root Beer Jerked Soda";
                        case Size.Large:
                            return "Large Root Beer Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }
    }
}
