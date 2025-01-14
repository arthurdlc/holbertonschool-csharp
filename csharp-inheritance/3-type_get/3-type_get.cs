using System;

public class Obj
{
    public static void Print(object myObj)
    {
        return Console.WriteLine(myObj.GetType());
    }
}
