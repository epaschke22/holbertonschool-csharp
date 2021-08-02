using System;

class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (baseType is derivedType)
            return true;
        return false;
    }
}
