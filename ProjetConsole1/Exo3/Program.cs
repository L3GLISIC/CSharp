using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string saisie;
            bool verif = false;
            string rep;

            do
            {
                do
                {
                    Console.WriteLine("Saisir le nombre : ");
                    saisie = Console.ReadLine();

                    if(int.TryParse(saisie, out n))
                    {
                        verif = true;
                        MultiplicationFor(n);
                    }else
                    {
                        Console.WriteLine("Veuillez saisir un nombre valide");
                    }
                } while (!verif);

                Console.WriteLine("Pour quitter, saisir Q");
                rep = Console.ReadLine();
                if(rep.ToUpper() == "Q")
                {
                    Console.WriteLine("Fin du programme");
                }
            } while (rep.ToUpper() != "Q");

            
        }

        /// <summary>
        /// Cette fonction permet d'aficher la table de multiplication en utilisant la boucle for
        /// </summary>
        /// <param name="n">Saisir la table</param>

        public static void MultiplicationFor(int n)
        {
            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }

        /// <summary>
        /// Cette fonction permet d'aficher la table de multiplication en utilisant la boucle while
        /// </summary>
        /// <param name="n"></param>
        public static void MultiplicationWhile(int n)
        {
            int i = 0;
            while(i <= 12)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
                i++;
            }
        }
        /// <summary>
        /// Cette fonction permet d'aficher la table de multiplication en utilisant la boucle do while
        /// </summary>
        /// <param name="n"></param>
        public static void MultiplicationDoWhile(int n)
        {
            int i = 0;

            do
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
                i++;
            } while (i <= 12);
        }
    }
}