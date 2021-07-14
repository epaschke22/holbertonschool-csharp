using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int maxscore = 0;
        string maxkey = "None";
        foreach (var entry in myList) {
            if (entry.Value > maxscore) {
                maxscore = entry.Value;
                maxkey = entry.Key;
            }
        }
        return maxkey;
    }
}
