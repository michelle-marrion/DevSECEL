using System;

namespace TpCalculatrice.Operations
{
    public class Division : Operation
    {
        public Division(int operandeGauche, int operandeDroite)
        :base(operandeGauche,operandeDroite)
        {
        }
// executer
        public override void Executer()
        {
            if (OperandeDroite !=0)
            {
                this.Resultat = OperandeGauche / OperandeDroite ;
            }
            
        }
    }
}
