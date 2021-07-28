using System;

namespace Text
{
    ///<summary>Returns number of words in a string with camelCase</summary>
    public class Str
    {
        public static int CamelCase(string s)
        {
            if (s.Length == 0) {
                return 0;
            }
            int count = 1;
            for (int i = 1; i < str.Length - 1; i++)
            {
                if (str[i] >= 65 && str[i] <= 90)
                    count++;
            }
            return count;
        }
    }
}
