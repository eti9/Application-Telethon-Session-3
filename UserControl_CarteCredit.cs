using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AppTelethon
{
    public partial class UserControl_CarteCredit : UserControl
    {
        private int index;
        private GestionnaireSTE ge;


        public event EventHandler BtnClick;
        public UserControl_CarteCredit()
        {
            InitializeComponent();
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            BtnClick?.Invoke(this, e);
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //On creer des variable des txtbox
            string numeroCarte = mskTxtBoxNumberCard.Text;
            string numeroCCV = mskTextBoxCCV.Text;
            DateTime dateExpi = dtpDateExpiration.Value;
            char typeCarte = 'E';
            Debug.WriteLine(rdoVisa.Checked);
            //On regarde quel carte est selectionné
            if (rdoAmex.Checked) typeCarte = CarteDeCredit.AMERICAN_EXPRESS;
            if (rdoMasterCard.Checked) typeCarte = CarteDeCredit.MASTERCARD;
            if (rdoVisa.Checked) typeCarte = CarteDeCredit.VISA;

            //On essaye d'ajouter la carte de credit
            if (index == -1)
            {
                try
                {
                    ge.ajouterCarteCredit(numeroCarte, numeroCCV, dateExpi, typeCarte);
                }
                catch (ExceptSTE ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //On essaye de modifier la carte de credit
            else
            {
                try
                {
                    ge.modifierCarteCredit(index,numeroCarte, numeroCCV, dateExpi, typeCarte);
                }
                catch (ExceptSTE ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            BtnClick?.Invoke(this, e);
        }
        public void Show(int index)
        {
            //Appelle la fonction mère
            base.Show();
            this.index = index;

            //On obtient le gestionnaire
            ge = JsonConvert.DeserializeObject<GestionnaireSTE>(File.ReadAllText(GestionnaireSTE.JSONFILE));

            //Initialise les txtbox
            Init();
        }
        private void Init()
        {
            if (index == -1)
            {
                mskTxtBoxNumberCard.Text = "";
                mskTextBoxCCV.Text = "";
                dtpDateExpiration.Text = "";
            }
            else
            {
                mskTxtBoxNumberCard.Text = ge.getSessionDonateur().Cartecredits[index].NumeroCarte;
                mskTextBoxCCV.Text= ge.getSessionDonateur().Cartecredits[index].NumeroSecurite;
                dtpDateExpiration.Value = ge.getSessionDonateur().Cartecredits[index].DateExpiration;
            }
        }

        private void grpTypeCarte_Enter(object sender, EventArgs e)
        {

        }
    }
}
