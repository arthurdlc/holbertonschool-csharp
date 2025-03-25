﻿using System;
/// <summary>
/// class for queue
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// shear a 2d matrix given a direction and a factor
    /// </summary>
    /// <param name="head"></param>
    /// <param name="tail"></param>
    /// <param name="count"></param>
    /// <returns></returns>
    public Node<T> head = null;
    public Node<T> tail = null;
    private int count = 0;

    /// <summary>
    /// cette fonction sert a renvoyer le type de Queue
    /// </summary> 
    public Type CheckType()
    {
        return typeof(T);
    }

    public void Enqueue(T value){
        Node<T> node = new Node<T>(value);
        if (head == null){
            head = node;
            tail = node;
        }
        else{
            tail.next = node;
            tail = node;
        }
        count++; // Incrémentation du compteur
    }

    public int Count(){
        return count;
    }
}

public class Node<T>{
    public T value;  // Ne pas initialiser à null pour compatibilité avec les types valeur
    public Node<T> next = null;

    public Node(T value){
        this.value = value;
        this.next = null;
    }
}
