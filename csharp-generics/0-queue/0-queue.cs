using system;

public class Queue<T>
{
    public void CheckType(T item)
    {
        Console.WriteLine("{0} is a {1}", item, typeof(T).Name);
        //  dans ce cod eon a creer une classe generique qui n'a pas de type
    }
}