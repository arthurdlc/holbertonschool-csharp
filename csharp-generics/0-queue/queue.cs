﻿using System;

class Queue<T>
{
    public Type CheckType() // faire en sorte que le renvoie de la fonction soit le type T
    {
        return typeof(T); // on se sert de la methode tyopeof
    }
}