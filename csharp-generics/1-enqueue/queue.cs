﻿using System;

public class Queue<T>
{
    public Node<T> head = null;
    public Node<T> tail = null;
    private int count = 0;

    public Type CheckType()
    {
        return typeof(T);
    }

    public void Enqueue(T value)
    {
        Node<T> node = new Node<T>(value);
        if (head == null) // Si la queue est vide
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count++; // Incrémentation du compteur
    }

    public int Count()
    {
        return count;
    }
}

public class Node<T>
{
    public T value;  // Ne pas initialiser à null pour compatibilité avec les types valeur
    public Node<T> next = null;

    public Node(T value)
    {
        this.value = value;
        this.next = null;
    }
}
