using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace TpLINQ
{
    public class MaListe : IEnumerable<int>
    {
        // private int taille ; 
        private MaListeEnumerator enumerator ;
        public MaListe(int taille)
        {
            enumerator = new MaListeEnumerator(taille) ;
        } 
        public IEnumerator<int> GetEnumerator()
        {
            return enumerator;
        }   
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }   
    }
    
}