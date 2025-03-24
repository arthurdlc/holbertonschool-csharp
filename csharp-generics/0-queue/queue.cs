﻿public abstract class Base
{
    public string Name { get; set; }

/*************  ✨ Codeium Command ⭐  *************/
/// <summary>
/// Returns a string representation of the Base instance.
/// </summary>
/// <returns>A string in the format: "<name> is a Base".</returns>

/******  6485c18f-fa6e-43c0-b510-5f81c3412e9f  *******/
    public override string ToString()
    {
        // Utilisation de typeof (type statique)
        return $"{Name} is a {typeof(Base).Name}";  // Renverra toujours "Base"
    }
}
