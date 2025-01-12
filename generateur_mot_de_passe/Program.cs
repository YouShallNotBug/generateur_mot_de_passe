using Outils; // Importation d'un namespace personnalisé contenant des outils utilitaires.

namespace generateur_mot_de_passe // Définition du namespace pour le programme.
{
    class Program // Définition de la classe principale du programme.
    {
        static void Main(string[] args) // Point d'entrée du programme.
        {
            const int NB_MOTS_DE_PASSE = 10; // Nombre de mots de passe à générer.

            // Définition des ensembles de caractères utilisés pour créer les mots de passe.
            string minuscules = "abcdefghijklmnopqrstuvwxyz"; // Lettres minuscules.
            string majuscules = minuscules.ToUpper(); // Lettres majuscules (transformées à partir des minuscules).
            string chiffres = "1234567890"; // Chiffres.
            string caractersSpeciaux = "+§¢-%*#@0"; // Caractères spéciaux.
            
            // Variables utilisées pour stocker l'alphabet choisi et ses propriétés.
            string? alphabet = null; // Contient les caractères autorisés dans le mot de passe.
            int longueurAlphabet = 0; // Longueur de l'alphabet choisi.
            string motDePasse = ""; // Variable temporaire pour construire un mot de passe.
            
            Random rand = new Random(); // Générateur de nombres aléatoires.

            // Demande à l'utilisateur la longueur souhaitée pour le mot de passe.
            int longueurMdp = outilsPerso.DemanderNombrePositifNonNul("Longueur du mot de passe : ");
            Console.WriteLine();

            // Demande à l'utilisateur de choisir le type d'alphabet à utiliser.
            int choixAlphabet = outilsPerso.DemanderNombreEntre("Vous voulez un mot de passe avec : \n" +
                                                           "1 - Uniquement des caractères en minuscules\n" +
                                                           "2 - Des caractères minuscules et majuscules \n" +
                                                           "3 - Des caractères et des chiffres\n" +
                                                           "4 - Caractères, chiffres et caractères spéciaux\n" +
                                                           "Votre choix : ", 1, 4);

            // Sélection de l'alphabet basé sur le choix de l'utilisateur.
            switch (choixAlphabet)
            {
                case 1:
                    alphabet = minuscules; // Alphabet : uniquement des lettres minuscules.
                    longueurAlphabet = alphabet.Length; // Calcul de la longueur de l'alphabet.
                    break;
                case 2:
                    alphabet = minuscules + majuscules; // Alphabet : minuscules + majuscules.
                    longueurAlphabet = alphabet.Length;
                    break;
                case 3:
                    alphabet = minuscules + majuscules + chiffres; // Alphabet : lettres et chiffres.
                    longueurAlphabet = alphabet.Length;
                    break;
                case 4:
                    alphabet = minuscules + majuscules + chiffres + caractersSpeciaux; // Alphabet complet.
                    longueurAlphabet = alphabet.Length;
                    break;
            }

            // Génération des mots de passe.
            for (int n = 0; n < NB_MOTS_DE_PASSE; n++) // Générer NB_MOTS_DE_PASSE mots de passe.
            {
                motDePasse = ""; // Réinitialise le mot de passe pour chaque itération.
                for (int i = 0; i < longueurMdp; i++) // Construire un mot de passe de la longueur spécifiée.
                {
                    int index = rand.Next(0, longueurAlphabet); // Choisir un index aléatoire dans l'alphabet.
                    if (alphabet != null) motDePasse += alphabet[index]; // Ajouter le caractère correspondant.
                }
                Console.WriteLine($"Mot de passe : {motDePasse}"); // Afficher le mot de passe généré.
            }

            // Invite l'utilisateur à appuyer sur une touche avant de quitter.
            Console.WriteLine("\nAppuyez sur une touche pour quitter...");
            Console.ReadKey(); // Attente de l'entrée de l'utilisateur.
        }
    }
}
