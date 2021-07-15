using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        if (myLList == null || myLList.Count == 0) {
            return myLList.AddLast(n);
        }
        LinkedListNode<int> current;
        current = myLList.First;
        if (current.Value > n) {
            return myLList.AddFirst(n);
        }
        while (current != null)
        {
            if (current.Next != null && current.Next.Value > n) {
                return myLList.AddAfter(current, n);
            }
            current = current.Next;
        }
        return myLList.AddLast(n);
    }
}
