using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of this order item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The item type of the certain IOrderItem
        /// </summary>
        string ItemType { get; }

        /// <summary>
        /// The special instructions for this order item.
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
