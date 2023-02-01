using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AppTelethon
{
    internal static class Program
    {
        /*
         * Creer UserControle pour commanditaire et Rapport
         * 
         * Creer les verifications avant la saisie
         * 
         * Personnaliser les ListView
         * 
         * Creer 
         * 
         * 
         * 
         */
        
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Bloc d'initialisation et d'instanciation du GestionnaireSTE
            GestionnaireSTE ge;
            try
            {
                ge = JsonConvert.DeserializeObject<GestionnaireSTE>(File.ReadAllText(GestionnaireSTE.JSONFILE));
            }
            catch(Exception ex)
            {
                ge = new GestionnaireSTE();
            }
            if (ge == null) ge = new GestionnaireSTE();


            if (ge.SessionState != -1) ge.fermerSession();
            ge.saveState();


            //Bloc de test:

            //ge.ajouterDonateur("etienne","robert","jiji@gmail.com","5140002222");
            //ge.Donateurs[0].Cartecredits.Add(new CarteDeCredit("2", "394", "23/22", CarteDeCredit.MASTERCARD));
            //ge.ajouterPrix("test", "test3", 10.3, 10, 10);
            //ge.saveState();



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
        }
    }
}
