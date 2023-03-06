using System ;
namespace communication
{
      
      public class DonneeUtilisateur
      {
            public static void Main(string[] args)
            {
                  string chaineUrl = "";
                  int  nombreArgument;
                  if(args == null)
                  {
                        nombreArgument = 0;  
                  }
                  else
                  {
                        nombreArgument = args.Length;     
                  }
                   // affecter une valeur à chaineUrl ou quitter
                  switch (nombreArgument)
                  {
                        case 0 :
                              chaineUrl = DemanderUneUrl();
                              break ;
                        case 1 :
                              chaineUrl = args[0];
                              break ;
                        default:
                              Console.WriteLine("Veuillez exécuter le programme en spécifaint une URL ou aucun argument");
                              Environment.Exit(-1);
                              break;
                  }
                  Console.WriteLine($"Verification de l'URL{chaineUrl}");
                  if(URLValide(chaineUrl))
                  {
                        Console.WriteLine($"{chaineUrl} est une URL valide") ;
                  }else
                  {
                        Console.WriteLine($"{chaineUrl} n'est pasune URL valide") ;
                  }
            }
      //       / <summary>
      //   / Demander à l'utilisateur de saisir une URL
      //   / </summary>
      //   / <returns>Demander à l'utilisateur de saisir une URL</returns>
      public static string DemanderUneUrl()
      {
            Console.WriteLine("Veuillez saisir une URL valide");
            string url = Console.ReadLine();
            return url ;
      }
      // / <summary>
      //   / Vérifier le formatage d'une URL
      //   / </summary>
      //   / <param name="chaineUrl"></param>
      //   / <returns>vrai si le format correspond a une URL, sinon faux</returns>
      private static bool URLValide(string chaineUrl)
      {
            if (Uri.IsWellFormedUriString(chaineUrl, UriKind.Absolute))
            {
                  return true ;
            }
            else
            {
                  return false ;
            }
      }
      }
      
      
}