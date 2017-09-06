namespace MorseConverter
{
    public class Converter
    {
        private ConversionDictionary conversionDictionary;

        public Converter()
        {
            this.conversionDictionary = new ConversionDictionary();
        }

        public string Decode(string morseString)
        {
            string val = "";

            var strWithReplacedWhiteSpace =
                ThreeSpacesToSpecialChar(morseString.TrimStart());
            string[] splitMorseString =
                strWithReplacedWhiteSpace.Split(' ');
            val = DecodeMorseString(splitMorseString);

            return val.ToUpper().Trim();
        }

        //public static string Encoder(string strInput) 
        //{
        //    string val = "";

        //    string[] splitInputString = strInput.Split(' '); 


        //    return val;
        //}

        private string ThreeSpacesToSpecialChar(string morseString)
        {
            char[] charArray = morseString.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
                if (charArray[i] == ' ')
                    if (charArray[i - 1] == ' ')
                        if (morseString[i + 1] == ' ')
                            charArray[i] = '|';

            return new string(charArray);
        }

        private string DecodeMorseString(string[] morseStringArray)
        {
            var editedString = "";

            for (int i = 0; i < morseStringArray.Length; i++)
                if (conversionDictionary.MorseDictonary.ContainsKey(morseStringArray[i]))
                    editedString += conversionDictionary.MorseDictonary[morseStringArray[i]];
                else if (morseStringArray[i] == "|")
                    editedString += ' ';

            return editedString;
        }

    }
}
