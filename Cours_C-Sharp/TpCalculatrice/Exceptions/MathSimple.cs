// using System;

// namespace TpCalculatrice.Exceptions
// {
//     public class MathSimple
//     {
//         /// <summary>
//         /// Calculer la valeur moyenne d'une liste d'entiers
//         /// </summary>
//         /// <param name="listeDesEntiers">Une liste contenant des nombres entiers</param>
//         /// <returns>La moyenne de la liste</returns>
//         public static int CalculMoyenne(List<int> listeDesEntiers)
//         {
//             int moyenne= 0;
          
//             foreach (int valeur in listeDesEntiers)
//             {
//                 moyenne += valeur;
//             }
//             if(listeDesEntiers == 0)
//             {
//                 return 0 ;
//             }
//             else
//             {
//                 moyenne /= listeDesEntiers.Count;
//                 return moyenne;
//             }
            
//         }
//     }
// }
