using System;

class Character
{
    public static bool IsLower(char c)
    {
        if (c < 96) {
            return false;
        } else {
            return true;
        }
    }
}
