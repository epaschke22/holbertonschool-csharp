using System;

///<summary>checks if object is an instance of Array</summary>
class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}
