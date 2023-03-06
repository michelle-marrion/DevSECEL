using System;

namespace JeuDuPendu
{
    public class Pendu
    { 
        // Listes des mots possibles du Pendu
        private List<string>  mots = new List<string>
        {
            "souris",
            "maison",
            "ouragan",
            "vacances",
            "chameau",
            "chalumeau",
            "piano",
            "ordinateur"
        };
       
        private int NbEssaiMax = 7 ;
        private int NbEssai = 0 ;
        
        // Listes des caracteres tester
        public List<char> lettresTestees {get;} = new List<char>();
        // Mot à trouver 
        public string MotATrouver { get; private set;}
        // Le mot courant
        public string MotCourant{get; private set;}
        // Constructeur

        public Pendu ()
        {
            var r =  new Random();
            var idx = r.Next(8);
            MotATrouver = mots[idx];
            // for (int i = 0; i < MotATrouver.Length; i++)
            // {
            //     MotCourant = MotCourant + "-" ;
            // }
            MotCourant = string.Concat(Enumerable.Repeat('-', MotATrouver.Length)) ;
        }
        // Gagner ou perdre
        public bool GagneOuPerdu()
        {
            return (MotCourant == MotATrouver) || (NbEssai >= NbEssaiMax);
        }
        public void TesterLettre(char c)
        {
            if (lettresTestees.Contains(c))
            {
                return;
            }
            lettresTestees.Add(c);
            var copie = MotCourant.ToArray();
            bool trouver = false ;
            for (int i= 0 ; i <= MotATrouver.Length ; i++)
            {
                var caractere = MotATrouver[i] ;
                if (caractere == c)
                {
                    copie[i] = c ;
                    trouver = true ;
                }
            }
            if(trouver == true)
            {
                MotCourant = new string(copie) ;
            }
            else
            {
                NbEssai += 1;
            }
        }
        public void AfficherPendu()
        {
            var template = "  --------------     " + Environment.NewLine +
                             "    |        1       " + Environment.NewLine +
                             "    |        1       " + Environment.NewLine +
                             "    |       2 2'      " + Environment.NewLine +
                             "    |       2'2¤2      " + Environment.NewLine +
                             "    |      44355     " + Environment.NewLine +
                             "    |        3       " + Environment.NewLine +
                             "    |        3       " + Environment.NewLine +
                             "    |       6 7      " + Environment.NewLine +
                            @"   /|\     6   7     " + Environment.NewLine +
                            @"  / | \              " + Environment.NewLine +
                            @" /  |  \             ";
            for (int i = 1; i <= NbEssaiMax; i++)
            {
                if (NbEssai >= i)
                {
                    if(i != 2)
                    {
                        template = template.Replace(i.ToString(), i switch
                        {
                            1 => "|",
                            3 => "|",
                            4 => "-",
                            5 => "-",
                            6 => "/",
                            7 => "\\",
                            _ => ""
                        });
                    }
                    else
                    {
                            template = template
                                .Replace("2'", "\\")
                                .Replace("2¤", "_")
                                .Replace("2", "/");
                    }
                }
                else
                {
                    template = template.Replace(i.ToString(), i switch
                    {
                        4 => " ",
                        _ => ""
                    })
                    .Replace("'", "").Replace("¤", "");
                }

            }
            Console.Write(template);
            Console.WriteLine();
        }
    }
}
