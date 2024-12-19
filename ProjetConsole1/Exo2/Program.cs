using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string saisie;
            bool verif = false;

            do
            {
                Console.WriteLine("Saisir votre age : ");
                saisie = Console.ReadLine();

                if(int.TryParse(saisie, out age)) {
                    verif = true;
                    Console.WriteLine(Apprecier(age));
                }
                else
                {
                    Console.WriteLine("Veuillez saisir un age valide");
                }

            } while (!verif);
        }
        /// <summary>
        /// Cette fonction permet d'apprecier un age
        /// </summary>
        /// <param name="age">Saisir age</param>
        /// <returns>retourner appreciation</returns>
        public static string Apprecier(int age)
        {
            if(age < 16) { return "Vous etes mineur."; }
            else if(age < 35) { return "Vous etes adolescent"; }
            else { return "Vous etes adulte"; }
        }
    }
}