public class Player()
{
    /// <summary>
    /// propriete du joueur
    /// name: le nom du joueur
    /// hp: les hp actuel du joueur
    /// hpMax: les hp max du joueur
    /// </summary>
    private string name ="Player"; 
    private float maxHp = 100f;
    private float hp;

    // fonction de constructor, on attribut les proprietes du joueur
    public Player(string name, float maxHp) {
        this.name = name;
        this.maxHp = maxHp;
        if (maxHp <= 0f) {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default."); 
        }
        this.hp = this.maxHp;
    }

    // cette fonction renvoie un string qui dis ne nom du joueur, et sa vie actuelle par rapport a ses hp max possible
    public void PrintHealth(this name, this hp, this maxHp) {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}