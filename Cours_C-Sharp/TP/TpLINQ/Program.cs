using System.Data;
// using Internal;
using System.Security;

using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

using System.ComponentModel.DataAnnotations.Schema;
// See https://aka.ms/new-console-template for more information
using TpLINQ;

Console.WriteLine("Hello, World!");
var liste =new MaListe(10);
foreach (var item in liste)
{
      Console.WriteLine(item);
}

Console.WriteLine("\n Méthodes d'extension \n");
int[] tab = new int[]{1,2,3,4,5,6,7,8,9,10} ;
System.Console.WriteLine(tab.ComptePair());
System.Console.WriteLine(tab.LengthTableau());

Console.WriteLine("Implémentation du Select de LINQ");

List<Personne> personnes = new()
{
      new() {Nom = "Dupont", Prenom ="Jean", TailleCm =175, Sexe = Sexe.Homme},
      new() {Nom = "Dupont", Prenom ="Jeanne", TailleCm = 156, Sexe = Sexe.Femme, DateNaissance = new(1956,2,7)},
      new() {Nom = "Thomas", Prenom ="Gérard", TailleCm = 185, Sexe = Sexe.Homme},
      new() {Nom = "Mommer", Prenom ="Megane", TailleCm = 169, Sexe = Sexe.Femme, DateNaissance = new(1990, 8,17)},
      new() {Nom = "Mommer", Prenom ="Christopher", TailleCm = 180, Sexe = Sexe.Homme, DateNaissance = new(1988, 12,18)}
};
List<string> nomsDeFamille = personnes.Select(p =>p.Nom).ToList();
var tailles = personnes.Where((p=>p.TailleCm >= 160));
foreach (var item in nomsDeFamille)
{
      Console.WriteLine(item) ;
}
Console.WriteLine(" taille supérieur à 160 cm ");
foreach (var item in tailles)
{
      Console.WriteLine(item.Nom) ;
}
Console.WriteLine(" Personnes ayant une date de naissance : ");
var personneAvecDateNaissance = personnes.Where(p=>p.DateNaissance is not null);
foreach (var item in personneAvecDateNaissance)
{
      Console.WriteLine($"{item.Nom} {item.Prenom} né(e) le {item.DateNaissance!.Value : dd/MM/yyyy} ") ;
}

Console.WriteLine("existance d'au moins une femme dans la liste de personne") ;
var existeFemme = personnes.Any(p=>p.Sexe == Sexe.Femme);
Console.WriteLine($"il existe une femme ? : {existeFemme}");
var nomPlusGrandQueTrois = personnes.Any(p=>p.Nom.Length > 3);
Console.WriteLine (" tous le monde à un nom de plus de 3 lettres ?" + nomPlusGrandQueTrois) ;

Console.WriteLine("Ordonner les personne par leur Prénom");
var ordonnerNom = personnes.OrderBy(p=>p.Nom).ThenBy(p=>p.Prenom);
foreach (var item in ordonnerNom)
{
      Console.WriteLine(item.Prenom + " " + item.Nom );
}