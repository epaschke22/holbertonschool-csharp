using System;

namespace Text
{
    ///<summary>Returns the index of the first none repeating character in a string</summary>
    public class Str
    {
        public static int UniqueChar(string s) {
            if (s.Length == 0 || s.Length == 1) {
                return -1;
            }
            for (int i = 1; i < s.Length; i++) {
                if (s[i - 1] != s[i]) {
                    return i;
                }
            }
            return -1;
            //s.IndexOf(!s[0])
        }
    }
}
