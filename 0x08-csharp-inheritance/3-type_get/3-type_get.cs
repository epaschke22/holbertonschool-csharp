using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Console.WriteLine("{0} Properties:", myObj.GetType().Name);
        foreach (PropertyInfo item in myObj.GetType().GetProperties())
        {
            Console.WriteLine(item.Name);
        }
        Console.WriteLine("{0} Methods:", myObj.GetType().Name);
        foreach (MethodInfo item in myObj.GetType().GetMethods())
        {
            Console.WriteLine(item.Name);
        }
    }
}
