﻿public abstract class Base
{
    public string Name { get; set; }

    public override string ToString()
    {
        // Utilisation de typeof (type statique)
        return $"{Name} is a {typeof(Base).Name}";  // Renverra toujours "Base"
    }
}
