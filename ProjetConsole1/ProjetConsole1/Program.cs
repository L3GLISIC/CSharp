using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom, prenom, email;

            Console.WriteLine("Ce programme vous souhaite la bienvenue");
            Console.WriteLine("Saisir votre nom");
            nom = Console.ReadLine();
            Console.WriteLine("Saisir votre prenom");
            prenom = Console.ReadLine();
            Console.WriteLine("Saisir votre email");
            email = Console.ReadLine();

            Console.WriteLine($"\nBonjour {prenom} {nom}, votre email est : {email}");
        }
    }
}