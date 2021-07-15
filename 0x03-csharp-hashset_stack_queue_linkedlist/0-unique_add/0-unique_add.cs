using System;
using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        var uniqueList = myList.Distinct().ToList();
        int sum = 0;
        for (int i = 0; i < uniqueList.Count; i++) {
            sum += uniqueList[i];
        }
        return sum;
    }
}
