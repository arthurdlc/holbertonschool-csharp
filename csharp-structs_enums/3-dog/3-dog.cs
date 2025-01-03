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
    public string name;   // nom
    public float age;     // age
    public string owner;  // owner
    public Rating rating; // Dog's rating
    public override string ToString() => $"Dog: {name} is {age} years old and owned by {owner} with a rating of {rating}.";
}
