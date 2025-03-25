﻿using System;

public class Player
{
    private string name; 
    private float maxHp;
    private float hp;

    // Constructeur par défaut
    public Player() 
    {
        this.name = "Player";
        this.maxHp = 100f;
        this.hp = this.maxHp;
    }

    // Constructeur avec paramètres
    public Player(string name, float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0f)
        {
            this.maxHp = maxHp;
        }
        else
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}
