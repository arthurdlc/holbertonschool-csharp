using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        // Dictionnaire pour stocker les objets avec une clé "<ClassName>.<id>"
        private Dictionary<string, object> objects = new Dictionary<string, object>();

        // Chemin du fichier JSON où les objets sont sauvegardés
        private string filePath = "../storage/inventory_manager.json";

        /// <summary>
        /// Retourne tous les objets stockés.
        /// </summary>
        public Dictionary<string, object> All()
        {
            return objects;
        }

        /// <summary>
        /// Ajoute un nouvel objet au dictionnaire avec une clé unique.
        /// </summary>
        public void New(object obj)
        {
            // Récupération du type de l'objet
            string className = obj.GetType().Name;

            // Vérification si l'objet hérite de BaseClass (pour s'assurer qu'il a un id)
            if (obj is BaseClass baseObj)
            {
                string key = $"{className}.{baseObj.id}";
                objects[key] = obj;  // Ajout au dictionnaire
            }
            else
            {
                throw new ArgumentException("L'objet doit hériter de BaseClass.");
            }
        }

        /// <summary>
        /// Sauvegarde des objets dans un fichier JSON.
        /// </summary>
        public void Save()
        {
            // Sérialisation en JSON
            string jsonString = JsonSerializer.Serialize(objects, new JsonSerializerOptions { WriteIndented = true });

            // Écriture dans le fichier
            File.WriteAllText(filePath, jsonString);
        }

        /// <summary>
        /// Charge les objets depuis un fichier JSON.
        /// </summary>
        public void Load()
        {
            if (File.Exists(filePath))
            {
                // Lecture du fichier JSON
                string jsonString = File.ReadAllText(filePath);

                // Désérialisation en dictionnaire d’objets
                objects = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString) ?? new Dictionary<string, object>();
            }
        }
    }
}