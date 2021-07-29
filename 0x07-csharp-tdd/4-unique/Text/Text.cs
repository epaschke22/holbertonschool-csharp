using System;

namespace Text
{
    ///<summary>Returns the index of the first none repeating character in a string</summary>
    public class Str
    {
        public static int UniqueChar(string s) {
            if (s.Length == 0) {
                return -1;
            }
            if (s.Length == 1) {
                return 0;
            }
            if (s[0] != s[1]) {
                return 0;
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
