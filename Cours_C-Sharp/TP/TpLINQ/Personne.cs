using System;
namespace TpLINQ
{
    public enum Sexe
    {
        Homme,
        Femme   
    }
    public class Personne
    {
        public string Nom {get; set;} = "";
        public string Prenom {get ; set ;} = "";
        public DateTime? DateNaissance {get; set;}
        public int TailleCm{get; set;}
        public Sexe Sexe{get; set;}
    }
}