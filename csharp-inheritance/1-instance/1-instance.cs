using System;

public class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array; // renvoie faux dans le cas d'un array
    }
}
