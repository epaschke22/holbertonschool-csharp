using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count > 0) {
            int biggest = myList[0];
            for (int i = 0; i < myList.Count; i++) {
                if (myList[i] > biggest) {
                    biggest = myList[i];
                }
            }
            return biggest;
        } else {
            Console.WriteLine("List is empty");
            return -1;
        }
    }
}
