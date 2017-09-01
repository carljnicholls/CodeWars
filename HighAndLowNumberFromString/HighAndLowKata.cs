using System;

namespace HighAndLowNumberFromString
{
    public class HighAndLowKata
    {
        public static string HighAndLow(string numbers)
        {
            var split = numbers.Split(' ');
            int high = Convert.ToInt32(split[0]);
            int low = Convert.ToInt32(split[0]);

            foreach (var numStr in split)
            {
                
                var num = Convert.ToInt32(numStr);

                if (num > high)
                    high = num;

                if (num < low)
                    low = num; 
            }

            return "" + high + ' ' + low;
        }
    }
}
