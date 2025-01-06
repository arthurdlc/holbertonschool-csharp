using System;

namespace Enemies
{
    /// <summary>
    /// Blueprint for zombie.
    /// </summary>
    public class Zombie
    {
        // Public health field for the zombie
        public int health;

        /// <summary>
        /// Initializes a new instance of the Zombie class with health set to 0.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
    }
}
