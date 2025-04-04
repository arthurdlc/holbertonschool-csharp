using System;

namespace InventoryLibrary
{
    // La classe Inventory hérite de BaseClass
    public class Inventory : BaseClass
    {
        // Propriété obligatoire : Identifiant de l'utilisateur associé
        public int UserId { get; set; }

        // Propriété obligatoire : Identifiant de l'item associé
        public int ItemId { get; set; }

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
        /// <param name="id">Identifiant unique de l'inventaire</param>
        /// <param name="date_created">Date de création de l'inventaire</param>
        /// <param name="date_upload">Date de mise à jour de l'inventaire</param>
        /// <param name="userId">Identifiant d'un utilisateur</param>
        /// <param name="itemId">Identifiant d'un item</param>
        /// <param name="quantity">Quantité d'items (minimum 0, par défaut 1)</param>
        public Inventory(int id, DateTime date_created, DateTime date_upload, int userId, int itemId, int quantity = 1)
            : base(id, date_created, date_upload) // Appel du constructeur de BaseClass avec les arguments nécessaires
        {
            // Vérifie que les identifiants ne sont pas vides
            if (userId <= 0)
            {
                throw new ArgumentException("L'ID utilisateur doit être un nombre positif.");
            }

            if (itemId <= 0)
            {
                throw new ArgumentException("L'ID de l'item doit être un nombre positif.");
            }

            // Assigne les valeurs aux propriétés
            UserId = userId;
            ItemId = itemId;
            Quantity = quantity; // Passe par le setter pour valider la valeur
        }
    }
}
