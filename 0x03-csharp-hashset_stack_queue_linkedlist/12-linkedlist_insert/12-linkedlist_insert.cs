using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current;
        current = myLList.First;
        if (current.Value > n) {
            return myLList.AddFirst(n);
        }
        while (current != null)
        {
            if (current.Next.Value > n) {
                return myLList.AddAfter(current, n);
            }
            current = current.Next;
        }
        return myLList.AddLast(n);
    }
}
