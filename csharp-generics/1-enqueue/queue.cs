﻿﻿using System;

/// <summary>
/// This class should not inherit from other classes or interfaces.
/// </summary>
public class Queue<T>
{
    /// First Node of the Queue.
    private Node head;

    /// Last Node of the Queue.
    private Node tail;

    /// Number of Nodes in the Queue.
    private int count;

    /// <summary>
    /// Subclass to manage Queue elements.
    /// </summary>
    public class Node
    {
        /// <summary>Gets or sets the value of the Node.</summary>
        public T value = default(T);

        /// <summary>Gets or sets the next Node in the Queue.</summary>
        public Node next = null;

        /// <summary>
        /// initialize a Node.
        /// </summary>
        public Node(T value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// Returns the Queue’s type.
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Creates a new Node and adds it to the end of the queue.
    /// </summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        count++;
    }

    ///<summary>
    /// Removes the first node in the queue and returns its value.
    ///</summary>
    public void Dequeue(T value)
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            head = head.next;
            count--;
        }
    }

    /// <summary>
    /// Returns the number of nodes in the Queue.
    /// </summary>
    public int Count()
    {
        return count;
    }
}