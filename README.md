# 🌌 NasaExam

NasaExam est une application web développée avec **Blazor** et exploitant les API publiques de la NASA pour afficher des images et des informations fascinantes sur l'univers.

## 📌 Fonctionnalités

### 🔭 Astronomy Picture of the Day (APOD) - Fonctionnelle ✅
L'API APOD de la NASA permet d'afficher chaque jour une nouvelle image accompagnée d'une description détaillée.

- **📅 Recherche par date** : L'utilisateur peut sélectionner une date spécifique pour voir l'image astronomique publiée ce jour-là.
- **⭐ Ajouter aux favoris** : Il est possible d'ajouter des images à une liste de favoris pour les consulter plus tard.
- **🔄 Navigation quotidienne** : Des boutons permettent de parcourir les images des jours précédents et suivants.

### 🌍 Earth Polychromatic Imaging Camera (EPIC) - En développement 🚧
L'API EPIC permet d'afficher des images de la Terre prises depuis l’espace par le satellite DSCOVR. Cette fonctionnalité est encore en cours de développement et ne fonctionne pas pour le moment.

## 🏗️ Structure du projet

- **📁 Pages/** : Contient les composants **Razor** qui affichent les différentes vues de l'application (APOD, favoris, etc.).
- **📁 Services/** : Gère la récupération des données depuis les API de la NASA.
- **📁 wwwroot/** : Contient les ressources statiques comme les fichiers CSS et JS.
- **📜 App.razor** : Composant racine Blazor.
- **🚀 Program.cs** : Configure les services et le routage de l'application.

## 🛠️ Installation et exécution

1. **Cloner le dépôt**
   ```bash
   git clone https://github.com/Shy-Bae99/NasaExam.git
   cd NasaExam
   ```
2. **Restaurer les dépendances**
   ```bash
   dotnet restore
   ```
3. **Lancer l'application**
   ```bash
   dotnet run
   ```
4. **Accéder à l'application**  
   Ouvrez un navigateur et rendez-vous sur :
    - `https://localhost:5001` (HTTPS)
    - `http://localhost:5000` (HTTP)

## 🤝 Contribuer

Les contributions sont les bienvenues ! Vous pouvez :
- Signaler un bug via une **issue**.
- Proposer des améliorations avec une **pull request**.

## 📜 Licence

Ce projet est sous licence **MIT**.  


Fichier Readme pour mon examen,

Je noterai ici les idées, et avancements de mon projet pour garder une trace de son évolution

22/02 : création du projet, ajout de mes pages, choix de l'api a utiliser.

- l'API que je compte utiliser est EPIC, ainsi que APOD, deux api's disponibles à partir du site de la nasa, et qui
  affichent des images de la terre (EPIC) et de l'espace (APOD)

- mise en place du projet Blazor, connection du projet sur github, et premiers pushs.

28/02 : instaurer la clé d'api, et appréhender un peu le fonctionnement

04/03 : organisation du planning et des objectifs, et lecture de la documentation:
V   - mettre en place une page minimum, qui affichera les images, les dates et les textes liès aux "images of the day" de la nasa
V   - mettre une option pour choisir une date, et que ça affiche l'image de cette date
V   - mettre une option pour faire apparaitre une "date aléatoire" qui affichera l'image et les infos du jour tiré au hasard
- mettre en place un système de favoris, avec un bouton toggle, qui regroupera tous les favoris
- ajouter une page qui permetra de revoir tous les favoris "enregistrés"
- ajouter l'option de supprimer des favoris
- mise en page, et habillage
- ajout de la deuxième api EPIC

