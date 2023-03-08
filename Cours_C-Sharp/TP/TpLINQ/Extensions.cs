using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TpLINQ
{
    public static class Extensions
    {
        public static int ComptePair(this int[] data)
        {
            int count = 0 ;
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] % 2) == 0)
                {
                    count = count + 1;
                }
            }
            return count ;
        }
        public static int LengthTableau(this int[] data)
        {
            int count = 0 ;
            for (int i = 0; i < data.Length; i++)
            {
                count ++;
                // count +=1; or count = count + 1 ;

            }
            return count ;
        }
    }
}