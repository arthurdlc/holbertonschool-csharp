﻿using System;

class Queue<T>
{
    public Node<T> tail = null;
    public Node<T> head = null;
    public int count = 0;
    public Type CheckType() // faire en sorte que le renvoie de la fonction soit le type T
    {
        return typeof(T); // on se sert de la methode tyopeof
    }
    public void Enqueue(value)
    {
        
    }
}

class Node<T>
{
    public T value = null;
    public Node<T> next = null;

    public Node(T value)
    {
        this.value = value;
    }
}