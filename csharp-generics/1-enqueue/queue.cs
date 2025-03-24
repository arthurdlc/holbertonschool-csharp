﻿using System;

public class Queue<T>
{
    public Node<T> tail = null;
    public Node<T> head = null;
    private int count = 0; // Privé pour éviter des modifications externes

    public Type CheckType()
    {
        return typeof(T);
    }

    public void Enqueue(T value)
    {
        Node<T> node = new Node<T>(value);
        if (tail == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.next = node;
            tail = node;
        }
        count++;
    }

    public int Count()
    {
        return count;
    }
}

public class Node<T>
{
    public T value;
    public Node<T> next;

    public Node(T value)
    {
        this.value = value;
        this.next = null;
    }
}
