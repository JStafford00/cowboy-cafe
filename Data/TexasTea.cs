﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{

    /*
     * Author: Jordan Stafford
     * Class: TexasTea
     * Purpose: Contains information on Texas .
     */
    public class TexasTea : Drink
    {

        private bool sweet = true;
        private bool lemon = false;

        /// <summary>
        /// Price override for a Texas Tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch(Size)
                {
                    case Size.Small:
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Calories override for a Texas Tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(sweet)
                {
                    switch(Size)
                    {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }

                else
                {
                    switch(Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        /// <summary>
        /// If the tea is sweet.
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }

            set
            {
                sweet = value;
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
    }
}