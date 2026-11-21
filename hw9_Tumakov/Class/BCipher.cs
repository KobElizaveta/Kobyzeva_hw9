using hw9_Tumakov.Interface;

namespace hw9_Tumakov.Class
{
    internal class BCipher: ICipher
    {
        public string InputStr { get; set; }
        private List<char> upperAlphabet = new List<char>();
        private List<char> lowerAlphabet = new List<char>();
        private int numLetterA = (int)'A';
        private int numLetterZ = (int)'Z';
        private int numLettera = (int)'a';
        private int numLetterz = (int)'z';
        public BCipher(string inputStr)
        {
            InputStr = inputStr;

            for (char letter = (char)numLetterA; letter <= (char)numLetterZ; letter++)
            {
                upperAlphabet.Add(letter);
            }
            for (char letter = (char)numLettera; letter <= (char)numLetterz; letter++)
            {
                lowerAlphabet.Add(letter);
            }
        }

        public string encode()
        {
            string OutputStr = string.Empty;

            foreach (char sumbol in InputStr)
            {
                if (Char.IsUpper(sumbol))
                {
                    OutputStr += upperAlphabet[upperAlphabet.Count - upperAlphabet.IndexOf(sumbol) - 1];
                }
                else if (Char.IsLower(sumbol))
                {
                    OutputStr += lowerAlphabet[lowerAlphabet.Count - lowerAlphabet.IndexOf(sumbol) - 1];
                }
                else { OutputStr += sumbol; }
            }
            return OutputStr;
        }

        public string dencode()
        {
            return encode();
        }
    }
}
