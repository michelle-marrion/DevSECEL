using System;

namespace CalculBoucle
{
    
    public class Calcul
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            int min = 1 ;
            int max = 10 ;
            Console.WriteLine("la somme d'entier consécutifs de"+min +" à "+ max +"est : "+ CalculSommeEntiers(min, max)) ; 
            
            List<double>  liste = new List<double> {1.0, 5.5, 9.9, 2.8, 9.6};
            double moyenne = CalculMoyenne(liste) ;
            Console.WriteLine($"La moyenne est de {moyenne}");
        
            // Console.WriteLine("la somme des entiers des deux listes est : "+);
             Console.WriteLine("\n \n");    
            SommeEntiersListes();

            Console.WriteLine("\n \n");   
            SommeEntiersCommunsListes();
             Console.WriteLine("\n \n");         
        }
        
        static int CalculSommeEntiers(int min, int max)
        {
            int somme = 0;
            if (min != max && min < max)
            {
                for(int i = min; i <= max; i++)
                {
                    somme += i;
                }  
            }
            else
            {
                Console.WriteLine("le premier nombre doit être plus grand que le dernier");
            }
            return somme ;
        }
        static double CalculMoyenne(List<double>  liste)
        {
            double moyenne = 0 ;
            double sum = 0.0 ;
            foreach (var value in liste)
            {
                sum += value ;
            }
            moyenne = sum / (liste.Count);
            return moyenne;
        }
        static void SommeEntiersListes()
        {
            List<int> liste1 = new List<int> {};
            List<int> liste2 = new List<int> {};
            int sum1 = 0 ;
            int sum2 = 0;
            for (int i = 1; i <= 100; i++)
            {
                liste1.Add((i*3));
            }
            for (int i = 1; i <= 100; i++)
            {
                liste2.Add((i*5));
            }
            Console.Write(" \t Liste 1 : ") ;
            foreach (var list1 in liste1)
            {
                sum1 += list1;
                // Enumération de la Liste
                Console.Write($"{list1}") ;
                Console.Write(" \t ") ;
            }

            Console.Write("\n \t Liste 2 : ") ;
            foreach (var list2 in liste2)
            {
                sum2 += list2;
                // Enumération de la Liste
                Console.Write($"{list2}") ;
                Console.Write(" \t ") ;
            }
            Console.WriteLine("\n");    
            Console.WriteLine($"La somme des entiers des deux listes est : {(sum1 + sum2)}") ;

        }
        static void SommeEntiersCommunsListes()
        {
            List<int> liste1 = new List<int> {};
            List<int> liste2 = new List<int> {};
            int sum = 0 ;
            Console.WriteLine("liste 1 : ") ;
            for (int i = 1; i <= 100; i++)
            {
                if((i%3) == 0)
                {
                    liste1.Add((i));
                    Console.Write($"{i} \t");
                }
                // liste1.Add((i*3));
            }
            Console.WriteLine("\n liste 2 : ") ;
            for (int i = 1; i <= 100; i++)
            {
                 if((i % 5) == 0)
                {
                    liste2.Add((i));
                    Console.Write($"{i} \t");
                }
                // liste2.Add((i*5));
            }
            Console.Write(" \n \n les entiers communs : ") ;
            foreach (var list1 in liste1)
            {
                foreach (var list2 in liste2)
                {
                    if(list1 == list2)
                    {
                        sum += list1+list2;
                        Console.Write($"{list2} \t");
                    }  
                }
            
            }
           
            Console.WriteLine($"\n \n La somme des entiers communs aux des deux listes est : {sum}") ;

        }
    }
}
