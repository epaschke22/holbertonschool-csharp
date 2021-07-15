using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int index = 0;
        LinkedListNode<int> current;
        current = myLList.First;
        while (current != null)
        {
            if (index == n) {
                return current.Value;
            }
            index++;
            current = current.Next;
        }
        return 0;
    }
}
