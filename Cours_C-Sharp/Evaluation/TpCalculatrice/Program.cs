// See https://aka.ms/new-console-template for more information

using TpCalculatrice ;

Console.WriteLine("------- Hello! ------- \n Bienvenue dans la Calculatrice ");

Console.WriteLine("Veuillez entrer un nombre : ");
Calculatrice Cal = new Calculatrice();
int nb1 = 4 ;
int nb2 = 2 ;
int resultat = resultat = Cal.Division(nb1,nb2);

Console.WriteLine($"l'opération de {nb1} / {nb2} est : {resultat}");