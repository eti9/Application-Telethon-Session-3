using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppTelethon
{
    internal class Prix
    {
        //Variable 
        private int quantiteInitial;
        private int quantiteRestante;
        private double valeur;
        private int nbPtsRequis;
        private string nom;
        private string idCommanditaire;

        //Constructeur paramétré
        public Prix(int quantiteInitial, double valeur, string nom, int nbPtsRequis, string idCommanditaire) 
            : this(quantiteInitial, quantiteInitial, valeur, nom,  nbPtsRequis, idCommanditaire)
        {
            
        }
        
        
        [JsonConstructor]
        public Prix(int quantiteInitial, int quantiteRestante, double valeur, string nom, int nbPtsRequis, string idCommanditaire)
        {
            this.quantiteInitial = quantiteInitial;
            this.quantiteRestante = quantiteRestante;
            this.valeur = valeur;
            this.nbPtsRequis = nbPtsRequis;
            this.nom = nom;
            this.idCommanditaire = idCommanditaire;
        }
        public Prix(Prix prix)
        {
            this.quantiteInitial = prix.quantiteInitial;
            this.quantiteRestante = prix.quantiteRestante;
            this.valeur = prix.valeur;
            this.nbPtsRequis = prix.nbPtsRequis;
            this.nom = prix.nom;
            this.idCommanditaire = prix.idCommanditaire;
        }

        //Getters, Setters
        public double Valeur { get => valeur; set => valeur = value; }
        public string Nom { get => nom; set => nom = value; }
        public int NbPtsRequis { get => nbPtsRequis; set => nbPtsRequis = value; }
        public string IdCommanditaire { get => idCommanditaire; set => idCommanditaire = value; }
        public int QuantiteInitial { get => quantiteInitial; set => quantiteInitial = value; }
        public int QuantiteRestante { get => quantiteRestante; set => quantiteRestante = value; }





        //Equals et ToString
        public override bool Equals(object obj)
        {
            return obj is Prix prix &&
                   quantiteInitial == prix.quantiteInitial &&
                   quantiteRestante == prix.quantiteRestante &&
                   valeur == prix.valeur &&
                   nbPtsRequis == prix.nbPtsRequis &&
                   nom == prix.nom &&
                   idCommanditaire == prix.idCommanditaire;
        }
        public override string ToString()
        {
            string result = string.Empty;
            result += "  Nom: " + nom  +
                "\n, ID commanditaire: " + idCommanditaire +
                "\n, Valeur: " + valeur + 
                "$\n, Nombre de points requis: " + nbPtsRequis+
                "\n, Quantite initial: " + quantiteInitial+
                "\n, Quantite restante: " + quantiteRestante;
            return result;
        }
    }
}
