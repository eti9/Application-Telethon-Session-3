using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AppTelethon
{
    public partial class UserControl_Donnateur : UserControl
    {
        public event EventHandler BtnRetour;
        public event EventHandler BtnModifierCarte;
        public event EventHandler BtnAjouterCarte;
        public event EventHandler BtnReclamerPrix;


        private bool infoState = false;
        public int index;


        private GestionnaireSTE ge;
        private ImageList imgs = new ImageList();

        public UserControl_Donnateur()
        {
            InitializeComponent();

            //On creer une liste d'image de carte de credit
            imgs.ImageSize = new Size(32, 32);

            imgs.Images.Add(Properties.Resources.icons8_mastercard);
            imgs.Images.Add(Properties.Resources.icons8_American_Express);
            imgs.Images.Add(Properties.Resources.icons8_visa);

            listViewCarteCredit.SmallImageList = imgs;

            //Setting gridView
            dgvDon.AutoGenerateColumns = false;
            dgvDon.RowHeadersVisible = false;
            dgvDon.MultiSelect = false;
            dgvDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvDon.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }


        private void btnRetour_Click(object sender, EventArgs e)
        {
            BtnRetour?.Invoke(this, e);
        }

        private void btnModifierInfo_Click(object sender, EventArgs e)
        {
            if (!infoState)
            {
                txtCourriel.Enabled = true;
                txtNom.Enabled = true;
                txtPrenom.Enabled = true;
                mskTxtBoxTelephone.Enabled = true;
                btnModifierInfo.Text = "CONFIRMER";
                infoState = true;


                btnFaireDon.Enabled = false;
                btnReclamez.Enabled = false;
                picboxAjouterCarte.Enabled = false;
                picboxDeleteCarte.Enabled = false;
                picboxModifierCarte.Enabled = false;
                btnRetour.Enabled = false;
            }
            else
            {
                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;
                string telephone = mskTxtBoxTelephone.Text;
                string email = txtCourriel.Text;

                try
                {
                    ge.modifierDonateur(prenom, nom, telephone, email);
                }
                catch (ExceptSTE ex)
                {
                    MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                }
                setTextBoxInfo();
                txtCourriel.Enabled = false;
                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
                mskTxtBoxTelephone.Enabled = false;
                btnModifierInfo.Text = "MODIFIER LES INFORMATIONS";
                infoState = false;


                btnFaireDon.Enabled = true;
                btnReclamez.Enabled = true;
                picboxAjouterCarte.Enabled = true;
                picboxDeleteCarte.Enabled = true;
                picboxModifierCarte.Enabled = true;
                btnRetour.Enabled = true;
            }
        }

        private void btn_carteCredit(object sender, EventArgs e)
        {
            //On get le view sender en Picbox
            PictureBox picbox = (PictureBox)sender;

            //Executer quand clicker sur le bouton add
            if (picbox.Name.Equals("picboxAjouterCarte")) 
                BtnAjouterCarte?.Invoke(this,e);

            //Exectuer quand clicker sur le bouton modifier
            if (picbox.Name.Equals("picboxModifierCarte"))
            {
                if (listViewCarteCredit.SelectedIndices.Count <= 0) return;
                this.index = listViewCarteCredit.SelectedIndices[0];
                BtnModifierCarte?.Invoke(this, e);
            }

            //Executer quand clicker sur le bouton supprimer
            if (picbox.Name.Equals("picboxDeleteCarte"))
            {
                if (listViewCarteCredit.SelectedIndices.Count <= 0) return;
                try
                {
                    ge.supprimerCarteCredit(listViewCarteCredit.SelectedIndices[0]);
                    setTextBoxInfo();
                }
                catch (ExceptSTE ex)
                {
                    MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
            
        }

        private void btnReclamez_Click(object sender, EventArgs e)
        {
            BtnReclamerPrix?.Invoke(this, e);
        }
        private void btnFaireDon_Click(object sender, EventArgs e)
        {
            
            if (listViewCarteCredit.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Aucune carte de credit selectionné.", "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            double montant = (double)numUpDownMontantDon.Value;

            //Calcul du nombre de points 
            int points = 0;
            if (50 <= montant && montant <= 199) points = 1;
            else if (200 <= montant && montant <= 349) points = 2;
            else if (350 <= montant && montant <= 499) points = 3;
            else if (montant >= 500)
            {
                double montantRestant = montant - 500;
                points += 5;
                points += ((int)montantRestant / (int)500)*4;
            }

            try
            {
                ge.ajouterDon(DateTime.Today.ToString(), montant, points, listViewCarteCredit.SelectedIndices[0]);
                MessageBox.Show("Le don a bien été effectué sans probleme", "Dons", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                setTextBoxInfo();
            }
            catch (ExceptSTE ex)
            {
                MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            }

        }


        public new void Show()
        {
            //On appelle la fonction de  base
            base.Show();

            //On initialize le gestionnaire
            this.ge = JsonConvert.DeserializeObject<GestionnaireSTE>(File.ReadAllText(GestionnaireSTE.JSONFILE));
            
            //Initialize les txtbox
            setTextBoxInfo();
            numUpDownMontantDon.Value = 0;
        }


        public void setTextBoxInfo()
        {
            //On met les informations dans les txtbox
            txtIdDonateur.Text = ge.getSessionDonateur().Id;
            txtNom.Text = ge.getSessionDonateur().Nom;
            txtNom.Text = txtNom.Text.Substring(0,1).ToUpper() + txtNom.Text.Substring(1);
            txtPrenom.Text = ge.getSessionDonateur().Prenom;
            txtPrenom.Text = txtPrenom.Text.Substring(0, 1).ToUpper() + txtPrenom.Text.Substring(1);
            txtCourriel.Text = ge.getSessionDonateur().Email;
            mskTxtBoxTelephone.Text = ge.getSessionDonateur().Telephone;
            txtBoxPts.Text = ge.getSessionDonateur().PtsPrix.ToString();


            listViewCarteCredit.Items.Clear();
            for (int i = 0; i < ge.getSessionDonateur().Cartecredits.Count; i++)
            {
                int indexPhoto = 0;
                if (ge.getSessionDonateur().Cartecredits[i].TypeCarte == CarteDeCredit.MASTERCARD) indexPhoto = 0;
                if (ge.getSessionDonateur().Cartecredits[i].TypeCarte == CarteDeCredit.AMERICAN_EXPRESS) indexPhoto = 1;
                if (ge.getSessionDonateur().Cartecredits[i].TypeCarte == CarteDeCredit.VISA) indexPhoto = 2;
                string[] listStringItem = new string[2];
                listStringItem[0] = ge.getSessionDonateur().Cartecredits[i].NumeroCarte.Substring(0, 4) 
                    + "********" + ge.getSessionDonateur().Cartecredits[i].NumeroCarte.Substring(12, 4);

                listStringItem[1] = ge.getSessionDonateur().Cartecredits[i].DateExpiration.Month.ToString()
                    + "/" + ge.getSessionDonateur().Cartecredits[i].DateExpiration.Year.ToString();
                ListViewItem listItem = new ListViewItem(listStringItem, indexPhoto);
                listViewCarteCredit.Items.Add(listItem);
            }

            dgvDon.Rows.Clear();
            for(int i = 0; i < ge.getListSessionDon().Count; i++)
            {
                dgvDon.Rows.Add(ge.getListSessionDon()[i].ToString());
            }

        }


    }
}

