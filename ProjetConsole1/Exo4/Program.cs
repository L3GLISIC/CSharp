internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        string saisie;
        bool verif = false;

        do
        {
            Console.WriteLine("Saisir un entier positif : ");
            saisie = Console.ReadLine();

            if(int.TryParse(saisie, out n))
            {
                if(n < 0)
                {
                    Console.WriteLine("Vous devez saisir un entier positif.");
                }
                else
                {
                    Console.WriteLine($"Le factoriel de {n} est {Factoriel(n)}.");
                    verif = true;
                }
            }
            else
            {
                Console.WriteLine("Veuillez saisir un nombre valide");
            }
        } while (!verif);
    }

    /// <summary>
    /// Cette fonction permet de calculer le factoriel d'un nombre saisie
    /// </summary>
    /// <param name="n">Saisir un entier positif</param>
    /// <returns>Retourner le factoriel de cet entier positif </returns>
    public static int Factoriel(int n)
    {
        int fact = 1;
        for(int i = 1; i <= n; i++)
        {
            fact *= i;
        }
        return fact;
    }
}