using System;
using System.Collections.Generic;

namespace CountingDuplicates
{
    public class Kata
    {
        public static int DuplicateCount(string str)
        {
            Dictionary<char, int> occurance = new Dictionary<char, int>();
            int max = 0;

            occurance = MapDuplicateOccurance(str); 
            max = CountingDuplicateOccurance(occurance);

            return max;
        }

        private static Dictionary<char, int> MapDuplicateOccurance(string str)
        {
            Dictionary<char, int> occurance = new Dictionary<char, int>();
            str = str.ToLower(); 

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (occurance.ContainsKey(c))
                {
                    int keyValue = occurance[str[i]];
                    keyValue++;
                    occurance[str[i]] = keyValue;
                }
                else
                    occurance.Add(c, 1);
            }

            return occurance; 
        }

        private static int CountingDuplicateOccurance(Dictionary<char, int> occurance)
        {
            int max = 0;

            foreach (var item in occurance)
                if (item.Value > 1)
                    max++;

            return max; 
        }
    }
}
