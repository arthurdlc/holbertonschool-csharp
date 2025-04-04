using System;

namespace InventoryLibrary
{
    // La classe Inventory hérite de BaseClass
    public class Inventory : BaseClass
    {
        // Propriété obligatoire : Identifiant de l'utilisateur associé
        public string UserId { get; set; }

        // Propriété obligatoire : Identifiant de l'item associé
        public string ItemId { get; set; }

        // Propriété obligatoire : Quantité d'items (min 0, valeur par défaut 1)
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("La quantité ne peut pas être négative.");
                }
                quantity = value;
            }
        }

        /// <summary>
        /// Constructeur de la classe Inventory
        /// </summary>
        /// <param name="userId">Identifiant d'un utilisateur</param>
        /// <param name="itemId">Identifiant d'un item</param>
        /// <param name="quantity">Quantité d'items (minimum 0, par défaut 1)</param>
        public Inventory(string userId, string itemId, int quantity = 1) : base()
        {
            // Vérifie que les identifiants ne sont pas vides
            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentException("L'ID utilisateur ne peut pas être vide.");
            }

            if (string.IsNullOrWhiteSpace(itemId))
            {
                throw new ArgumentException("L'ID de l'item ne peut pas être vide.");
            }

            // Assigne les valeurs aux propriétés
            UserId = userId;
            ItemId = itemId;
            Quantity = quantity; // Passe par le setter pour valider la valeur
        }
    }
}
