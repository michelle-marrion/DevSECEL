// See https://aka.ms/new-console-template for more information

using System ;
Console.WriteLine(@"Hello!
      ------- Bienvenue dans notre Jeu : Deviner un nombre. -------
");

// Nombre Aléatoire definit par le système
Random choix = new Random();
int min = 10 ;
int max = 50 ;
int nombre = choix.Next(min,max);
int tentative = 0 ;
int value = 0 ;
// Console.WriteLine($"le nombre a deviné est :{nombre}");
while ((tentative < 5) && (value !=nombre))
{
      while (value < min || value > max )
      {
            Console.WriteLine($"Veuillez saisie un nombre entre {min} et {max} : ") ;
      
            try
            {
                  string? saisie = Console.ReadLine();
                  if(saisie is not null)
                  {
                        value = int.Parse(saisie);
                  }
                  
                  if ((value <= max) && value >=min )
                  {
                        if ( value == nombre)
                        {
                              Console.WriteLine($"Super !!! vous avez trouvez le nombre mystérieux qui est :{nombre}");
                        }
                  }
                  tentative +=1;
            }
            catch (System.Exception)
            {
                  Console.WriteLine("Vérifier votre saisie et continuer");
                  // throw;
            }
      }
      
}
if((tentative == 5) && (value != nombre))
{
      Console.WriteLine("Oups ..... vous n'avez plus de tentative. \n Désolée !!");
}