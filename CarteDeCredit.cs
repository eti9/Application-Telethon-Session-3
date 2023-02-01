using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppTelethon
{
    internal class CarteDeCredit
    {
        //Constante 
        public const char MASTERCARD = 'M';
        public const char VISA = 'V';
        public const char AMERICAN_EXPRESS = 'A';

        //Variable
        /// <summary>
        /// Le numero de la carte de credit
        /// </summary>
        private string numeroCarte;
        /// <summary>
        /// Le numero de securtie de la carte de credit
        /// </summary>
        private string numeroSecurite;
        /// <summary>
        /// La date d'expiration de la carte de credit
        /// </summary>
        private DateTime dateExpiration;
        /// <summary>
        /// Le type de carte de credit M, V ou A
        /// </summary>
        private char typeCarte;

        //Constructeur parametre
        [JsonConstructor]
        public CarteDeCredit(string numeroCarte, string numeroSecurite, DateTime dateExpiration, char typeCarte)
        {
            this.numeroCarte = numeroCarte;
            this.numeroSecurite = numeroSecurite;
            this.dateExpiration = dateExpiration;
            this.typeCarte = typeCarte;
        }
        
        //Constructeur par copy
        public CarteDeCredit(CarteDeCredit autre)
        {
            this.numeroCarte = autre.numeroCarte;
            this.numeroSecurite = autre.numeroSecurite;
            this.dateExpiration = autre.dateExpiration;
            this.typeCarte = autre.typeCarte;
        }

        //GETTERS N SETTERS
        public string NumeroCarte { get => numeroCarte; set => numeroCarte = value; }
        public string NumeroSecurite { get => numeroSecurite; set => numeroSecurite = value; }
        public DateTime DateExpiration { get => dateExpiration; set => dateExpiration = value; }
        public char TypeCarte { get => typeCarte; set => typeCarte = value; }

        //Equals et ToString
        public override bool Equals(object obj)
        {
            return obj is CarteDeCredit credit &&
                   numeroCarte == credit.numeroCarte &&
                   numeroSecurite == credit.numeroSecurite &&
                   dateExpiration == credit.dateExpiration &&
                   typeCarte == credit.typeCarte;
        }
        public override string ToString()
        {
            string result = "";
            switch (typeCarte)
            {
                case 'M':
                    result += "Mastercard: ";
                    break;
                case 'A':
                    result += "American express: ";
                    break;
                case 'V':
                    result += "Visa: ";
                    break;
            }
            result += numeroCarte.Substring(0,4)+"********"+numeroCarte.Substring(12,4) + "\nDate d'expiration " + dateExpiration;
            return result;
        }
    }
}
