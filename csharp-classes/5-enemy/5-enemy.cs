using System;

namespace Enemies
{
    /// <summary>
    /// Blueprint for a zombie.
    /// </summary>
    public class Zombie
    {
        /// <summary>
        /// Private field to store the health of the zombie.
        /// </summary>
        private int health;

        /// <summary>
        /// Private field to store the name of the zombie.
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// Public property to get or set the name of the zombie.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Initializes a new instance of the Zombie class with health set to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new instance of the Zombie class with a specified health value.
        /// </summary>
        /// <param name="value">The initial health value for the zombie. Must be >= 0.</param>
        /// <exception cref="ArgumentException">Thrown when value is less than 0.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }

        /// <summary>
        /// Returns the health of the zombie.
        /// </summary>
        /// <returns>The health of the zombie.</returns>
        public int GetHealth()
        {
            return health;
        }

        /// <summary>
        /// Returns a string representation of the Zombie object.
        /// </summary>
        /// <returns>A string in the format: Zombie Name: <name> / Total Health: <health>.</returns>
        public override string ToString()
        {
            return $"Zombie Name: {name} / Total Health: {health}";
        }
    }
}
