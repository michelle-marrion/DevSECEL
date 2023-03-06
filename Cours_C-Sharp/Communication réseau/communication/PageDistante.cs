using System;

namespace communication
{
    public class PageDistante
    {
        // Se connecter a une ressource à partir de l'utl et afficher son contenu
        public static void Main(string[] args)
        {
            string chaineUrl = DonneeUtilisateur.DemanderUneUrl();
            Console.WriteLine(RecupererContenu(chaineUrl)) ;
            try
            {
                EcrireFichier(contenu, "output.txt") ;
            }
            catch (IOException e)
            {
                Console.WriteLine("Impossible d'ecrire dans le fichier - "+ e.ToString()) ;
            }
        }
        // Retourner l'URL
        public static string RecupererContenu(string url)
        {
            string contenu = "";
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    contenu = webClient.DownloadString(url);
                }
            }
            catch (WebException e)
            {
                
                Console.WriteLine("Impossible d'etablir une connexion -"+ e.ToString()) ;
            }
            return contenu ;
        }
        // Ecrire le contenu d'une variable dans un fichier
        pulic static void EcrireFichier(string  contenu, string nomFichier)
        {
            try
            {
                File.WriteAllText(nomFichier, contenu) ;
                Console.WriteLine("Ecriture terminée dans le fichier "+nomFichier) ;
            }
            catch (IOException e)
            {
                Console.WriteLine("Impossible d'ecrire dans le fichier -"+ nomFichier) ;
            }
        }
    }
}
 