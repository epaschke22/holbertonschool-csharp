using System;

///<summary>checks if first object is an instance of second object</summary>
class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsSubclassOf(baseType);
    }
}
