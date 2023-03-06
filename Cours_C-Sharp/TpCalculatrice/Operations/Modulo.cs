using System;

namespace TpCalculatrice.Operations
{
    public class Modulo : Operation
    {
        public Modulo(int operandeGauche, int operandeDroite)
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
