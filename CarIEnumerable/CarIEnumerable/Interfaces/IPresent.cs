
namespace CarIEnumerable
{
   public interface IPresent<out T>
   //public interface IPresent<in T>
    {
       T Present { get; }
      // T Present {  set; }
        void Print();
    }
}
