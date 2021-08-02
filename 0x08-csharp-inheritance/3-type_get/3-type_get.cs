using System;

class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo obj = typeof(myObj).GetTypeInfo();
        Console.WriteLine("{} Properties:", "");
        Console.WriteLine("{} Methods:", "");
    }
}
