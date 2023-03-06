using System;

namespace TpCalculatrice.Operations
{
    public class Addition : Operation
    {
        public Addition(int operandeGauche, int operandeDroite)
        :base(operandeGauche,operandeDroite)
        {
        }
        // executer
        public override void Executer()
        {
            this.Resultat = OperandeGauche + OperandeDroite ;
        }
        public override string ToString()
        {
            return $"{OperandeGauche} + {OperandeDroite}" ;
        }
        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }
            if (obj is Addition add)
            {
                return add.OperandeDroite == OperandeDroite
                && add.OperandeGauche == OperandeGauche ;   
            }
            else
            {
                return false ;
            }
            
        }
    }
}
