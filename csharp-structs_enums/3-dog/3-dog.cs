using System;

// Define the Rating enum
enum Rating
{
    Good,       // 0
    Great,      // 1
    Excellent   // 2
}

// Define the Dog struct
struct Dog
{
    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }
    public string name.ToString();   // nom
    public float age.ToString();     // age
    public string owner.ToString();  // owner
    public Rating rating.ToString(); // Dog's rating
}
