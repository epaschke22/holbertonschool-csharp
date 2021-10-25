using System;

///<summary>generic class</summary>
public class Queue<T>
{
    ///<summary>returns the type of the object passed in</summary>
    public string CheckType()
    {
        return typeof(T).Name;
    }
}
