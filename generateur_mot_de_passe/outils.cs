namespace Outils // Définition du namespace contenant des outils utilitaires.
{
    public static class outilsPerso // Classe statique contenant des méthodes utilitaires.
    {
        // Méthode pour demander à l'utilisateur un nombre strictement positif (non nul).
        public static int DemanderNombrePositifNonNul(string question)
        {
            // Réutilise la méthode DemanderNombreEntre pour s'assurer que le nombre est supérieur ou égal à 1.
            return DemanderNombreEntre(question, 1, int.MaxValue);
        }

        // Méthode pour demander un nombre compris entre deux bornes incluses (min et max).
        public static int DemanderNombreEntre(string question, int min, int max)
        {
            // Appelle la méthode DemanderNombre pour récupérer un nombre saisi par l'utilisateur.
            int nombre = DemanderNombre(question);

            // Vérifie si le nombre est dans l'intervalle spécifié.
            if (nombre >= min && nombre <= max)
            {
                return nombre; // Retourne le nombre si valide.
            }

            // Informe l'utilisateur que sa saisie n'est pas valide.
            Console.WriteLine($"tu dois entrer un nombre entre {min} et {max}\n");

            // Rappelle la méthode récursivement pour demander une nouvelle saisie.
            return DemanderNombreEntre(question, min, max);
        }

        // Méthode privée pour demander un nombre à l'utilisateur.
        static int DemanderNombre(string question)
        {
            while (true) // Boucle infinie jusqu'à obtenir une entrée valide.
            {
                Console.WriteLine(question); // Affiche la question pour l'utilisateur.
                string? reponse = Console.ReadLine(); // Lit la réponse de l'utilisateur.

                // Essaie de convertir la réponse en entier.
                if (int.TryParse(reponse, out var reponseInt))
                {
                    return reponseInt; // Retourne l'entier si la conversion a réussi.
                }

                // Informe l'utilisateur que sa saisie n'est pas valide et continue la boucle.
                Console.WriteLine("Tu dois rentrer une longueur valide.\n");
            }
        }
    }
}
