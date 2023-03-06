// See https://aka.ms/new-console-template for more information

using TpCalculatrice ;
using TpCalculatrice.Operations ;

Console.WriteLine("------- Hello! ------- \n Bienvenue dans la Calculatrice ");

// Calculatrice Cal = new Calculatrice();
/* Autre déclaration
Console.WriteLine("veuilles entrer le premier nombre :") ;
Cal.OperandeDroite = int.Parse(Console.ReadLine());

Console.WriteLine("veuilles entrer le premier nombre :") ;
Cal.OperandeGauche = int.Parse(Console.ReadLine());
Calculatrice Cal = new Calculatrice(nb1, nb2);
*/
int GetIntValue(string valeur)
{
    int? result = null;
    while (!result.HasValue)
    {
        Console.WriteLine($"saisissez la {valeur} valeur entière");
        string? value1 = Console.ReadLine();
        if(value1 is not null)
        {
            try
            {
                result= int.Parse(value1);
            }
            catch
            {
                
               result = null;
            }
            
        }       
    }
    return result.Value;
}
// Console.WriteLine("veuillez entrer le premier nombre :") ;
// // int nb1 = int.Parse(Console.ReadLine());
// int nb1 = 0;
// string? value1 = Console.ReadLine();
// if(value1 is not null)
// {
//     nb1 = int.Parse(value1);

// Console.WriteLine("veuillez entrer le second nombre :") ;
// // int nb2 = int.Parse(Console.ReadLine());
// int nb2 = 0 ;
// string? value2 = Console.ReadLine();
// if(value2 is not null)
// {
//     nb2 = int.Parse(value2);

// }
int nb1 = GetIntValue("premier");
int nb2 = GetIntValue("deuxième");
Console.WriteLine("Saisissez l'operateur C# à exécuter :");
string? operateur = Console.ReadLine();

Operation operation ;
Operation secondOperation;
if (operateur == "+")
{
      operation = new Addition(nb1,nb2);
      secondOperation = new Addition(nb1,nb2);
      Console.WriteLine($"Addition égales? {operation.Equals(secondOperation)}");
      // Cal.Resultat = Cal.Addition();
      Calculatrice Cal = new Calculatrice(operation);
      Cal.Executer();
      Console.WriteLine($"le résultat : {Cal.Operation.ToString()} = {Cal.Operation.Resultat}");
}
else if (operateur == "-")
{
      operation = new Soustraction(nb1,nb2);
      // Cal.Resultat = Cal.Soustraction();
      Calculatrice Cal = new Calculatrice(operation);
      Cal.Executer();
      Console.WriteLine($"le résultat : {Cal.Operation.ToString()} = {Cal.Operation.Resultat}");
}
else if (operateur == "*")
{
      operation = new Multiplication(nb1,nb2);
      // Cal.Resultat = Cal.Multiplication();
      Calculatrice Cal = new Calculatrice(operation);
      Cal.Executer();
      Console.WriteLine($"l'opération de {nb1} {operateur} {nb2} est : {Cal.Operation.Resultat}");
}
else if (operateur == "%")
{
      operation = new Modulo(nb1,nb2);
      // Cal.Resultat = Cal.Modulo();
      Calculatrice Cal = new Calculatrice(operation);
      Cal.Executer();
      Console.WriteLine($"l'opération de {nb1} {operateur} {nb2} est : {Cal.Operation.Resultat}");
}
else if (operateur == "/")
{
      operation = new Division(nb1,nb2);
      // Cal.Resultat = Cal.Division();
      Calculatrice Cal = new Calculatrice(operation);
      Cal.Executer();
Console.WriteLine($"l'opération de {nb1} {operateur} {nb2} est : {Cal.Operation.Resultat}");
}
            string value = "Microsoft Learn";
            string reversedValue = TpCalculatrice.Utilities.Utility.Reverse(value);
            Console.WriteLine($"Secret message: {reversedValue}");
            
            // simplification des blocs
            string name = "steve";
            if (name == "bob") Console.WriteLine("Found Bob");
            else if (name == "steve") Console.WriteLine("Found Steve");
            else Console.WriteLine("Found Chuck");
            int[] numbers =  {4, 8, 15, 16, 23, 42} ;
            int total = 0;
            bool found = false ;

            foreach(int number in numbers)
            {
            total += number;
            if(number == 42) found = true ;
            }
            if (found) Console.WriteLine("Set contains 42");
            Console.WriteLine($"Total: {total}");

         
            
            int[] numbers2 =  {4, 8, 15, 16, 23, 42} ;
            int totals = 0;
            bool founds = false ;

            foreach(int number in numbers2)
            {
            total += number;
            if(number == 42) founds = true ;
            }
            if (founds) Console.WriteLine("Set contains 42");
            Console.WriteLine($"Total: {totals}");
   // Switch case
   // SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");

// bouche for
/* 
Règles FizzBuzz :

Valeurs de sortie comprises entre 1 et 100, un nombre par ligne.
Quand la valeur actuelle est divisible par 3, afficher le terme Fizz en regard du nombre.
Quand la valeur actuelle est divisible par 5, afficher le terme Buzz en regard du nombre.
Quand la valeur actuelle est divisible à la fois par 3 et par 5, afficher le terme FizzBuzz en regard du nombre.

*/
for(int i=1; i<=100; i++)
{
   Console.Write(i);
   if(( i % 3) == 0)
    Console.WriteLine($" - Fizz");
   else if((i % 5) == 0)
   Console.WriteLine(" - Buzz");
   else if(((i % 5) == 0) && ((i % 3) == 0) )
   Console.WriteLine(" - FizzBuzz");

   Console.WriteLine("");
}
// do-while and while
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
// Type signé et type non signé
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
Console.WriteLine($"int  : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"decimal  : {decimal.MinValue} to {decimal.MaxValue}");
Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// order namespace

namespace TpCalculatrice.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}
