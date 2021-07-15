using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int idx = 0;
        LinkedListNode<int> current;
        current = myLList.First;
        while (current != null)
        {
            if (idx == index) {
               myLList.Remove(current);
            }
            idx++;
            current = current.Next;
        }
    }
}
