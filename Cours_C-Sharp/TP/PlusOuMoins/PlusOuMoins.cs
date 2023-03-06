using System;

namespace PlusOuMoins
{
    public class PlusOuMoins
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" \n---___--- Bienvenue dans notre jeu du plus ou moins ---___---") ;
            // intanciation de la classe Random
            Random choix = new Random();
            // Borne du nombre aleatoire
            int borneInferieur = 0 ;
            int borneSuperieur = 100 ;
            // Choix du nombre aleatoire
            int nombreAleatoire = choix.Next(borneInferieur,borneSuperieur);
            Console.WriteLine($"{nombreAleatoire}");
            // Compteur de tour
            int compteurDeTour = 0 ;

            // Saisir de utilisateur
            int valeurUtilisateur = 0 ;
            string? saisie;
            do
            {
                Console.WriteLine($"Veuillez Saisir un nombre entre {borneInferieur} et {borneSuperieur} : ") ;
                
                try
                {
                     saisie = Console.ReadLine() ;
                    if (saisie is not null)
                    {
                        valeurUtilisateur = int.Parse(saisie);
                    }
                    /*
                    if ((valeurUtilisateur <= borneInferieur) && valeurUtilisateur >= borneSuperieur )
                    {
                        if ( valeurUtilisateur == nombreAleatoire)
                        {
                              Console.Write($"\n \n Super !!! vous avez trouvez le nombre mystérieux qui est : {nombreAleatoire}");
                        }
                    }
                    */
                    if (valeurUtilisateur < borneInferieur)
                    {
                     Console.WriteLine($"Trop petit ........") ;
                    }
                    else if(valeurUtilisateur > borneSuperieur)
                    {
                        Console.WriteLine($"Trop grand .......") ;
                    }
                    else if(valeurUtilisateur == nombreAleatoire)
                    {
                        Console.Write($"\n \n Super !!! vous avez trouvez le nombre mystérieux qui est : {nombreAleatoire}");
                    }
                  compteurDeTour +=1;  
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Vérifier votre saisie et continuer\n");
                }

            } while (valeurUtilisateur != nombreAleatoire );
            
            Console.Write($"\n nombre de tour jouer est de {compteurDeTour} \n     ") ;
        }
    }
}
