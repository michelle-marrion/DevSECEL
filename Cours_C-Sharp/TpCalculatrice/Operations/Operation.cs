using System;

namespace TpCalculatrice.Operations
{
    public abstract class Operation
    {
        // public int OperandeGauche{get;set;}
        // public int OperandeDroite{get;set;}
        protected int OperandeGauche{get;}
        protected int OperandeDroite{get;}

        // public int Resultat {get; set;}
        public int Resultat {get; protected set;}
        // CONSTRUCTEUR
        public Operation()
        {
            this.OperandeDroite = 0;
            this.OperandeGauche = 0;
        }
        public Operation(int operandeGauche, int operandeDroite)
        {
            this.OperandeDroite = operandeDroite ;
            this.OperandeGauche = operandeGauche ;
        }
        // public virtual void Executer()
        // {

        // }
        public abstract void Executer();
        // public override string ToString()
        // {
        //     return base.ToString();
        
        // }

    }
}
