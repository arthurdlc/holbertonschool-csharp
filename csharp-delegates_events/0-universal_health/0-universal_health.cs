using System;
public class Player
{
    /// <summary>
    /// propriete du joueur
    /// name: le nom du joueur
    /// hp: les hp actuel du joueur
    /// hpMax: les hp max du joueur
    /// </summary>
    private string name; 
    private float maxHp;
    private float hp;

    // fonction de constructor, on attribut les proprietes du joueur
    public void Player(string name, float maxHp) {
        this.name = "Player";
        this.maxHp = 100f;
        if (maxHp <= 0f) {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default."); 
        }
        this.hp = this.maxHp;
    }

    // cette fonction renvoie un string qui dis ne nom du joueur, et sa vie actuelle par rapport a ses hp max possible
    public void PrintHealth(string name, float hp, float maxHp) {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }
}