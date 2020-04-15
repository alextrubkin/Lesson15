namespace Homework15
{
    public class Container<T> : IContainer<T>
    {
        private T cars;
        public Container(T cars)
        {
            this.cars = cars;
        }
        public T Cars
        {
            set { cars = value; }
        }
        public override string ToString()
        {
            return cars.ToString();
        }
    }
}
