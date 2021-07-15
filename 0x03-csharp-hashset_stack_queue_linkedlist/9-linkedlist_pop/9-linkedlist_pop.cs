using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList.First == null) {
            return 0;
        }
        int firstNode = myLList.First.Value;
        myLList.RemoveFirst();
        return firstNode;
    }
}
