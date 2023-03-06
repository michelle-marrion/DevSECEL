// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("J'apprend le C#");

// Console.WriteLine("entrer un nombre :");
// string saisie = Console.ReadLine();

// Console.WriteLine(saisie);
// Convertion de type

int numbre = 42;
string number = numbre.ToString();

int numero = Convert.ToInt32(number);

Console.WriteLine($"{numbre}=={number} == {numero}");
string name;
int age ;

Console.WriteLine("veuillez entrez votre nom :") ;
name = Console.ReadLine();
Console.WriteLine("veuillez entrez votre age :") ;
string value = Console.ReadLine();
age = Convert.ToInt32(value) ;
// ou age = int.Parse(value);
// ou age = int.Parse(Console.ReadLine());
Console.WriteLine($"Bonjour {name}, vous avez {age} ans");

// TABLEAU

int[] tableNumbers = {2,4,5,7,10};

// Parcourir un tableau
int position = 0 ;
foreach (var num in tableNumbers)
{
      position += 1 ;
      Console.WriteLine($"valuer {position} : {num}");
}
Console.WriteLine($"la taille du tableau est de {position}");

// Les Listes
List<string> chaines = new List<string>();
chaines.Add("Michelle");
chaines.Add("Marie");
chaines.Add("Marrion");
chaines.Add("Marcelle");
chaines.Add("Marilise");
chaines.Add("Merveille");
position = 0 ;
foreach (var chaine in chaines)
{
      position += 1;
      Console.WriteLine($"valuer {position} : {chaine}");

}
// Utilisation de la boucle for
var lenght = tableNumbers.Length;
// position = 0 ;
for (int i = 0; i <lenght; i++)
{
      //  position += 1;
      Console.WriteLine($"valuer {i + 1} : {tableNumbers[i]}");
}
// Tanque faire
Console.WriteLine($"\n Utilisaation de la boucle tant que");
position = 0 ;
Console.WriteLine ($"la longueur du tableau est de : {lenght}");
while (position<lenght)
{
      position += 1;

      Console.WriteLine($"valuer {position + 1} : {tableNumbers[position]}");
      // break ;
}
// 