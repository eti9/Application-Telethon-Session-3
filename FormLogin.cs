using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTelethon
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }


        // Bouton Entrer
        private void btnEntrer_Click(object sender, EventArgs e)
        {

            // Pas de fonction Trim().ToLower pour le champ motPasse. Selon le projet le mot de passe est Don@2021
            
            string utilisateur = txtUtilisateur.Text.Trim().ToLower();
            string motPasse = txtMotPasse.Text;

          

            if (!String.IsNullOrEmpty(utilisateur) && !String.IsNullOrEmpty(motPasse))
            {
                if (utilisateur == "a" && motPasse == "b")
                //if (utilisateur == "téléthon2021" && motPasse == "Don@2021")
                {
                    MessageBox.Show("Bienvenue utilisateur. Les informations saisies sont valides.", "Bienvenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       // Application.Exit();

                    FormMenu formulairemenu = new FormMenu();
                    formulairemenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Les informations saisies ne sont pas valides.",
                    "Attention", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    txtUtilisateur.Text = String.Empty;
                    txtMotPasse.Text = String.Empty;
                    txtUtilisateur.Focus();
                }
            }
            else

            {
                MessageBox.Show("Vous devez saisir votre nom d'utilisateur et votre mot de passe.", "Attention", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtUtilisateur.Focus();
            }

        }

        // Bouton Annuler

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

            DialogResult reponse = MessageBox.Show("Désirez-vous réellement quitter cette application ? ", "Attention",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtMotPasse.UseSystemPasswordChar = false;
        }

        private void txtUtilisateur_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMotPasse_changed(object sender, EventArgs e)
        {
            if (!txtMotPasse.UseSystemPasswordChar) txtMotPasse.UseSystemPasswordChar = true;
        }
    }
}
