
namespace DishesLib
{
    public class AddProcess : Process
    {
        /// <summary>
        /// Add cooking process
        /// </summary>
        /// <param name="time">time of process</param>
        /// <param name="price">price</param>
        public AddProcess(int time, float price)
        {
            Price = price;
            Time = time;
            ProcessType = typeof(IAddable<>).Name;
        }
    }
}