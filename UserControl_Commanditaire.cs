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
    public partial class UserControl_Commanditaire : UserControl
    {
        public event EventHandler BtnRetourClick;
        private GestionnaireSTE ge;
        private List<int> points = new List<int>();
        public UserControl_Commanditaire()
        {
            InitializeComponent();
            points.Add(20);
            points.Add(1);
            points.Add(10);
            points.Add(15);

            //Setting gridView
            dgvListPrix.AutoGenerateColumns = false;
            dgvListPrix.RowHeadersVisible = false;
            dgvListPrix.MultiSelect = false;
            dgvListPrix.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListPrix.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListPrix.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            BtnRetourClick?.Invoke(sender, e);
        }
        private void btnAjouterPrix_Click(object sender, EventArgs e)
        {
            string nomPrix = cmbPrixOffert.Items[cmbPrixOffert.SelectedIndex].ToString();
            int quantite =(int) numUpDownQte.Value;
            double valeur = (double)numUpDownVal.Value;


            try
            {
                ge.ajouterPrix(nomPrix, valeur, quantite, points[cmbPrixOffert.SelectedIndex]);
                setListPrix();
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

            //On initialise les txtbox
            Init();
        }
        private void Init()
        {
            //TextBox commanditaire
            txtIdCommanditaire.Text = ge.getSessionCommanditaire().Id;
            txtNom.Text = ge.getSessionCommanditaire().Nom;
            txtNom.Text = txtNom.Text.Substring(0, 1).ToUpper() + txtNom.Text.Substring(1);
            txtPrenom.Text = ge.getSessionCommanditaire().Prenom;
            txtPrenom.Text = txtPrenom.Text.Substring(0, 1).ToUpper() + txtPrenom.Text.Substring(1);
            mskTxtBoxTelephone.Text = ge.getSessionCommanditaire().Telephone;

            //TextBox prix
            cmbPrixOffert.SelectedIndex = 0;
            numUpDownQte.Value = 0;
            numUpDownVal.Value = 0;

            //Liste des prix
            setListPrix();
        }
        private void setListPrix()
        {
            dgvListPrix.Rows.Clear();
            for (int i = 0; i < ge.getListSessionPrix().Count; i++)
            {
                dgvListPrix.Rows.Add(ge.getListSessionPrix()[i].ToString());
            }
        }

        
    }
}
