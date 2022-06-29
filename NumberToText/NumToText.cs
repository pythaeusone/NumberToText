using System;

namespace NumberToText
{
    class NumToText
    {
        public void N2T(string n)
        {
            StringArray iA = new StringArray();
            TextNum tN = new TextNum();

            string[] strArr = iA.StringToArray(n);

            foreach(string i in strArr)
            {
                Console.Write(tN.TextNumber(int.Parse(i)));
            }
        }
    }
}
