using System.Collections.Generic;

namespace DishesLib
{
    public abstract class Ingredient
    {
        /// <summary>
        /// Storage Temperature
        /// </summary>
        public int StorageTemperature { get; protected set; }
        /// <summary>
        /// Price
        /// </summary>
        public float Price {get; protected set; }
    }
}