using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> current;
        current = myLList.First;
        if (current.Value > n || current == null) {
            myLList.AddFirst(n);
            return myLList.First;
        }
        while (current != null)
        {
            if (current.Next.Value > n) {
                myLList.AddAfter(current, n);
                return current.Next;
            }
            current = current.Next;
        }
        myLList.AddLast(n);
        return myLList.Last;
    }
}
