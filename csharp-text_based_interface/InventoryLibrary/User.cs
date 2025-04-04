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
        /// <param name="id">Identifiant unique de l'utilisateur</param>
        /// <param name="date_created">Date de création de l'utilisateur</param>
        /// <param name="date_upload">Date de mise à jour de l'utilisateur</param>
        /// <param name="name">Nom de l'utilisateur</param>
        public User(int id, DateTime date_created, DateTime date_upload, string name)
            : base(id, date_created, date_upload) // Appel du constructeur de BaseClass
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
