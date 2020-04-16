namespace Homework15
{
    public interface IContainer<out T>
    {
        T Cars { get; }
    }
}
