using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppTelethon
{
    /// <summary>
    /// Class <c>Commanditaire</c>  herite de <c>Personne</c>.
    /// </summary>
    internal class Commanditaire : Personne
    {
        //Constructeur de la classe
        /// <summary>
        /// Constructeur par paramètre de Commanditaire, appelle le constructeur de Personne.
        /// </summary>
        /// <param name="prenom"> Le nom du commanditaire.</param>
        /// <param name="surnom"> Le surnom du commanditaire.</param>
        /// <param name="idCommanditaire">Le ID du commanditaire.</param>
        [JsonConstructor]
        public Commanditaire(string prenom, string nom, string telephone, string id) : base(prenom, nom,  telephone,  id)
        {
        }
        /// <summary>
        /// Constructeur par copy de commanditaire, appelle le constructeur de Personne.
        /// </summary>
        /// <param name="commanditaire">Le commanditaire a copier.</param>
        public Commanditaire(Commanditaire commanditaire) : base(commanditaire)
        {
        }

        //Methode ToString et Equals
        public override string ToString()
        {
            return base.ToString();
        }
        public override bool Equals(object obj)
        {
            return obj is Commanditaire commanditaire &&
                   base.Equals(obj);
        }
    }
}
