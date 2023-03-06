using System;

namespace JeuDuPendu
{
    public class Jeu
    {
        private Pendu pendu = new Pendu();

        public void LancerJeu()
        {
            Console.Clear();
            // Tant que la partie ni gagner, ni perdu, continuer

            while (pendu.GagneOuPerdu() == false)
            {
                // Console.Write($"Lettre testées :");
                // foreach (var lettre in pendu.lettresTestees)
                // {
                //     Console.Write($"{lettre}") ;
                // }
                Console.WriteLine(
                    $"Lettre testées : {string.Join(' ', pendu.lettresTestees)}");
                pendu.AfficherPendu() ;
                Console.WriteLine($"Mot actuel : {pendu.MotCourant}") ;
                Console.Write("Entrer une lettre : ");
                
                char saisie = RecupererSaisieUtilisateur() ;

                pendu.TesterLettre(saisie) ;
                
                Console.Clear() ;
            }

            GestionDinDeJeu();
        }
        // 
        private void GestionDinDeJeu()
        {
            Console.Clear();
            if(pendu.MotCourant == pendu.MotATrouver)
            {
                Console.WriteLine("Bravo, vous avez gagné !!!!!") ;
            }
            else
            {
                Console.WriteLine("Dommage, vous avez perdu !!!!!") ;
            }
            pendu.AfficherPendu();
            Console.WriteLine($"Le mot à trouver était : {pendu.MotATrouver}") ;
        }
        // Récupérer saisie Utilisateur
        private char RecupererSaisieUtilisateur()
        {
            char? saisie = null ;
            while (saisie.HasValue == false)
            {
                try
                {
                    var consoleSaisie = Console.ReadLine();
                    if (string.IsNullOrEmpty(consoleSaisie) ==false)
                    {
                        saisie = char.Parse(Console.ReadLine());
                    }
                    else
                    {
                        saisie = null ;
                    }    
                }
                catch
                {        
                   saisie = null ;
                }
            }
            return saisie.Value ;
        }
    }
}