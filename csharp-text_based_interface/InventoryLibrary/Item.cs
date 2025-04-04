using System;
using System.Collections.Generic; // Pour utiliser List<string>

namespace InventoryLibrary
{
    /// <summary>
    /// La classe Item hérite de BaseClass et représente un objet d'inventaire.
    /// </summary>
    public class Item : BaseClass
    {
        // Propriété requise : Nom de l'objet
        public string Name { get; set; }

        // Propriété optionnelle : Description de l'objet (par défaut vide)
        public string Description { get; set; } = "";

        // Propriété optionnelle : Prix limité à 2 décimales
        public float Price { get; set; }

        // Propriété optionnelle : Liste de tags associés à l'objet
        public List<string> Tags { get; set; } = new List<string>();  // Liste vide par défaut

        /// <summary>
        /// Constructeur de la classe Item.
        /// </summary>
        /// <param name="id">Identifiant unique de l'item</param>
        /// <param name="date_created">Date de création de l'item</param>
        /// <param name="date_upload">Date de mise à jour de l'item</param>
        /// <param name="name">Nom de l'item (obligatoire)</param>
        /// <param name="description">Description de l'item (optionnelle, par défaut vide)</param>
        /// <param name="price">Prix de l'item (optionnel, arrondi à 2 décimales)</param>
        /// <param name="tags">Liste des tags associés à l'item</param>
        public Item(int id, DateTime date_created, DateTime date_upload, string name, string description = "", float price = 0.0f, List<string> tags = null)
            : base(id, date_created, date_upload) // Appel du constructeur de BaseClass avec les paramètres nécessaires
        {
            // Vérifie que le nom n'est pas vide ou null
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Le nom de l'item ne peut pas être vide.");
            }

            // Assigne les valeurs aux propriétés
            Name = name;
            Description = description;

            // Vérifie que le prix est valide (non négatif)
            if (price < 0)
            {
                throw new ArgumentOutOfRangeException("Le prix ne peut pas être inférieur à 0.");
            }

            // Arrondi le prix à 2 décimales
            Price = (float)Math.Round(price, 2);

            // Si tags est null, on initialise une nouvelle liste vide
            Tags = tags ?? new List<string>();
        }
    }
}
