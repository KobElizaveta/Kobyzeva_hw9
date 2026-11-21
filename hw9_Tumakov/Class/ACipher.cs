using hw9_Tumakov.Interface;

namespace hw9_Tumakov.Class
{
    internal class ACipher: ICipher
    {
        public string InputStr { get; set; }
        private int shift = 1;
        private List<char> upperAlphabet= new List<char>();
        private List<char> lowerAlphabet = new List<char>();
        private int numLetterA = (int)'A';
        private int numLetterZ = (int)'Z';
        private int numLettera = (int)'a';
        private int numLetterz = (int)'z';
        public ACipher(string inputStr)
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

            foreach(char sumbol in InputStr)
            {
                if(!Char.IsLetter(sumbol))
                {
                    OutputStr += sumbol;
                }
                else if(Char.IsUpper(sumbol))
                {
                    int indexResult = (upperAlphabet.IndexOf(sumbol) + shift) % upperAlphabet.Count;
                    OutputStr += upperAlphabet[indexResult];
                }
                else
                {
                    int indexResult = (lowerAlphabet.IndexOf(sumbol) + shift) % lowerAlphabet.Count;
                    OutputStr += lowerAlphabet[indexResult];
                }
            }
            return OutputStr;
        }

        public string dencode()
        {
            string OutputStr = string.Empty;

            foreach (char sumbol in InputStr)
            {
                if (!Char.IsLetter(sumbol))
                {
                    OutputStr += sumbol;
                }
                else if (Char.IsUpper(sumbol))
                {
                    int indexResult = (upperAlphabet.IndexOf(sumbol) - shift + upperAlphabet.Count) % upperAlphabet.Count;
                    OutputStr += upperAlphabet[indexResult];
                }
                else
                {
                    int indexResult = (lowerAlphabet.IndexOf(sumbol) - shift + lowerAlphabet.Count) % lowerAlphabet.Count;
                    OutputStr += lowerAlphabet[indexResult];
                }
            }
            return OutputStr;
        }
    }
}
