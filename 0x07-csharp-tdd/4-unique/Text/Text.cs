using System;

namespace Text
{
    ///<summary>Returns the index of the first none repeating character in a string</summary>
    public class Str
    {
        public static int UniqueChar(string str) {
            char[] count = new char[256];
            for (int i = 0; i < str.Length; i++)
                count[str[i]]++;

            int index = -1;

            for (int i = 0; i < str.Length; i++) {
                if (count[str[i]] == 1) {
                    index = i;
                    break;
                }
            }
 
            return index;
        }
    }
}
