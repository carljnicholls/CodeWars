using System.Collections.Generic;

namespace MorseConverter
{
    public class ConversionDictionary : Dictionary<string, string>
    {
        private Dictionary<string, string> _dictonary;

        public Dictionary<string, string> MorseDictonary
        {
            get { return _dictonary; }
        }

        public ConversionDictionary()
        {
            _dictonary = new Dictionary<string, string>()
            {
                { ".-" , "A" },
                { "-..." , "B" },
                { "-.-." , "C" },
                { "-.." , "D" },
                { "." , "E" },
                { "..-." , "F" },
                { "--." , "G" },
                { "...." , "H" },
                { ".." , "I" },
                { ".---", "J" },
                { "-.-" , "K" },
                { ".-.." , "L" },
                { "--" , "M" },
                { "-." , "N" },
                { "---" , "O" },
                { ".--." , "P" },
                { "--.-" , "Q" },
                { ".-." , "R" },
                { "..." , "S" },
                { "-" , "T" },
                { "..-" , "U" },
                { "...-" , "V" },
                { ".--" , "W" },
                { "-..-" , "X" },
                { "-.--", "Y" },
                { "--.." , "Z" },
                { "-----" , "0" },
                { ".----" , "1" },
                { "..---" , "2" },
                { "...--" , "3" },
                { "....-" , "4" },
                { "....." , "5" },
                { "-...." , "6" },
                { "--..." , "7" },
                { "---.." , "8" },
                { "----." , "9" },
                { "-.-.--" , "!" },
                { ".-.-.-" , "." },
                { "--..--" , "," },
                { "---..." , ":" },
                { "..--.." , "?" },
                { ".----." , "\'" },
                { "-....-" , "-" },
                { "-..-." , "/" },
                { "...---..." , "SOS" }
            };
        }
    }
}
