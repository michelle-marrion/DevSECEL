// string value1 = "a";
// string value2 = "A ";
// value2 = value2.Trim();
// value1 = value1.ToUpper();

// if (value1 == value2)
// {
//     value1 = value1.ToLower();
//     Console.WriteLine($"{value1} est égale à {value2}  en majuscule .....");
// }
// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "heads" : "tails");

// // Dans ce défi, vous allez implémenter des règles métier qui restreignent l’accès aux utilisateurs en fonction de leurs autorisations et de leur niveau. Vous affichez un message différent à l’utilisateur en fonction de ses autorisations et de son niveau.
// string permission = "Admin|Manager";
// int level = 12;

// if((permission.Contains("Admin")) && (level > 55))
// {
//     Console.WriteLine("Welcome, Super Admin user.");
// }
// else if ((permission.Contains("Admin")) && (level <= 55))
// {
//     Console.WriteLine("Welcome, Admin user.");
// }
// else if ((permission.Contains("Manager")) && (level >= 20))
// {
//     Console.WriteLine("Contact an Admin for access.");
// }
// else if ((permission.Contains("Manager")) && (level < 20))
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }
// else if ((permission.Contains("Manager")) || ((permission.Contains("Admin"))))
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }
// else
// {
//     Console.WriteLine("sorry.....");
// }

// string permission = "Admin|Manager";
// int level = 53;

// if (permission.Contains("Admin"))
// {
//     if (level > 55)
//     {
//         Console.WriteLine("Welcome, Super Admin user.");
//     }
//     else
//     {
//         Console.WriteLine("Welcome, Admin user.");
//     }
// }
// else if (permission.Contains("Manager"))
// {
//     if (level >= 20)
//     {
//         Console.WriteLine("Contact an Admin for access.");
//     }
//     else
//     {
//         Console.WriteLine("You do not have sufficient privileges.");
//     }
// }
// else
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }