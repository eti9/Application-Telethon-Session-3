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
    public partial class UserControl_FindCreateCommanditaire : UserControl
    {
        public event EventHandler BtnClick;
        private GestionnaireSTE ge;
        public UserControl_FindCreateCommanditaire()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nom = txtBoxNom.Text;
            string prenom = txtBoxPrenom.Text;
            string telephone = mskTxtBoxTelephone.Text;
            try
            {
                
                ge.ajouterCommanditaire(prenom, nom, telephone);
                ge.ouvrirSessionCommanditaire(nom, prenom, telephone);
            }
            catch (ExceptSTE ex)
            {
                MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BtnClick?.Invoke(this, e);
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            string nom = txtBoxNom.Text;
            string prenom = txtBoxPrenom.Text;
            string telephone = mskTxtBoxTelephone.Text;
            try
            {
                ge.ouvrirSessionCommanditaire(nom, prenom, telephone);
            }
            catch (ExceptSTE ex){
                MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BtnClick?.Invoke(this, e);

        }
        public new void Show()
        {
            //On appelle la methode mere en premier
            base.Show();

            //On initialise notre GestionnaireSTE
            this.ge = JsonConvert.DeserializeObject<GestionnaireSTE>(File.ReadAllText(GestionnaireSTE.JSONFILE));
            if (ge.SessionState != -1) ge.fermerSession();
            Init();
        }
        public void Init()
        {
            txtBoxNom.Text = "";
            txtBoxPrenom.Text = "";
            mskTxtBoxTelephone.Text = "";
        }
    }
}
