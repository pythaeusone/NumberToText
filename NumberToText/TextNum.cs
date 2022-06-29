
namespace NumberToText
{
    class TextNum
    {
        private string[] textNum = {"Null ", "Eins ", "Zwei ", "Drei ", "Vier ", "Fünf ", "Sechs ", "Sieben ", "Acht ", "Neun "};

        public string TextNumber(int i)
        {
            return textNum[i];
        }
    }
}
