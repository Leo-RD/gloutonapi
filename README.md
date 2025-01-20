# LE GUIDE DU GLOUTON

**LE GUIDE DU GLOUTON** est une application WPF (Windows Presentation Foundation) en C# qui permet d'explorer des informations nutritionnelles sur des produits alimentaires en scannant leur code-barres. Cette application s'appuie sur l'API OpenFoodFacts pour récupérer des informations détaillées sur les produits.

---

## Fonctionnalités principales

- **Scanner des codes-barres :** Récupérez instantanément des informations sur un produit alimentaire à partir de son code-barres.
- **Affichage des détails du produit :** Consultez les informations clés telles que :
  - Nom du produit
  - Marques
  - Ingrédients
  - Informations nutritionnelles (calories, lipides, glucides, etc.)
  - Labels et allergènes
- **Recherche manuelle :** Recherchez des produits en entrant un code-barres manuellement.
- **Interface intuitive :** Une interface utilisateur claire et simple d'utilisation.

---

## Prérequis

### Logiciels
- **Visual Studio 2022** ou version ultérieure
- **.NET 6.0** ou version ultérieure

### API
- Un compte sur [OpenFoodFacts](https://world.openfoodfacts.org/) (optionnel mais recommandé pour des requêtes API plus rapides).

---

## Installation

1. Clonez le dépôt :
   ```bash
   git clone https://github.com/votre-utilisateur/LE-GUIDE-DU-GLOUTON.git
   cd LE-GUIDE-DU-GLOUTON
   ```

2. Ouvrez le projet dans **Visual Studio**.

3. Restaurez les packages NuGet requis :
   - `Newtonsoft.Json` (pour la gestion des réponses JSON de l'API OpenFoodFacts)
   - `RestSharp` (pour les requêtes HTTP vers l'API)

4. Compilez et exécutez le projet.

---

## Utilisation

1. **Lancer l'application :**
   - Exécutez l'application depuis Visual Studio ou le fichier compilé.

2. **Scanner un code-barres :**
   - Connectez un scanner de codes-barres ou entrez un code-barres manuellement dans le champ prévu.

3. **Explorer les informations :**
   - Les détails du produit s'afficheront directement dans l'application.

---

## API OpenFoodFacts

Cette application utilise l'API publique d'OpenFoodFacts. Pour en savoir plus sur l'API, consultez la documentation officielle : [https://openfoodfacts.github.io/api-documentation/](https://openfoodfacts.github.io/api-documentation/).

### Exemple de requête API

Voici un exemple de requête pour récupérer les informations sur un produit :

```http
GET https://world.openfoodfacts.org/api/v0/product/{code-barres}.json
```

---

## Contributions

Les contributions sont les bienvenues ! Suivez les étapes ci-dessous pour participer :

1. **Forkez le dépôt**
2. **Créez une branche** pour vos modifications :
   ```bash
   git checkout -b feature/nom-de-la-fonctionnalite
   ```
3. **Commitez vos changements :**
   ```bash
   git commit -m "Ajout d'une nouvelle fonctionnalité"
   ```
4. **Poussez votre branche :**
   ```bash
   git push origin feature/nom-de-la-fonctionnalite
   ```
5. **Ouvrez une Pull Request**

---

## Licences

Ce projet est distribué sous la licence MIT. Consultez le fichier `LICENSE` pour plus de détails.

---

## Auteurs

- **Leo-RD** ([Votre GitHub](https://github.com/votre-utilisateur))

---



