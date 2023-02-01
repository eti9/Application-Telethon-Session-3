using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.IO;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Collections;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AppTelethon
{
    internal class GestionnaireSTE
    {
        //Constante
        public const int SESSIONDONATEUR = 0;
        public const int SESSIONCOMMANDITAIRE = 1;
        public const int NOSESSION = -1;
        public const string JSONFILE = @".\GestionnaireSTE.json";

        //Sequence pour les IDs
        [JsonProperty(Required = Required.AllowNull)]
        private static int compteur = 0;

        //Variable du gestionnaire
        private double montantObjectif = 100000;

        [JsonProperty(Required = Required.AllowNull)]
        private double montantAcqueris;

        [JsonProperty(Required = Required.AllowNull)]
        private string idSessionEnCours;

        [JsonProperty(Required = Required.AllowNull)]
        private int sessionState;

        //Liste d'objet
        [JsonProperty(Required = Required.AllowNull)]
        private Dictionary<string, Donateur> donateurs;

        [JsonProperty(Required = Required.AllowNull)]
        private Dictionary<string, Commanditaire> commanditaires;

        [JsonProperty(Required = Required.AllowNull)]
        private List<Don> dons;

        [JsonProperty(Required = Required.AllowNull)]
        private List<Prix> prix;


        //GETTERS SETTERS A RETIRER SEULEMENT POUR TESTER
        /*      public double MontantObjectif { get => montantObjectif; set => montantObjectif = value; }
              public double MontantAcqueris { get => montantAcqueris; set => montantAcqueris = value; }
              internal string IdSessionEnCours { get => idSessionEnCours; set => idSessionEnCours = value; }

              internal Dictionary<string, Donateur> Donateurs { get => donateurs; set => donateurs = value; }
              internal Dictionary<string, Commanditaire> Commanditaires { get => commanditaires; set => commanditaires = value; }
              internal List<Don> Dons { get => dons; set => dons = value; }
              internal List<Prix> Prix { get => prix; set => prix = value; }
      */
        
        public GestionnaireSTE()
        {
            idSessionEnCours = "";
            sessionState = -1;
            donateurs = new Dictionary<string, Donateur>();
            commanditaires = new Dictionary<string,Commanditaire>();
            dons = new List<Don>();
            prix = new List<Prix>();
            this.montantAcqueris = 0;
        }
        public GestionnaireSTE(GestionnaireSTE autre)
        {
            this.prix = autre.prix;
            this.dons = autre.dons;
            this.commanditaires = autre.commanditaires;
            this.donateurs = autre.donateurs;
            this.idSessionEnCours = autre.idSessionEnCours;
            this.sessionState = autre.sessionState;
            this.montantAcqueris = autre.montantAcqueris;
            this.montantObjectif = autre.montantObjectif;
        }

        //Methode pour ajouter, modifier ou supprimer des éléments de la liste
        public void ajouterDonateur(string prenom, string nom , string telephone, string email)
        {
            //On trim les string
            prenom = strip(prenom);
            nom = strip(nom);
            email = strip(email);

            //Verification des expressions regulieres
            verifRegex(prenom, nom, telephone, email);

            //On trim le telephone
            telephone = Regex.Replace(telephone, @"[ \-()]", "");
            //Verifie que le donateur n'existe pas
            for (int i = 0; i < donateurs.Count; i++)
            {
                if (nom == donateurs.ElementAt(i).Value.Nom && prenom == donateurs.ElementAt(i).Value.Prenom && telephone == donateurs.ElementAt(i).Value.Telephone)
                {
                    throw (new ExceptSTE(ExceptSTE.ERR_DUPVALUE,"Le donateur existe deja!"));
                }
            }

            //Travail de la methode
            string id = "DT" + compteur;
            compteur++;
            donateurs.Add(id,new Donateur(prenom, nom, email, telephone, id));

            //Saving...
            this.saveState();
        }
        public void ajouterCommanditaire(string prenom, string nom, string telephone)
        {
            //On trim les string
            prenom = strip(prenom);
            nom = strip(nom);

            //Verification des expressions regulieres
            verifRegex(prenom, nom, telephone);

            //On trim le telephone
            telephone = Regex.Replace(telephone, @"[ \-()]", "");

            //Verifie que le commanditaire n'exsite pas
            for (int i = 0; i < commanditaires.Count; i++)
            {
                if (nom == commanditaires.ElementAt(i).Value.Nom && prenom == commanditaires.ElementAt(i).Value.Prenom && telephone == commanditaires.ElementAt(i).Value.Telephone)
                {
                    throw (new ExceptSTE(ExceptSTE.ERR_DUPVALUE,"Le commanditaire existe deja!"));
                }
            }

            //travail de la methode
            string id = "COM" + compteur;
            compteur++;
            commanditaires.Add(id,new Commanditaire(prenom, nom, telephone, id));

            //Saving...
            this.saveState();


        }
        public void ajouterPrix(string nom, double valeur, int quantiteInitial,int nbPtsRequis)
        {
            //Verif de la methode
            verifSession(SESSIONCOMMANDITAIRE);
            if (quantiteInitial <= 0) throw new ExceptSTE(ExceptSTE.ERR_NOTENOUGH, "La quantite initial doit etre supperieur a 0.");
            if (valeur <= 0) throw new ExceptSTE(ExceptSTE.ERR_NOTENOUGH, "La valeur du prix doit etre supperieur a 0.");

            //Travail de la methode
            prix.Add(new Prix(quantiteInitial, valeur, nom, nbPtsRequis, idSessionEnCours));

            //Saving...
            this.saveState();
        }
        public void ajouterDon(string dateDon, double montant, int valNbsPts, int indexCarte)
        {
            //Verification...
            verifSession(SESSIONDONATEUR);

            //Verification du montant
            if (montant <= 0) throw new ExceptSTE(ExceptSTE.ERR_NOTENOUGH, "Le montant doit etre supperieur a 0.");

            //Strip la date au mois annees jours
            dateDon = dateDon.Substring(0, 10);

            //Travail de la methode
            string id = "DON" + compteur;
            compteur++;
            dons.Add(new Don(id, dateDon, montant, valNbsPts, idSessionEnCours, donateurs[idSessionEnCours].Cartecredits[indexCarte].NumeroCarte));
            this.montantAcqueris += montant;
            this.donateurs[idSessionEnCours].PtsPrix += valNbsPts;

            //Saving...
            this.saveState();
        }
        public void modifierDonateur(string prenom, string nom,  string telephone, string email)
        {
            //Vérification de la méthode
            verifSession(SESSIONDONATEUR);

            //On trim les string
            telephone = Regex.Replace(telephone, @"[ \-()]", "");
            prenom = strip(prenom);
            nom = strip(nom);
            email = strip(email);

            //Verification des expressions regulieres
            verifRegex(prenom, nom, telephone, email);


            //On ne continue pas si c'est pareil
            if (donateurs[idSessionEnCours].Equals(new Donateur(prenom, nom, email, telephone, donateurs[idSessionEnCours].Id))) return;


            //On cherche si les nouvelles informations existe deja dans la base de donnée
            for (int i = 0; i < donateurs.Count; i++)
            {
                if (nom == donateurs.ElementAt(i).Value.Nom && prenom == donateurs.ElementAt(i).Value.Prenom && telephone == donateurs.ElementAt(i).Value.Telephone)
                {
                    if (!donateurs.ElementAt(i).Key.Equals(idSessionEnCours))
                        throw (new ExceptSTE(ExceptSTE.ERR_DUPVALUE,"Vous essayer de modifier un donateur pour un donateur déjà existant dans la base de donnée!"));
                }
            }
            
            //Travail de la méthode
            this.donateurs[idSessionEnCours].Prenom = prenom;
            this.donateurs[idSessionEnCours].Nom = nom;
            this.donateurs[idSessionEnCours].Email = email;
            this.donateurs[idSessionEnCours].Telephone = telephone;

            //Saving...
            this.saveState();
        }

        
        public void consommerPrix(int indexPrix) {
            //Verification de la methode
            verifSession(SESSIONDONATEUR);
            if(indexPrix>=prix.Count || indexPrix < 0) throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID,"Aucun prix selectionnez.");
            Prix prix_to_use = prix[indexPrix];
            if (prix_to_use.NbPtsRequis > donateurs[idSessionEnCours].PtsPrix) throw (new ExceptSTE(ExceptSTE.ERR_NOTENOUGH,"Nombre de pts insuffisant"));

            //Travail de la methode
            prix_to_use.QuantiteRestante--;
            donateurs[idSessionEnCours].PtsPrix -= prix_to_use.NbPtsRequis;
            if (prix_to_use.QuantiteRestante <= 0) prix.RemoveAt(indexPrix);

            //Saving...
            this.saveState();
        }
        public void ajouterCarteCredit(string numerocarte, string numeroSecurite, DateTime dateExpiration, char typeCarte)
        {
            //Verification de la session en cours
            verifSession(SESSIONDONATEUR);

            //Verifie si le type de carte est valide
            if (typeCarte != CarteDeCredit.MASTERCARD
                && typeCarte != CarteDeCredit.AMERICAN_EXPRESS
                && typeCarte != CarteDeCredit.VISA)
                throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "Type de carte non valide");

            //Verifie que la carte n'est pas expire
            if (dateExpiration < DateTime.Today) throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "La carte de credit ne peut etre expiré.");

            //On met nos REGEX
            if (!Regex.IsMatch(numerocarte, @"^\d{4}([ \-]?\d{4}){3}$")) throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "Le numero de carte de credit est invalide.");
            if (!Regex.IsMatch(numeroSecurite, @"^\d{3}$")) throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "Le numero de securite de la carte de credit est invalide.");

            //On trime le numero de carte 
            numerocarte = Regex.Replace(numerocarte, @"[ \-]", "");

            //Travail de la methode
            donateurs[idSessionEnCours].Cartecredits.Add(new CarteDeCredit(numerocarte, numeroSecurite, dateExpiration, typeCarte));

            //Saving...
            this.saveState();
        }
        public void modifierCarteCredit(int index,string numerocarte, string numeroSecurite, DateTime dateExpiration, char typeCarte) {

            //Verification de la session en cours
            verifSession(SESSIONDONATEUR);

            //Verifie si le type de carte est valide
            if (typeCarte != CarteDeCredit.MASTERCARD
                && typeCarte != CarteDeCredit.AMERICAN_EXPRESS
                && typeCarte != CarteDeCredit.VISA)
                throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "Type de carte non valide");

            //Verifie que la carte n'est pas expire
            if (dateExpiration < DateTime.Today) throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "La carte de credit ne peut etre expiré.");

            //On met nos REGEX
            if (!Regex.IsMatch(numerocarte, @"^\d{4}([ \-]?\d{4}){3}$")) throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "Le numero de carte de credit est invalide.");
            if (!Regex.IsMatch(numeroSecurite, @"^\d{3}$")) throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "Le numero de securite de la carte de credit est invalide.");

            //On trime le numero de carte 
            numerocarte = Regex.Replace(numerocarte, @"[ \-]", "");

            //On verifie que l'index n'est pas OutOfBound
            if(index < 0 || index > donateurs[idSessionEnCours].Cartecredits.Count) throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "La carte a modifier n'existe pas.");

            //Travail de la methode
            CarteDeCredit cartemodifier = new CarteDeCredit(numerocarte, numeroSecurite, dateExpiration, typeCarte);
            if (donateurs[idSessionEnCours].Cartecredits[index].Equals(cartemodifier))
                return;
            donateurs[idSessionEnCours].Cartecredits[index] = cartemodifier;

            //Saving...
            this.saveState();
        }
        public void supprimerCarteCredit(int index) {
            //Verification
            verifSession(SESSIONDONATEUR);

            //On verifie que l'index n'est pas OutOfBound
            if (index > 0 && index < donateurs[idSessionEnCours].Cartecredits.Count) throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "La carte a supprimer n'existe pas.");

            //Travail de la methode
            donateurs[idSessionEnCours].Cartecredits.RemoveAt(index);

            //Saving...
            this.saveState();
        }
        

        //Methode pour gerer l'ouverture et fermeture de session donnateur et commanditaire
        public void ouvrirSessionDonateur(string nom, string prenom, string telephone)
        {
            //On regarde si la session est ouverte
            if(sessionState != NOSESSION) throw (new ExceptSTE(ExceptSTE.ERR_SESSION,"Il y a deja une session en cours."));

            //On trim les string
            prenom = strip(prenom);
            nom = strip(nom);

            //Verification des expressions regulieres
            verifRegex(prenom, nom, telephone);

            //On trim le telephone
            telephone = Regex.Replace(telephone, @"[ \-()]", "");

            //On cherche l'utilisateur dans la base de donnée
            for (int i = 0; i < donateurs.Count; i++)
            {
                if(nom == donateurs.ElementAt(i).Value.Nom && prenom == donateurs.ElementAt(i).Value.Prenom && telephone == donateurs.ElementAt(i).Value.Telephone)
                {
                    idSessionEnCours = donateurs.ElementAt(i).Key;
                    sessionState = SESSIONDONATEUR;
                    this.saveState();
                    return;
                }
            }

            //Exception si aucun utilisateur correspond
            throw (new ExceptSTE(ExceptSTE.ERR_SESSION,"Le donateur n'existe pas."));
        }
        public void ouvrirSessionCommanditaire(string nom, string prenom, string telephone)
        {
            //Verif
            if (sessionState != NOSESSION) throw (new ExceptSTE(ExceptSTE.ERR_SESSION,"Erreur, il y a deja une session en cours."));

            //On trim les string
            prenom = strip(prenom);
            nom = strip(nom);

            //Verification des expressions regulieres
            verifRegex(prenom, nom, telephone);

            //On trim le telphone
            telephone = Regex.Replace(telephone, @"[ \-()]", "");
            //On cherche le commanditaire dans la base de donnée
            for (int i = 0; i < commanditaires.Count; i++)
            {
                if (nom == commanditaires.ElementAt(i).Value.Nom && prenom == commanditaires.ElementAt(i).Value.Prenom && telephone == commanditaires.ElementAt(i).Value.Telephone)
                {
                    idSessionEnCours = commanditaires.ElementAt(i).Key;
                    sessionState = SESSIONCOMMANDITAIRE;
                    this.saveState();
                    return;
                }
            }

            //Exception si aucun utilisateur correspond
            throw (new ExceptSTE(ExceptSTE.ERR_SESSION,"Erreur, le commanditaire n'existe pas."));
        }
        public void fermerSession()
        {
            if (sessionState == NOSESSION) throw (new ExceptSTE(ExceptSTE.ERR_SESSION,"Il y a aucune une session en cours."));
            sessionState = NOSESSION;
            idSessionEnCours = "";
            this.saveState();
        }

        //Methode pour ecrier dans un json file
        public void saveState()
        {
            string jsonString = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(JSONFILE, jsonString);
        }


        //Getters par deep-copy pour l'affichage !
        public double MontantAcqueris { get => montantAcqueris; }
        public int SessionState { get => sessionState; }
        public Dictionary<string, Donateur> getDictDonateur()
        {
            Dictionary<string, Donateur> result = new Dictionary<string, Donateur>();
            for (int i = 0; i < this.donateurs.Count; i++)
            {
                result.Add(this.donateurs.ElementAt(i).Key,new Donateur(this.donateurs.ElementAt(i).Value));
            }
            return result;
        }
        public Dictionary<string, Commanditaire> getDictCommanditaire()
        {
            Dictionary<string, Commanditaire> result = new Dictionary<string, Commanditaire>();
            for (int i = 0; i < this.commanditaires.Count; i++)
            {
                result.Add(this.commanditaires.ElementAt(i).Key, new Commanditaire(this.commanditaires.ElementAt(i).Value));
            }
            return result;
        }

        public List<Don> getListAllDon()
        {
            List<Don> result = new List<Don>();
            for (int i = 0; i < dons.Count; i++)
            {
                result.Add(new Don(dons[i]));
            }
            return result;
        }
        public List<Don> getListSessionDon()
        {
            verifSession(SESSIONDONATEUR);
            List<Don> result = new List<Don>();
            for (int i = 0; i < dons.Count; i++)
            {
                if (dons[i].IdDonateur == idSessionEnCours)
                    result.Add(new Don(dons[i]));
            }
            return result;
        }
        public List<Prix> getListAllPrix()
        {
            List<Prix> result = new List<Prix>();
            for (int i = 0; i < prix.Count; i++)
            {
                result.Add(new Prix(prix[i]));
            }
            return result;
        }
        public List<Prix> getListSessionPrix()
        {
            verifSession(SESSIONCOMMANDITAIRE);
            List<Prix> result = new List<Prix>();
            for (int i = 0; i < prix.Count; i++)
            {
                if (prix[i].IdCommanditaire == idSessionEnCours)
                    result.Add(new Prix(prix[i]));
            }
            return result;
        }
        public Donateur getSessionDonateur()
        {
            verifSession(SESSIONDONATEUR);
            return new Donateur(donateurs[idSessionEnCours]);
        }
        public Commanditaire getSessionCommanditaire()
        {
            verifSession(SESSIONCOMMANDITAIRE);
            return new Commanditaire(commanditaires[idSessionEnCours]);
        }

        //Methode de verification
        private void verifSession(int sessionState)
        {
            if(sessionState == SESSIONDONATEUR)
            {
                if (this.sessionState != SESSIONDONATEUR) throw (new ExceptSTE(ExceptSTE.ERR_SESSION,"Erreur, la session en cours n'est pas un donateur"));
                if (idSessionEnCours.Equals(string.Empty)) throw (new ExceptSTE(ExceptSTE.ERR_SESSION,"Erreur, aucun donateur trouvé."));
            }
            if(sessionState == SESSIONCOMMANDITAIRE)
            {
                if(this.sessionState != SESSIONCOMMANDITAIRE) throw (new ExceptSTE(ExceptSTE.ERR_SESSION,"Erreur, la session en cours n'est pas un commanditaire"));
                if (idSessionEnCours.Equals(string.Empty)) throw (new ExceptSTE(ExceptSTE.ERR_SESSION,"Erreur, aucun commanditaire trouvé."));
            }
        }
        private void verifRegex(string prenom, string nom, string telephone)
        {
            //REGEX EXPRESSION pour confirmer les inputs
            if (!Regex.IsMatch(prenom, @"^[a-z]+$"))
                throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "Le prenom n'est pas valide.");
            if (!Regex.IsMatch(nom, @"^[a-z]+$"))
                throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "Le nom n'est pas valide.");
            if (!Regex.IsMatch(telephone, @"^\(?[0-9]{3}\)?[-|| ]?[0-9]{3}[-|| ]?[0-9]{4}$"))
                throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "Le telephone n'est pas valide.");
        }
        private void verifRegex(string prenom, string nom, string telephone, string email)
        {
            verifRegex(prenom, nom, telephone);
            if (!Regex.IsMatch(email, @"^\w+([-\.]\w+)*@([\w-]+\.)+[\w]{2,4}$") && !email.Equals(string.Empty)) throw new ExceptSTE(ExceptSTE.ERR_VALUENOTVALID, "Email non valide.");
        }
        private string strip(string toBeStripped)
        {
            return Regex.Replace(toBeStripped.ToLower().Trim(), @"\n", "");
        }

    }

    internal class ExceptSTE : Exception
    {
        public const int ERR_DUPVALUE = 0;
        public const int ERR_SESSION = 1;
        public const int ERR_NOTENOUGH = 2;
        public const int ERR_VALUENOTVALID = 3;

        private int err_code;
        public ExceptSTE(int err_code,string message) : base(message)
        {
            this.err_code = err_code;
        }
    }

 }

