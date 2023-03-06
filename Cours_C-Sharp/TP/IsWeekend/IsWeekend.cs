using System;

namespace IsWeekend
{
    public class IsWeekend
    {
        public static void Main(string[] args)
        {
            // string userName = Environment.UserName;
            string? userName ;
            Console.WriteLine("------------ Bienvenue dans notre programme ! ------------ ") ;
            Console.WriteLine("\n\n") ;
            Console.WriteLine("Comment vous appellez vous ? : ") ;
            userName = Console.ReadLine();
            Console.WriteLine("\n\n") ;
            // Quand sommes nous

            if(DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
            {
                // si on ait le Weekend
                Console.WriteLine($"Bon Weekend {userName} \n\n") ;
            }
            else
            {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Monday && DateTime.Now.Hour < 9 )
                {
                    //  si nous ne sommes pas Samedi, ni Dimanche, et que nous sommes lundi et qu'il ait moins de 8 heures du matin
                    Console.WriteLine($"Bon Weekend {userName} \n\n") ;
                }
                else
                {
                    if (DateTime.Now.Hour >= 9 && DateTime.Now.Hour < 18)
                    {
                        // si nous ne sommes ni le weekend, ni le lundi matin et que nous ai plus de 9h et moins de 18 h du soir
                        Console.WriteLine ($"Bonjour {userName} \n\n");
                    }
                    else
                    {
                        if (DateTime.Now.DayOfWeek == DayOfWeek.Friday && DateTime.Now.Hour > 18)
                        {
                            // si nous sommes Vendredi et qu'il ai plus de 18 heures du soir
                            Console.WriteLine($"Bon Weekend {userName} \n\n") ;
                        }
                        else
                        {
                            // si nous ne sommes vendredi soir, ni le Weekend et que nous sommes en soirée
                            Console.WriteLine($"Bonsoir {userName} \n\n") ;
                        }
                    }
                }
            }
        }
    }
}
