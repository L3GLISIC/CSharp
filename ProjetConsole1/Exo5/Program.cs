internal class Program
{
    private static void Main(string[] args)
    {
        double montant;
        string saisie;
        bool verif = false;
        double franchise;
        double montantRembourse;

        do
        {
            Console.WriteLine("Saisir le montant a rembourser : ");
            saisie = Console.ReadLine();
            if(double.TryParse(saisie, out montant))
            {

                franchise = Franchise(montant);
                montantRembourse = MontantRembourse(montant, franchise);

                Console.WriteLine($"Montant : {montant} euro");
                Console.WriteLine($"Franchise : {franchise} euro");
                Console.WriteLine($"Montant a rembourse : {montantRembourse} euro");

                verif = true;
            }
            else
            {
                Console.WriteLine("Saisir un montant valide.");
            }
        } while (!verif);

    }

    /// <summary>
    /// Cette fonction retourne la franchise. Elle renvoie 10% de du montant si ces 10% n'excede pas 4000 euro, sinon 4000 euro
    /// </summary>
    /// <param name="montant">Saisir le montant</param>
    /// <returns>retourner franchise(<=4000)</returns>
    public static double Franchise(double montant)
    {
        double franchise = montant * 0.1;
        if(franchise > 4000)
        {
            return 4000;
        }
        return franchise;
    }

    /// <summary>
    /// Cette fonction retourne le montant a rembourse
    /// </summary>
    /// <param name="montant">Saisir Montant</param>
    /// <param name="franchise">Saisir Franchise</param>
    /// <returns>Retourner montant a rembourse</returns>
    public static double MontantRembourse(double montant, double franchise)
    {
        return montant - franchise;
    }
}