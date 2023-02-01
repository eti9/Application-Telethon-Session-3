using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppTelethon
{
    /// <summary>
    /// Class <c>Personne</c>, classe abstraite contenant un prenom et un surnom.
    /// </summary>
    internal class Personne
    {
        //Champs de la classe
        /// <summary>
        /// Le prenom de la personne.
        /// </summary>
        private string prenom;
        /// <summary>
        /// Le surnom de la personne.
        /// </summary>
        private string nom;
        /// <summary>
        /// Le telephone de la personne
        /// </summary>
        private string telephone;
        /// <summary>
        /// Le ID de la personne 
        /// </summary>
        private string id;

        //Constructeur de la classe
        
        /// <summary>
        /// Constructeur par paramètre de Personne
        /// </summary>
        /// <param name="prenom">Le prenom de la personne.</param>
        /// <param name="surnom">Le surnom de la personne.</param>
        public Personne(string prenom, string nom, string telephone, string id)
        {
            this.prenom = prenom;
            this.nom = nom;
            this.telephone = telephone;
            this.id = id;
        }
        /// <summary>
        /// Constructeur par copy de la classe Personne.
        /// </summary>
        /// <param name="personne">La personne a copier.</param>
        public Personne(Personne personne)
        {
            this.prenom = personne.prenom;
            this.nom = personne.nom;
            this.telephone = personne.telephone;
            this.id = personne.id;
        }


        //Getters and setters
        /// <summary>
        ///Getters, Setters pour le champs prenom 
        /// </summary>
        public string Prenom
        {
            get { return this.prenom; }
            set { this.prenom = value; }
        }
        /// <summary>
        /// Getters, Setters pour le champs surnom
        /// </summary>
        public string Nom
        {
            get { return this.nom; }
            set { this.nom = value; }
        }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Id { get => id; set => id = value; }

        //Methode ToString et Equals
        public override string ToString()
        {
            return 
                "Prenom: " + this.prenom.Substring(0, 1).ToUpper() + this.prenom.Substring(1) +
                ", Nom: " + this.nom.Substring(0,1).ToUpper() + this.nom.Substring(1)+ 
                ", Telephone: (" + telephone.Substring(0,3)+") "+telephone.Substring(3,3)+"-"+telephone.Substring(6);
        }

        public override bool Equals(object obj)
        {
            return obj is Personne personne &&
                   prenom == personne.prenom &&
                   nom == personne.nom &&
                   telephone == personne.telephone;
        }
    }
}
