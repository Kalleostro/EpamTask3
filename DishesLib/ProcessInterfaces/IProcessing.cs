using System.ComponentModel;

namespace DishesLib
{
    public interface IProcessing<T>
    {
        public T Process();
    }
}