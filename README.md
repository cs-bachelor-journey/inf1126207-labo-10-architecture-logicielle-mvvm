# Mise en application : Le motif d’architecture logicielle MVVM
**Séance 10** (Le 31/03/2026)

---

### Exercice 01 : Convertisseur de températures avec options avancées
**Objectif :** Ajouter une option permettant de forcer l'arrondi du résultat.  
**Consignes :**
1. Créer une `TextBox` pour saisir la température.
2. Ajouter deux boutons pour convertir vers Celsius ou Fahrenheit (via `RelayCommand`).
3. Ajouter une `CheckBox` (Arrondir le résultat), liée à une propriété bool du ViewModel.
4. Si la case est cochée, le résultat affiché doit être un nombre entier.
5. Ajouter une validation empêchant la conversion si la saisie est vide ou invalide.

---

### Exercice 02 : Gestionnaire de tâches avec priorisation
**Objectif :** Permettre à l’utilisateur de prioriser ses tâches.  
**Consignes :**
1. Créer une `ListBox` affichant les tâches.
2. Créer une `TextBox` pour saisir une nouvelle tâche.
3. Ajouter trois `RadioButton`s pour choisir une priorité (Basse, Moyenne, Haute).
4. Ajouter un bouton **Ajouter** qui déclenche une commande `AjouterTacheCommand`.
5. Les tâches ajoutées doivent indiquer leur priorité (ex: Haute, Moyenne, Basse).
6. Empêcher d'ajouter une tâche sans nom.

---

### Exercice 03 : Formulaire de connexion avec « Se souvenir de moi »
**Objectif :** Ajouter une option permettant de mémoriser le nom d'utilisateur.  
**Consignes :**
1. Ajouter les champs **Nom d'utilisateur** et **Mot de passe**.
2. Ajouter un bouton **Se connecter** lié à `ConnexionCommand`.
3. Ajouter une `CheckBox` (Se souvenir de moi), qui sauvegarde le nom d'utilisateur si cochée.
4. Empêcher la connexion si les champs sont vides.
5. Afficher un message d'erreur en cas d'échec de connexion.

---

### Exercice 04 : Sélecteur de produit avec garantie
**Objectif :** Permettre la sélection d'un produit et l'ajout d'une option de garantie.  
**Consignes :**
1. Créer une `ComboBox` affichant des produits (ex: Ordinateur, Smartphone, Tablette).
2. Afficher dynamiquement le prix du produit sélectionné.
3. Ajouter trois `RadioButton`s pour choisir la durée de garantie (1 an, 2 ans, 3 ans).
4. Ajouter une `CheckBox` (Activer la garantie), qui désactive les `RadioButton`s si décochée.
5. Ajouter un bouton **Acheter** (désactivé si aucun produit n’est sélectionné).

---

### Exercice 05 : Compteur avec option « double incrément »
**Objectif :** Ajouter une option pour incrémenter de 2 au lieu de 1.  
**Consignes :**
1. Créer un `Label` affichant la valeur du compteur.
2. Ajouter un bouton **Incrémenter** et un bouton **Décrémenter** liés à `RelayCommand`.
3. Ajouter une `CheckBox` (Incrémentation x2).
4. Si la case est cochée, le bouton **Incrémenter** ajoute +2 au lieu de +1.
5. Empêcher d’aller en dessous de 0 ou au-delà de 10.

---

### Exercice 06 : Système d'évaluation avec étoiles et « Anonyme »
**Objectif :** Permettre à l'utilisateur de noter un produit et de soumettre son avis anonymement.  
**Consignes :**
1. Ajouter cinq `RadioButton`s représentant les étoiles (★).
2. Ajouter une `CheckBox` (Laisser un avis anonyme).
3. Ajouter un champ `TextBox` pour le commentaire.
4. Si la case **Anonyme** est cochée, le champ **Nom** devient désactivé.
5. Ajouter un bouton **Valider**, qui est désactivé si la note est inférieure à 1 étoile.

---

### Exercice 07 : Formulaire d'inscription avec CGU
**Objectif :** Ajouter une case à cocher pour valider les conditions générales d'utilisation (CGU).  
**Consignes :**
1. Ajouter les champs suivants :
   - **Nom** (obligatoire)
   - **Email** (doit contenir `@`)
   - **Mot de passe** (minimum 6 caractères)
   - **Confirmation du mot de passe** (doit correspondre au mot de passe)
2. Ajouter une `CheckBox` (J'accepte les conditions générales d'utilisation).
3. Le bouton **S'inscrire** est désactivé tant que la case CGU n’est pas cochée.
4. Afficher les messages d'erreur sous chaque champ si la saisie est incorrecte.
