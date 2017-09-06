using System;

namespace TitleCase
{
    public class Kata
    {
        public static string TitleCase(string title, string minorWords = "")
        {
            if (string.IsNullOrEmpty(title)) return "";

            var titleSplit = title.ToLower().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var minorWordsSplit = (minorWords == null) ? new string[1] : minorWords.ToLower().Split(' ');
            var res = "";

            for (int i = 0; i < titleSplit.Length; i++)
            {
                var capitalise = true; 

                if(i != 0)
                    for (int j = 0; j < minorWordsSplit.Length; j++)
                    {
                        if(minorWordsSplit[j] != null)
                        if (titleSplit[i] == minorWordsSplit[j].ToLower())
                            capitalise = false;
                    }
                
                if (capitalise)
                    res += UppercaseFirstChar(titleSplit[i]) + ' ';
                else
                    res += titleSplit[i] + ' '; 

            }
            return res.Trim();
        }

        private static string UppercaseFirstChar(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;
            
            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
