// using System;

// namespace TpCalculatrice
// {
    
//     public class Calculatrice
//     {
//         // membres
//         public int operandeGauche ;
//         public int operandeDroite;
//         public int resultat ;
//         // propriétés
//         public int OperandeDroite { get; set; }
//         public int OperandeGauche{get; set;}
//         public int Resultat { get; set; }
//         //contructeur par défaut
//         public Calculatrice()
//         {
//             this.OperandeDroite = 0;
//             this.OperandeGauche = 0;
//         } 
//         // Constructeur
//         public Calculatrice(int operandeGauche, int operandeDroite)
//         {
//             this.OperandeDroite = operandeDroite ;
//             this.OperandeGauche = operandeGauche ; 
//         }
//         // methodes
//         public int Addition()
//         {
//             return Resultat = OperandeDroite + OperandeGauche;
//         }
//         public int Soustraction()
//         {
//            return Resultat = OperandeDroite - OperandeGauche;
//         }
//         public int Multiplication()
//         {
//             return Resultat = OperandeDroite * OperandeGauche ;
//         }
//         public int Division()
//         {
//             Resultat = 0 ;
//             if(OperandeGauche != 0)
//             {
//                 Resultat = OperandeDroite / OperandeGauche;
//             }
//             return Resultat ;
//         }
   
//         public int Modulo()
//         {
//             Resultat = 0 ;
//             if(OperandeGauche != 0)
//             {
//                 Resultat = OperandeDroite % OperandeGauche ;
//             }
//             return Resultat ;
//         }
//     }
// }
