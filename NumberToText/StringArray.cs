using System.Collections.Generic;

namespace NumberToText
{
    class StringArray
    {
        public string[] StringToArray(string i)
        {
            List<string> stringList = new List<string>();
            for(int j = 0; j < i.Length; j++)
            {
                stringList.Add(i[j].ToString());
            }
            //intList.Reverse();
            return stringList.ToArray();
        }
    }
}
