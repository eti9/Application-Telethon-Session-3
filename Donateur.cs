using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppTelethon
{
    /// <summary>
    /// Classe <c>Donateur</c> herite de <c>Personne</c>
    /// </summary>
    internal class Donateur : Personne
    { 

        //Champs de la classe
        /// <summary>
        /// Le Email du donateur.
        /// </summary>
        private string email;
        /// <summary>
        /// Nombre de points du donateur
        /// </summary>
        private int ptsPrix = 0;
        /// <summary>
        /// Liste des cartes de credit du donateur
        /// </summary>
        private List<CarteDeCredit> cartecredits;


        //Constructeur de la classe
        
        
        /// <summary>
        /// Constructeur par paramètre du Donateur, appelle le constructeur de Personne.
        /// </summary>
        /// <param name="prenom">Le prenom du donateur.</param>
        /// <param name="surnom">Le surnom du donateur.</param>
        /// <param name="idDonateur">L'ID du donateur.</param>
        /// <param name="email">L'adresse du donateur.</param>
        /// <param name="telephone">Le telephone du donateur.</param>
        [JsonConstructor]
        public Donateur(string prenom, string nom, string email, string telephone, string id) : base(prenom, nom, telephone, id)
        {

            this.email = email;
            this.cartecredits = new List<CarteDeCredit>();
            this.ptsPrix = 0;

        }
        /// <summary>
        /// Constructeur par copye de la classe donateur, appelle le constructeur de Personne.
        /// </summary>
        /// <param name="donateur">Le donateur a copier.</param>
        public Donateur(Donateur donateur) : base(donateur)
        {
            this.email = donateur.email;
            this.cartecredits = new List<CarteDeCredit>();
            this.ptsPrix = donateur.ptsPrix;
            for (int i = 0; i < donateur.cartecredits.Count; i++)
            {
                this.cartecredits.Add(new CarteDeCredit(donateur.cartecredits[i]));
            }
            
        }

        //Getters et Setters
        /// <summary>
        /// Getters, setters pour le ID du donateur
        /// </summary>
        public string Email { get => email; set => email = value; }
        /// <summary>
        /// Getters liste de carte de crédit
        /// </summary>
        public List<CarteDeCredit> Cartecredits { get => cartecredits; set => cartecredits = value; }
        /// <summary>
        /// Getters nombre pts 
        /// </summary>
        public int PtsPrix { get => ptsPrix; set => ptsPrix = value; }
       

        //Methode ToString et Equals.

        public override string ToString()
        {
            string result = "";
            result += base.ToString()  + ", Email: " + email;
            return result;
        }

        public override bool Equals(object obj)
        {
            return obj is Donateur donateur &&
                   base.Equals(obj) &&
                   email == donateur.email;
        }
    }
}
