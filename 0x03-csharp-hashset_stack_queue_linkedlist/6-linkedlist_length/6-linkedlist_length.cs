using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        if (myLList == null) {
            return 0;
        }
        int count = 0;
        while (myLList.First.Next != null) {
            myLList.RemoveFirst();
            count++;
        }
        count++;
        return count;
    }
}
