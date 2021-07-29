using System;
using System.Linq;

namespace Text
{
    ///<summary>Returns true if a string is a palindrome</summary>
    public class Str
    {
        public static bool IsPalindrome(string s) {
            string str = new string(s.Where(c => !char.IsPunctuation(c)).ToArray());
            str = str.Replace(" ", String.Empty);
            str = str.ToLower();
            return str.SequenceEqual(str.Reverse());
        }
    }
}
