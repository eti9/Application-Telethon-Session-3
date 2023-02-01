using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTelethon
{
    public partial class FormMenu : Form
    {
        
        public FormMenu()
        {
            InitializeComponent();

            //On hide les formulaire au demarrage
            this.formObjectif1.Hide();
            this.userControl_FindCreateDonnateur1.Hide();
            this.userControl_Donnateur1.Hide();
            this.userControl_CarteCredit1.Hide();
            this.userControl_AddDonateur1.Hide();
            this.userControl_ReclamerPrix1.Hide();
            this.userControl_FindCreateCommanditaire1.Hide();
            this.userControl_Commanditaire1.Hide();
            this.userControl_MenuList1.Hide();
            this.userControl_ListCommanditaire1.Hide();
            this.userControl_ListDonateur1.Hide();
            this.userControl_ListDons1.Hide();
            this.userControl_ListPrix1.Hide();


            //On gere les evenement entre les user controle ici!
            this.userControl_FindCreateDonnateur1.BtnSuivant += UserControl_FindCreateDonnateur1_btnSuivant_action;
            this.userControl_Donnateur1.BtnRetour += UserControl_Donnateur1_BtnRetour;
            this.userControl_Donnateur1.BtnModifierCarte += UserControl_Donnateur1_BtnModifierCarte;
            this.userControl_Donnateur1.BtnAjouterCarte += UserControl_Donnateur1_BtnAjouterCarte;
            this.userControl_CarteCredit1.BtnClick += UserControl_CarteCredit1_BtnClick;
            this.userControl_FindCreateDonnateur1.BtnAjouterDonateur += UserControl_FindCreateDonnateur1_BtnAjouterDonateur;
            this.userControl_AddDonateur1.BtnAnnulerClick += UserControl_AddDonateur1_BtnAnnulerClick;
            this.userControl_AddDonateur1.BtnConfirmerClick += UserControl_AddDonateur1_BtnConfirmerClik;
            this.userControl_ReclamerPrix1.BtnRetourClick += UserControl_ReclamerPrix1_BtnRetourClick;
            this.userControl_Donnateur1.BtnReclamerPrix += UserControl_Donnateur1_BtnReclamerPrix;
            this.userControl_FindCreateCommanditaire1.BtnClick += UserControl_FindCreateCommanditaire1_BtnClick;
            this.userControl_Commanditaire1.BtnRetourClick += UserControl_Commanditaire1_BtnRetourClick;
            this.userControl_MenuList1.BtnCommanditaire += UserControl_MenuList1_BtnCommanditaire;
            this.userControl_ListCommanditaire1.BtnRetour += UserControl_ListCommanditaire1_BtnRetour;
            this.userControl_ListDonateur1.BtnRetour += UserControl_ListDonateur1_BtnRetour;
            this.userControl_MenuList1.BtnDonateur += UserControl_MenuList1_BtnDonateur;
            this.userControl_ListDons1.BtnRetour += UserControl_ListDons1_BtnRetour;
            this.userControl_MenuList1.BtnDons += UserControl_MenuList1_BtnDons;
            this.userControl_MenuList1.BtnPrix += UserControl_MenuList1_BtnPrix;
            this.userControl_ListPrix1.BtnRetour += UserControl_ListPrix1_BtnRetour;
            
        }


        //TOUT LES METHODE USER CONTROL SONT DES EVENT HANDLER
        private void UserControl_ListPrix1_BtnRetour(object sender, EventArgs e)
        {
            this.userControl_MenuList1.Show();
            this.userControl_ListPrix1.Hide();
        }

        private void UserControl_MenuList1_BtnPrix(object sender, EventArgs e)
        {
            this.userControl_ListPrix1.Show();
            this.userControl_MenuList1.Hide();
        }

        private void UserControl_MenuList1_BtnDons(object sender, EventArgs e)
        {
            this.userControl_ListDons1.Show();
            this.userControl_MenuList1.Hide();
        }

        private void UserControl_ListDons1_BtnRetour(object sender, EventArgs e)
        {
            this.userControl_MenuList1.Show();
            this.userControl_ListDons1.Hide();
        }

        private void UserControl_MenuList1_BtnDonateur(object sender, EventArgs e)
        {
            this.userControl_ListDonateur1.Show();
            this.userControl_MenuList1.Hide();
        }

        private void UserControl_ListDonateur1_BtnRetour(object sender, EventArgs e)
        {
            this.userControl_MenuList1.Show();
            this.userControl_ListDonateur1.Hide();
        }

        private void UserControl_ListCommanditaire1_BtnRetour(object sender, EventArgs e)
        {
            this.userControl_MenuList1.Show();
            this.userControl_ListCommanditaire1.Hide();
        }

        private void UserControl_MenuList1_BtnCommanditaire(object sender, EventArgs e)
        {
            this.userControl_ListCommanditaire1.Show();
            this.userControl_MenuList1.Hide();
        }
        private void UserControl_Commanditaire1_BtnRetourClick(object sender, EventArgs e)
        {
            this.userControl_FindCreateCommanditaire1.Show();
            this.userControl_Commanditaire1.Hide();
        }

        private void UserControl_FindCreateCommanditaire1_BtnClick(object sender, EventArgs e)
        {
            this.userControl_Commanditaire1.Show();
            this.userControl_FindCreateCommanditaire1.Hide();
        }

        private void UserControl_Donnateur1_BtnReclamerPrix(object sender, EventArgs e)
        {
            this.userControl_ReclamerPrix1.Show();
            this.userControl_Donnateur1.Hide();
        }

        private void UserControl_ReclamerPrix1_BtnRetourClick(object sender, EventArgs e)
        {
            this.userControl_Donnateur1.Show();
            this.userControl_ReclamerPrix1.Hide();
        }

        private void UserControl_AddDonateur1_BtnConfirmerClik(object sender, EventArgs e)
        {
            this.userControl_Donnateur1.Show();
            this.userControl_AddDonateur1.Hide();
        }
        private void UserControl_AddDonateur1_BtnAnnulerClick(object sender, EventArgs e)
        {
            this.userControl_FindCreateDonnateur1.Show();
            this.userControl_AddDonateur1.Hide();
        }

        private void UserControl_FindCreateDonnateur1_BtnAjouterDonateur(object sender, EventArgs e)
        {
            string telephone = this.userControl_FindCreateDonnateur1.telephoneToPass;
            string prenom = this.userControl_FindCreateDonnateur1.prenomToPass;
            string nom = this.userControl_FindCreateDonnateur1.nomToPass;


            this.userControl_AddDonateur1.Show(prenom, nom, telephone);
            this.userControl_FindCreateDonnateur1.Hide();
        }
        private void UserControl_CarteCredit1_BtnClick(object sender, EventArgs e)
        {
            this.userControl_Donnateur1.Show();
            this.userControl_CarteCredit1.Hide();
        }

        private void UserControl_Donnateur1_BtnAjouterCarte(object sender, EventArgs e)
        {

            this.userControl_CarteCredit1.Show(-1);
            this.userControl_Donnateur1.Hide();

        }

        private void UserControl_Donnateur1_BtnModifierCarte(object sender, EventArgs e)
        {
            this.userControl_CarteCredit1.Show(this.userControl_Donnateur1.index);
            this.userControl_Donnateur1.Hide();
        }

        private void UserControl_Donnateur1_BtnRetour(object sender, EventArgs e)
        {
            this.userControl_FindCreateDonnateur1.Show();
            this.userControl_Donnateur1.Hide();
        }

        private void UserControl_FindCreateDonnateur1_btnSuivant_action(object sender, EventArgs e)
        {
            this.userControl_Donnateur1.Show();
            this.userControl_FindCreateDonnateur1.Hide();
        }


        //ICI CE SONT LES METHODE PAR RAPPORT AU BOUTON DE L'INTERFACE PRINCIPALE!
        private void btnRapport_Click(object sender, EventArgs e)
        {
            this.userControl_MenuList1.Show();
            this.userControl_FindCreateDonnateur1.Hide();
            this.formObjectif1.Hide();
            this.userControl_Donnateur1.Hide();
            this.userControl_CarteCredit1.Hide();
            this.userControl_AddDonateur1.Hide();
            this.userControl_ReclamerPrix1.Hide();
            this.userControl_FindCreateCommanditaire1.Hide();
            this.userControl_Commanditaire1.Hide();
            this.userControl_ListCommanditaire1.Hide();
            this.userControl_ListDonateur1.Hide();
            this.userControl_ListDons1.Hide();
            this.userControl_ListPrix1.Hide();



        }
        private void btnDonateur_Click_1(object sender, EventArgs e)
        {
            
            this.userControl_FindCreateDonnateur1.Show();
            this.formObjectif1.Hide();
            this.userControl_Donnateur1.Hide();
            this.userControl_CarteCredit1.Hide();
            this.userControl_AddDonateur1.Hide();
            this.userControl_ReclamerPrix1.Hide();
            this.userControl_FindCreateCommanditaire1.Hide();
            this.userControl_Commanditaire1.Hide();
            this.userControl_MenuList1.Hide();
            this.userControl_ListCommanditaire1.Hide();
            this.userControl_ListDonateur1.Hide();
            this.userControl_ListDons1.Hide();
            this.userControl_ListPrix1.Hide();


        }
        private void btnObjectif_Click(object sender, EventArgs e)
        {
            
            this.formObjectif1.Show();
            this.userControl_FindCreateDonnateur1.Hide();
            this.userControl_Donnateur1.Hide();
            this.userControl_CarteCredit1.Hide();
            this.userControl_AddDonateur1.Hide();
            this.userControl_ReclamerPrix1.Hide();
            this.userControl_FindCreateCommanditaire1.Hide();
            this.userControl_Commanditaire1.Hide();
            this.userControl_MenuList1.Hide();
            this.userControl_ListCommanditaire1.Hide();
            this.userControl_ListDonateur1.Hide();
            this.userControl_ListDons1.Hide();
            this.userControl_ListPrix1.Hide();




        }
        private void btnCommanditaires_Click(object sender, EventArgs e)
        {
            this.userControl_FindCreateCommanditaire1.Show();
            this.formObjectif1.Hide();
            this.userControl_FindCreateDonnateur1.Hide();
            this.userControl_Donnateur1.Hide();
            this.userControl_CarteCredit1.Hide();
            this.userControl_AddDonateur1.Hide();
            this.userControl_ReclamerPrix1.Hide();
            this.userControl_Commanditaire1.Hide();
            this.userControl_MenuList1.Hide();
            this.userControl_ListCommanditaire1.Hide();
            this.userControl_ListDonateur1.Hide();
            this.userControl_ListDons1.Hide();
            this.userControl_ListPrix1.Hide();


        }
        private void btnDeconnection_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceuil_Click(object sender, EventArgs e)
        {
            this.userControl_FindCreateCommanditaire1.Hide();
            this.formObjectif1.Hide();
            this.userControl_FindCreateDonnateur1.Hide();
            this.userControl_Donnateur1.Hide();
            this.userControl_CarteCredit1.Hide();
            this.userControl_AddDonateur1.Hide();
            this.userControl_ReclamerPrix1.Hide();
            this.userControl_Commanditaire1.Hide();
            this.userControl_MenuList1.Hide();
            this.userControl_ListCommanditaire1.Hide();
            this.userControl_ListDonateur1.Hide();
            this.userControl_ListDons1.Hide();
            this.userControl_ListPrix1.Hide();
          
        }

     

        private void btnInformation_Click(object sender, EventArgs e)
        {
            frmMission mission= new frmMission();
            mission.ShowDialog();
        }

  
    }
}
