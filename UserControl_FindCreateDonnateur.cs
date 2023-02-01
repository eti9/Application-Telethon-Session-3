using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AppTelethon
{
    public partial class UserControl_FindCreateDonnateur : UserControl
    {
        public event EventHandler BtnSuivant;
        public event EventHandler BtnAjouterDonateur;
        public string telephoneToPass;
        public string prenomToPass;
        public string nomToPass;
        private GestionnaireSTE ge;
        public UserControl_FindCreateDonnateur()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            telephoneToPass = mskTxtBoxTelephone.Text;
            prenomToPass = txtBoxPrenom.Text;
            nomToPass = txtBoxNom.Text;
            BtnAjouterDonateur?.Invoke(this, e);
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            //On se creer des string contenant les input des txtbox
            string prenom = txtBoxPrenom.Text;
            string nom = txtBoxNom.Text;
            string telephone = mskTxtBoxTelephone.Text;

            //On regarde dans la base de donnée si cette personne existe
            try
            {
                ge.ouvrirSessionDonateur(nom, prenom, telephone);
            }
            catch (ExceptSTE ex)
            {
                MessageBox.Show(ex.Message,"Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            

            
            //On passse au prochain UserControl
            BtnSuivant?.Invoke(this, e);
        }
        public new void Show()
        {
            //On appelle la methode mere en premier
            base.Show();

            //On initialise notre GestionnaireSTE
            this.ge = JsonConvert.DeserializeObject<GestionnaireSTE>(File.ReadAllText(GestionnaireSTE.JSONFILE));
            if (ge.SessionState != -1) ge.fermerSession();

            //On reset les txtbox
            txtBoxNom.Text = String.Empty;
            txtBoxPrenom.Text = String.Empty;
            mskTxtBoxTelephone.Text = String.Empty;
        }
    }
}
