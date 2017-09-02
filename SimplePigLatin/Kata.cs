using System;

namespace SimplePigLatin
{
    public class Kata
    {
        public static string PigIt(string str)
        {
            string[] split = str.Split(' ');
            string pigString = ""; 

            foreach (var item in split)
            {
                string temp;

                if(item.Length > 0)
                {
                    temp = item.Substring(1, item.Length-1);
                    pigString += temp + item[0] + "ay ";
                }
            }

            return pigString.TrimEnd();
        }
    }
}
