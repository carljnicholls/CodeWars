using System;
using System.Collections.Generic;

namespace ListFilterer
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            List<int> listOfInt = new List<int>();

            for (int i = 0; i < listOfItems.Count; i++)
            {
                Type type = listOfItems[i].GetType();
                if (type == typeof(int))
                    listOfInt.Add((int)listOfItems[i]);
            }

            return listOfInt;
        }
    }
}
