using System;

namespace InventoryLibrary
{
    /// <summary>
    /// Base class that other classes will inherit from.
    /// Contains the base properties for any inventory object.
    /// </summary>
    public class BaseClass
    {
        /// <summary>
        /// Id of the object (unique identifier).
        /// </summary>
        public int id { get; private set; }

        /// <summary>
        /// Date when the object was created.
        /// </summary>
        public DateTime date_created { get; private set; }

        /// <summary>
        /// Date when the object was last updated.
        /// </summary>
        public DateTime date_upload { get; private set; }

        // Constructor with automatic date generation
        public BaseClass(int id)
        {
            this.id = id;  // Set the unique identifier
            this.date_created = DateTime.Now;  // Automatically set the creation date
            this.date_upload = DateTime.Now;   // Automatically set the upload date
        }

        // Alternatively, if you want the user to be able to specify the dates
        // You could use a constructor with all parameters
        public BaseClass(int id, DateTime date_created, DateTime date_upload)
        {
            this.id = id;
            this.date_created = date_created;
            this.date_upload = date_upload;
        }
    }
}
