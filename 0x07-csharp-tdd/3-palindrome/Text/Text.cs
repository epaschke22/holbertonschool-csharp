using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Text
{
    ///<summary>Returns true if a string is a palindrome</summary>
    public class Str
    {
        public static bool IsPalindrome(string s) {
            //string str = new string(s.Where(c => !char.IsPunctuation(c)).ToArray());
            string str = Rege
            return str.SequenceEqual(str.Reverse());
        }
    }
}
