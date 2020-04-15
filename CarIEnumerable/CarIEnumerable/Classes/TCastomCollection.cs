using System;
using System.Collections.Generic;

namespace CarIEnumerable
{
     public class TCastomCollection<T>:List<T>
    {
        List<T> myCollection;
        public TCastomCollection()
        {
            myCollection = new List<T>();
        }
         public string GetTypeOfGeneric()
        {                     
            var a = myCollection.GetType().GetGenericArguments()[0];
            return a.Name;                       
        }
    }
}
