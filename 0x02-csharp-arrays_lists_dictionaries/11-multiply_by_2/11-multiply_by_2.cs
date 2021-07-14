using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        foreach (KeyValuePair<string, int> pair in myDict) {
            int newValue = pair.Value;
            myDict[pair.Key] = newValue * 2;
        }
        return myDict;
    }
}
