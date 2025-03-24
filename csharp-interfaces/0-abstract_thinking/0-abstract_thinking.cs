using System;

public abstract class Base
{
    // Public property name of type string
    public string Name { get; set; }

    // Override the ToString() method to return "<name> is a <type>"
    public override string ToString()
    {
        return $"{Name} is a {this.GetType().Name}";
    }
}

class SoftwareEngineer : Base
{
    // The SoftwareEngineer class does not need any additional implementation for now
}

class Program
{
    static void Main(string[] args)
    {
        SoftwareEngineer engineer = new SoftwareEngineer();

        engineer.Name = "Betty";  // Setting the name property

        // Output the result of the overridden ToString() method
        Console.WriteLine(engineer.ToString());  // Expected Output: "Betty is a SoftwareEngineer"
    }
}
