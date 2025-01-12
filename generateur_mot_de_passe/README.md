
# 🎯 **Générateur de Mots de Passe**  
Ce projet est une application console développée en **C#** qui permet de générer plusieurs mots de passe personnalisés selon des critères définis par l'utilisateur.  
Il inclut une bibliothèque utilitaire pour gérer les interactions utilisateur.  

---

## ✨ **Fonctionnalités**  
- 🔑 **Génération de 10 mots de passe aléatoires**.  
- 🎨 **Options de personnalisation des caractères du mot de passe** :  
  - 🔡 Minuscules uniquement.  
  - 🔠 Minuscules et majuscules.  
  - 🔢 Minuscules, majuscules et chiffres.  
  - 🔒 Minuscules, majuscules, chiffres et caractères spéciaux.  
- ✅ **Validation des entrées utilisateur** pour éviter les erreurs de saisie.  
- 🔄 **Boucle robuste** pour demander des entrées valides en cas d'erreur.  

---

## 💻 **Prérequis**  
1. 🛠️ **.NET SDK** installé (version **6.0** ou supérieure recommandée).  
2. 🖥️ Un **IDE ou éditeur de texte** compatible avec C# (par ex. Visual Studio, Visual Studio Code).  

---

## 🚀 **Installation**  

### 1️⃣ Clonez le dépôt  
```bash
git clone https://github.com/YouShallNotBug/generateur_mot_de_passe.git
```  

### 2️⃣ Accédez à l'exécutable et lancez-le  
```bash
generateur_mot_de_passe\generateur_mot_de_passe\bin\Release\net9.0\generateur_mot_de_passe.exe
```  

---

## 🛠️ **Structure du Projet**  

- **`Program.cs`** :  
  Contient la logique principale du générateur de mots de passe.  
- **`Outils/outilsPerso.cs`** :  
  Une bibliothèque utilitaire contenant des méthodes pour valider et gérer les entrées utilisateur.  

---

## 🎨 **Personnalisation**  

Vous pouvez facilement personnaliser les ensembles de caractères en modifiant les variables suivantes dans le fichier `Program.cs` :  
- **`minuscules`** : Définit les lettres minuscules.  
- **`majuscules`** : Générées automatiquement à partir des minuscules.  
- **`chiffres`** : Définit les chiffres.  
- **`caractersSpeciaux`** : Définit les caractères spéciaux.  

---

## 🌟 **Améliorations Futures**  
- 💻 Ajouter une **interface graphique** pour une meilleure expérience utilisateur.  
- 💾 Enregistrer les mots de passe générés dans un **fichier texte**.  
- 🎯 Ajouter une option pour générer **un mot de passe unique à la fois**.  

---

## 🤝 **Contribution**  

Les contributions sont les bienvenues !  
- 🔧 Proposez des améliorations.  
- 🐞 Signalez des problèmes en ouvrant une issue.  
- 📨 Soumettez une pull request avec vos suggestions.  

---

## ⚖️ **Licence**  

Ce projet est sous licence **MIT**.  
Consultez le fichier [LICENSE](LICENSE) pour plus d'informations.  

---

## ✍️ **Auteur**  

Créé avec ❤️ par **YouShallNotBug**. 😊  
