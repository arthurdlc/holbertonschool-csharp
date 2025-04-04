# Inventory Manager

## Description
Le projet Inventory Manager est une application console permettant de gérer un inventaire d'objets. Les utilisateurs peuvent créer, afficher, mettre à jour et supprimer des objets dans l'inventaire. Les données sont stockées au format JSON et chargées dans l'application lors du démarrage.

## Fonctionnalités
- **ClassNames** : Affiche tous les types de classes d'objets.
- **All** : Affiche tous les objets dans le stockage.
- **All [ClassName]** : Affiche tous les objets d'une classe spécifique.
- **Create [ClassName]** : Crée un nouvel objet de type `ClassName`.
- **Show [ClassName] [id]** : Affiche un objet spécifique par `ClassName` et `id`.
- **Update [ClassName] [id]** : Met à jour les propriétés d'un objet.
- **Delete [ClassName] [id]** : Supprime un objet du stockage.
- **Exit** : Quitte l'application.

## Utilisation

### Démarrage
1. Clonez ce dépôt ou téléchargez le code source.
2. Ouvrez le projet dans Visual Studio Code ou un autre éditeur C#.
3. Dans le terminal, exécutez la commande suivante pour restaurer les dépendances et compiler le projet :
   ```bash
   dotnet build
