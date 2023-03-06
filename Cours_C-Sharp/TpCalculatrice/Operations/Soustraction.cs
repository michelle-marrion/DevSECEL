using System;

namespace TpCalculatrice.Operations
{
    public class Soustraction : Operation
    {
        // Constructeur
        public Soustraction(int operandeGauche, int operandeDroite)
        :base(operandeGauche,operandeDroite)
        {
        }

        // public int Resultat {get; set;}
        // Executer
        public override void Executer()
        {
            this.Resultat = OperandeGauche - OperandeDroite ;
        } 
    }
}
