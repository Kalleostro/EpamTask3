

namespace DishesLibr
{
    public class BakeProcess : Process
    {
        /// <summary>
        /// Create baking process
        /// </summary>
        /// <param name="time">time</param>
        /// <param name="price">price</param>
        public BakeProcess(int time, float price)
        {
            Price = price;
            Time = time;
            ProcessType = typeof(IBakeable<>).Name;
        }
    }
}