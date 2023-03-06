using System;

namespace TpCalculatrice.Operations
{
    public class Multiplication : Operation
    {
        public Multiplication(int operandeGauche, int operandeDroite)
        :base(operandeGauche,operandeDroite)
        {
        }
// executer
        public override void Executer()
        {
            this.Resultat = OperandeGauche * OperandeDroite ;
        }
    }
}
