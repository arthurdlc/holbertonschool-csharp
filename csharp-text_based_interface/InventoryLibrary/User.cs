using System;

namespace InventoryLibrary
{
    // La classe User hérite de BaseClass
    public class User : BaseClass
    {
        // Propriété obligatoire : nom de l'utilisateur
        public string Name { get; set; }

        /// <summary>
        /// Constructeur de la classe User
        /// </summary>
        /// <param name="name">Nom de l'utilisateur</param>
        public User(string name) : base()
        {
            // Vérifie que le nom n'est pas vide ou composé uniquement d'espaces
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Le nom ne peut pas être vide.");
            }

            // Assigne la valeur à la propriété
            Name = name;
        }
    }
}
