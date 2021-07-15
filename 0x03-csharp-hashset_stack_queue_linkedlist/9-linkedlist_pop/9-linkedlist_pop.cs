using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int firstNode = myLList.First.Value;
        myLList.RemoveFirst();
        return firstNode;
    }
}
