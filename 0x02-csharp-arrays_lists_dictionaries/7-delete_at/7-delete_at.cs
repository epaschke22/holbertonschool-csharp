using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        try {
            myList.Remove(myList[index]);
            return myList;
        } catch {
            Console.WriteLine("Index is out of range");
        }
        return myList;
    }
}
