using System;

namespace CurrencyConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrencyConverter converter = new CurrencyConverter();

            Console.WriteLine("Bienvenue dans le convertisseur de devises!");

            try
            {
                // Demander le montant à convertir
                Console.Write("Entrez le montant à convertir : ");
                double amount = Convert.ToDouble(Console.ReadLine());

                // Demander la devise source
                Console.Write("Entrez la devise source (ex: USD, EUR) : ");
                string fromCurrency = Console.ReadLine().ToUpper();

                // Demander la devise cible
                Console.Write("Entrez la devise cible (ex: USD, EUR) : ");
                string toCurrency = Console.ReadLine().ToUpper();

                // Effectuer la conversion
                double convertedAmount = converter.Convert(amount, fromCurrency, toCurrency);

                // Afficher le résultat
                Console.WriteLine($"{amount} {fromCurrency} = {convertedAmount:F2} {toCurrency}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Le montant entré n'est pas un nombre valide.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
