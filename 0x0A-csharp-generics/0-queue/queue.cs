using System;

///<summary>generic class</summary>
public class Queue<T>
{
    ///<summary>returns the type of the object passed in</summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
