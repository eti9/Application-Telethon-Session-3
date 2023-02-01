using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AppTelethon
{
    public partial class UserControl_AddDonateur : UserControl
    {
        public event EventHandler BtnAnnulerClick;
        public event EventHandler BtnConfirmerClick;
        private GestionnaireSTE ge;
        public UserControl_AddDonateur()
        {
            InitializeComponent();
        }

        private void btnAjouterDonnateur_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            string email = txtCourriel.Text;
            string telephone = mskTxtBoxTelephone.Text;

            try
            {
                ge.ajouterDonateur(prenom, nom, telephone, email);
            }
            catch(ExceptSTE ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ge.ouvrirSessionDonateur(nom, prenom, telephone);
            }
            catch(ExceptSTE ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BtnConfirmerClick(sender, e);
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            BtnAnnulerClick?.Invoke(sender, e); 
        }
        public  void Show(string prenom, string nom, string telephone)
        {
            //On appelle la methode de base
            base.Show();

            //On initialise les txtbox
            Init(prenom, nom, telephone);

            //On prend le gestionnaire depuis le fichier
            this.ge = JsonConvert.DeserializeObject<GestionnaireSTE>(File.ReadAllText(GestionnaireSTE.JSONFILE));

        }
        public void Init(string prenom, string nom, string telephone)
        {
            txtCourriel.Text = "";
            txtNom.Text = nom;
            txtPrenom.Text = prenom;
            mskTxtBoxTelephone.Text = telephone;
        }
    }
}
