using System;
using System.Collections.Generic;

namespace CurrencyConverterApp
{
    public class CurrencyConverter
    {
        private Dictionary<string, double> rates = new Dictionary<string, double>();

        public CurrencyConverter()
        {
            // Initialiser les taux de change fictifs
            rates["USD"] = 1.0;    // Dollar américain comme devise de base
            rates["EUR"] = 0.85;   // Euro
            rates["GBP"] = 0.75;   // Livre sterling
            rates["JPY"] = 110.0;  // Yen japonais
            rates["CAD"] = 1.25;   // Dollar canadien
            rates["AUD"] = 1.30;   // Dollar australien
        }

        public double Convert(double amount, string fromCurrency, string toCurrency)
        {
            try
            {
                double fromRate = rates[fromCurrency];
                double toRate = rates[toCurrency];
                return amount * toRate / fromRate;
            }
            catch (KeyNotFoundException)
            {
                throw new Exception("Une ou plusieurs devises spécifiées ne sont pas prises en charge.");
            }
        }
    }
}
