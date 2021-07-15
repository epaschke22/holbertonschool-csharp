using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        var hashList1 = new HashSet<int>(list1);
        var hashList2 = new HashSet<int>(list2);
        hashList1.SymmetricExceptWith(hashList2);
        var output = new List<int>(hashList1);
        return output;
    }
}