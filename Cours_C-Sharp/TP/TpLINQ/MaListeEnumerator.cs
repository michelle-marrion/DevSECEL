using System;
using System.Collections;
namespace TpLINQ
{
      public class MaListeEnumerator : IEnumerator<int>
      {        
     
              private readonly int taille ;
        private int[] tableau ;
        private int index ; //permet de naviguer dans les �lements du tableau
        public MaListeEnumerator(int taille)
        {
            this.taille = taille;
            tableau = new int[taille];

            for (int i = 0; i < taille; i++)
            {
                tableau[i] = i + 1;
            }
        }

      object IEnumerator.Current => throw new NotImplementedException();
         
        public int Current => tableau[index];
      
        
        public void Dispose()
        {            
        }
        public bool MoveNext()
        { 
            if(index >= (taille - 1))
            {
                return false;
            }
            else
            {
                index = index + 1 ;
                return true;
            }
        }
        public void Reset()
        {
            //reset redefinir l'index � -1 afin de red�finir la boucle
            index = -1 ;
        }
      }
      
}