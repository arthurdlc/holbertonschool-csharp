﻿using System;
using System.Collections.Generic;


/// <summary>
/// Enumeration of modifiers
/// </summary>
public enum Modifier
{
    /// <summary>Weak modifier.</summary>
    Weak,

    /// <summary>Base modifier.</summary>
    Base,

    /// <summary>Strong modifier.</summary>
    Strong
}

/// <summary>
/// Delegate to calculate Health
/// </summary>
public delegate void CalculateHealth(float amount);

/// <summary>
/// Delegate to mofifier baseValue
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// public class Player
/// </summary>
public class Player
{
    /* String name property. */
    private string name;

    /* float maxHp property. */
    private float maxHp;

    /* float hp property */
    private float hp;

    /// <summary>constructor to initialize properties.</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        this.maxHp = maxHp;
        if (this.maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;
    }

    /// <summary>Method to print health of player.</summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
    }

    /// <summary>
    /// Print damage. If damage is negative, the Player takes 0 damage.
    /// </summary>
    public void TakeDamage(float damage)
    {
        float newHp = this.hp;
        if (damage <= 0)
        {
            Console.WriteLine("{0} takes 0 damage!", this.name);
        }
        else
        {
            newHp -= damage;
            ValidateHP(newHp);
            Console.WriteLine("{0} takes {1} damage!", this.name, damage);
        }
    }

    /// <summary>
    /// Print heal. If heal is negative, the Player takes 0 heal.
    /// </summary>
    public void HealDamage(float heal)
    {
        float newHp = this.hp;
        if (heal <= 0)
        {
            Console.WriteLine("{0} heals 0 HP!", this.name);
        }
        else
        {
            newHp += heal;
            ValidateHP(newHp);
            Console.WriteLine("{0} heals {1} HP!", this.name, heal);
        }
    }

    /// <summary>
    /// Validate the new value of hp.
    /// </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
    }

    /// <summary>
    /// Apply the modifier to the baseValue
    /// </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue / 2f;
        else if (modifier == Modifier.Base)
            return baseValue; 
        else
            return baseValue * 1.5f;
    }
}
