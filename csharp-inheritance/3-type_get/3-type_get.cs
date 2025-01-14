using System;
using System.Reflection;

public class Obj
{
    public static void Print(object myObj)
    {
        // Get the type of the object
        Type type = myObj.GetType();

        // Print the name of the type
        Console.WriteLine("{0} Properties:", type.Name);

        // Get and print the properties
        PropertyInfo[] properties = type.GetProperties();
        foreach (var prop in properties)
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine("{0} Methods:", type.Name);

        // Get and print the methods
        MethodInfo[] methods = type.GetMethods();
        foreach (var method in methods)
        {
            Console.WriteLine(method.Name);
        }
    }
}
