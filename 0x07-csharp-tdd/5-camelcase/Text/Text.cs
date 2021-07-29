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
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] >= 65 && s[i] <= 90)
                    count++;
            }
            return count;
        }
    }
}
