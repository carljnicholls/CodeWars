using System;
using System.Collections.Generic;

namespace DeleteNthNumber
{
    public class Kata
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            List<int> val = new List<int>();
            Dictionary<int, int> dictonany = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dictonany.ContainsKey(arr[i]))
                {
                    var tmp = dictonany[arr[i]];
                    tmp++;
                    dictonany[arr[i]] = tmp;

                    if (tmp <= x)
                        val.Add(arr[i]);
                }
                else
                {
                    dictonany.Add(arr[i], 1);
                    val.Add(arr[i]);
                }
            }

            return val.ToArray();
        }
    }
}
