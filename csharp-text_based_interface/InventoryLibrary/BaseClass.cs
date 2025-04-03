using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Voici la classe de Base dans laquelle seront implémenté les autres class
    /// </summary> 
    public class BaseClass
    {
        /// <summary>
        /// Id de l'objet
        /// </summary>
        public int id { get; private set; }
        
        /// <summary>
        /// Date de création de l'object
        /// </summary>
        public DateTime date_created { get; private set; }

        /// <summary>
        /// Date de mise a jour de l'object
        /// </summary>
        public DateTime date_upload { get; private set; }
        public BaseClass(int id, DateTime date_created, DateTime date_upload)
        {
            this.id = id; // assigné les parametre de la classe dans le constucteur
            this.date_created = date_created;
            this.date_upload = date_upload;
        }
    }
}