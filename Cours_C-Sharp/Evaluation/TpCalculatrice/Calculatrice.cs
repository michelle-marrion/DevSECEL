using System;

namespace TpCalculatrice
{
    public class Calculatrice
    {
        public int Addition(int  nb1, int nb2)
        {
            return nb1 + nb2;
        }
        public int Soustraction(int  nb1, int nb2)
        {
            return nb1 - nb2;
        }
        public int Multiplication(int  nb1, int nb2)
        {
            return nb1 * nb2;
        }
        public int Division(int  nb1, int nb2)
        {
            
            int resultat = 0;
            if(nb2 != 0)
            {
                resultat = nb1 / nb2 ;
                return resultat ;
            }
            else
            {
                Console.WriteLine("division mpossible") ;
                return resultat ;
            }
            
        }
   
        public int Modulo(int  nb1, int nb2)
        {
            int resultat = 0;
            if(nb2 != 0)
            {
                resultat = nb1 % nb2 ;
            }
            return resultat ;
        }
    }
}
