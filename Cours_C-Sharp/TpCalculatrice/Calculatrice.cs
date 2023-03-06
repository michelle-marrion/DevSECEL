using System;
using TpCalculatrice.Operations ;

namespace TpCalculatrice
{
    
    public class Calculatrice
    {
       public Operation Operation{get; set;}
    
        // Constructeur
        public Calculatrice(Operation operation)
        {
            this.Operation = operation ; 
        }
        // methodes
        public void Executer()
        {
            /* Pattern matching
            if(Operation is Addition add)
            {
                add.Executer();
            }
            else if(Operation is Soustraction sous)
            {
                sous.Executer();
            }
            else if(Operation is Multiplication multi)
            {
                multi.Executer();
            }
            else if(Operation is Division div)
            {
                div.Executer();
            }
            else if(Operation is Modulo mod)
            {
                mod.Executer();
            }
            else
            {
               Console.WriteLine("Opération non reconnu !");
            }*/
            Operation.Executer(); 
        }
    }
}
