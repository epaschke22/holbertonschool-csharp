using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int sum = 0;
        LinkedListNode<int> current;
        current = myLList.First;
        while (current != null)
        {
            sum += current.Value;
            current = current.Next;
        }
        return sum;
    }
}
