using System;

public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    // Constructeur avec valeur par défaut pour maxHp
    public Player(string name = "Player", float maxHp = 100f)
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
/*************  ✨ Codeium Command ⭐  *************/
/******  484c89d9-c293-4061-85bd-b16df3d542ae  *******//// <summary>

/// Prints the current health status of the player to the console.

/// </summary>

