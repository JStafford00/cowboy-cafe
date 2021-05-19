using System.Collections.Generic;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /*
     * Author: Nathan Bean
     * Edited By: Jordan Stafford
     * Class: Side.cs
     * Purpose: An abstract class for all the Sides
     */
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {

        private Size size;
        private bool isSmall = true;
        private bool isMedium = false;
        private bool isLarge = false;
        public event PropertyChangedEventHandler PropertyChanged;

        public abstract string ItemType
        {
            get;
        }

        public abstract string Name
        {
            get;
        }

        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// If side is small.
        /// </summary>
        public bool IsSmall
        {
            get
            {
                return isSmall;
            }

            set
            {
                isSmall = value;
            }
        }

        /// <summary>
        /// If side is medium.
        /// </summary>
        public bool IsMedium
        {
            get
            {
                return isMedium;
            }

            set
            {
                isMedium = value;
            }
        }

        /// <summary>
        /// If side is large.
        /// </summary>
        public bool IsLarge
        {
            get
            {
                return isLarge;
            }

            set
            {
                isLarge = value;
            }
        }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special Instructions for a Side
        /// </summary>
        public virtual List<string> SpecialInstructions
        {
            get;
        }

        /// <summary>
        /// Return the name of the side as a string
        /// </summary>
        /// <returns>Name of side</returns>
        public override string ToString()
        {
            return Name;
        }
    }
}
