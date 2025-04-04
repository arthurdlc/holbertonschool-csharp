using System;
using System.Collections.Generic; // Pour utiliser List<string>

namespace InventoryLibrary
{
    // La classe Item hérite de BaseClass
    public class Item : BaseClass
    {
        // Propriété requise : Nom de l'objet
        public string Name { get; set; }

        // Propriété optionnelle : Description de l'objet (par défaut vide)
        public string Description { get; set; } = "";

        // Propriété optionnelle : Prix limité à 2 décimales
        public float Price { get; set; }

        // Propriété optionnelle : Liste de tags associés à l'objet
        public List<string> Tags { get; set; }

        /// <summary>
        /// Constructeur de la classe Item
        /// </summary>
        /// <param name="name">Nom de l'item (obligatoire)</param>
        /// <param name="description">Description de l'item (optionnelle, par défaut vide)</param>
        /// <param name="price">Prix de l'item (optionnel, arrondi à 2 décimales)</param>
        /// <param name="tags">Liste des tags associés à l'item</param>
        public Item(string name, string description = "", float price = 0.0f, List<string> tags = null)
            : base() // Appelle le constructeur de BaseClass (gère id, date_created, date_updated)
        {
            // Vérifie que le nom n'est pas vide ou null
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Le nom de l'item ne peut pas être vide.");
            }

            // Assigne les valeurs aux propriétés
            Name = name;
            Description = description;

            // Arrondi le prix à 2 décimales
            Price = (float)Math.Round(price, 2);

            // Initialise la liste des tags (évite une erreur si null est passé)
            Tags = tags ?? new List<string>();
        }
    }
}
