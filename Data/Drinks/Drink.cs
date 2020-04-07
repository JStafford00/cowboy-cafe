using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{

    /*
     * Author: Jordan Stafford
     * Class: Drinks
     * Purpose: Contains information on Drinks class.
     */
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private Size size = Size.Small;
        private bool ice = true;
        private bool isSmall = true;
        private bool isMedium = false;
        private bool isLarge = false;

        public abstract string Name { get; }

        public abstract string ItemType
        {
            get;
        }

        /// <summary>
        /// If drink is small.
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
        /// If drink is medium.
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
        /// If drink is large.
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
        /// Size of the drink
        /// </summary>
        public Size Size 
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyOfPropertyChange("Size");
                NotifyOfPropertyChange("Calories");
                NotifyOfPropertyChange("Price");
            }
        }

        /// <summary>
        /// Price of the drink.
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Calories in the drink.
        /// </summary>
        public abstract uint Calories { get; }

        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// If Ice is added.
        /// </summary>
        public virtual bool Ice 
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
        /// Special Instructions
        /// </summary>
        public abstract List<String> SpecialInstructions { get; }

        /// <summary>
        /// Helper method for changing properties.
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            if(propertyName != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }


        }
    }
}
