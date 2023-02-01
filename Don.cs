using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppTelethon
{
    internal class Don
    {
        //Variable Static
        private static int compteur = 0;
        //Variable donateur
        private string idDon;
        private string dateDon;
        private double montant;
        private int valNbsPts;
        private string idDonateur;
        private string numeroCarteCredit;

        //Constructeur parametre
        [JsonConstructor]
        public Don(string idDon, string dateDon, double montant, int valNbsPts, string idDonateur, string numeroCarteCredit)
        {
            this.idDon = idDon;
            this.dateDon = dateDon;
            this.montant = montant;
            this.valNbsPts = valNbsPts;
            this.idDonateur = idDonateur;
            this.numeroCarteCredit = numeroCarteCredit;

        }
        //Constructeur par copy
        public Don(Don autre)
        {
            this.idDon = autre.idDon;
            this.dateDon = autre.dateDon;
            this.montant = autre.montant;
            this.valNbsPts = autre.valNbsPts; 
            this.idDonateur = autre.idDonateur;
            this.numeroCarteCredit = autre.numeroCarteCredit;
        }

        //Getters, Setters
        public string IdDon { get => idDon; set => idDon = value; }
        public string DateDon { get => dateDon; set => dateDon = value; }
        public double Montant { get => montant; set => montant = value; }
        public string IdDonateur { get => idDonateur; set => idDonateur = value; }
        public int ValNbsPts { get => valNbsPts; set => valNbsPts = value; }
        public string NumeroCarteCredit { get => numeroCarteCredit; set => numeroCarteCredit = value; }

        //Equals et ToString
        public override bool Equals(object obj)
        {
            return obj is Don don &&
                   idDon == don.idDon &&
                   dateDon == don.dateDon &&
                   montant == don.montant &&
                   idDonateur == don.idDonateur &&
                   numeroCarteCredit == don.numeroCarteCredit;
        }
        public override string ToString()
        {
            string result = string.Empty;
            result += "  ID don: " + idDon +
                "\n, ID donateur: "+idDonateur +
                "\n, Date du don: " + dateDon + 
                "\n, Montant: " + montant + 
                "$\n, Points gagner: "+valNbsPts + 
                "\n, No carte utilisé: "+numeroCarteCredit.Substring(0,4) + "********" + numeroCarteCredit.Substring(12,4);
            return result;
        }
    }
}
