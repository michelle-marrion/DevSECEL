// using System;

// namespace TpCalculatrice
// {
    
//     public class Calculatrice
//     {
//         public int operandeGauche ;
//         public int operandeDroite;
//         public int resultat ;

//         public int OperandeDroite { get; set; }
//         public int OperandeGauche{get; set;}
//         public int Resultat { get; set; }
//         // public int operandeGauche
//         // {
//         //     get
//         //     {
//         //         return operandeDroite;
//         //     }
//         //     set
//         //     {
//         //         operandeDroite = 
//         //     } 
//         // }
//         // public int OperandeDroite
//         // {
//         //     get
//         //     {
//         //         return operandeDroite;
//         //     }
//         //     set
//         //     {
//         //         operandeDroite = 
//         //     } 
//         // }
//         public int Addition(int  nb1, int nb2)
//         {
//             return nb1 + nb2;
//         }
//         public int Soustraction(int  nb1, int nb2)
//         {
//             return nb1 - nb2;
//         }
//         public int Multiplication(int  nb1, int nb2)
//         {
//             return nb1 * nb2;
//         }
//         public int Division(int  nb1, int nb2)
//         {
//             int resultat = 0;
//             if(nb2 != 0)
//             {
//                 resultat = nb1 / nb2 ;
//             }
//             return resultat ;
//         }
   
//         public int Modulo(int  nb1, int nb2)
//         {
//             int resultat = 0;
//             if(nb2 != 0)
//             {
//                 resultat = nb1 % nb2 ;
//             }
//             return resultat ;
//         }
//     }
// }

// // Program.cs
// // See https://aka.ms/new-console-template for more information

// using TpCalculatrice ;
// Console.WriteLine("------- Hello! ------- \n Bienvenue dans la Calculatrice ");

// Console.WriteLine("veuilles entrer le premier nombre :") ;
// int nb1 = int.Parse(Console.ReadLine());

// Console.WriteLine("veuilles entrer le premier nombre :") ;
// int nb2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Saisissez l'operateur C# à exécuter :");

// string operateur = Console.ReadLine();

// Calculatrice Cal = new Calculatrice();
// int resultat = 0;
// if (operateur == "+")
// {
//       resultat = Cal.Addition(nb1,nb2);
// }
// else if (operateur == "-")
// {
//       resultat = Cal.Soustraction(nb1,nb2);
// }
// else if (operateur == "-")
// {
//       resultat = Cal.Soustraction(nb1,nb2);
// }
// else if (operateur == "*")
// {
//       resultat = Cal.Multiplication(nb1,nb2);
// }
// else if (operateur == "%")
// {
//       resultat = Cal.Modulo(nb1,nb2);
// }
// else if (operateur == "/")
// {
//       resultat = Cal.Division(nb1,nb2);
// }

// Console.WriteLine($"l'opération de {nb1} {operateur} {nb2} est : {resultat}");
