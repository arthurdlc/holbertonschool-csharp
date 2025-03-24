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
