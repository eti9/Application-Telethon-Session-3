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
    public partial class UserControl_ReclamerPrix : UserControl
    {
        public event EventHandler BtnRetourClick;
        private GestionnaireSTE ge;
        public UserControl_ReclamerPrix()
        {
            InitializeComponent();
            //Setting gridView
            dgvListPrix.AutoGenerateColumns = false;
            dgvListPrix.RowHeadersVisible = false;
            dgvListPrix.MultiSelect = false;
            dgvListPrix.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListPrix.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListPrix.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void btnReclamerPrix_Click(object sender, EventArgs e)
        {
            try
            {
                ge.consommerPrix(dgvListPrix.SelectedRows[0].Index);
                MessageBox.Show("Le prix a ete reclamez sans probleme", "Prix", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                Init();
            }
            catch (ExceptSTE ex)
            {
                MessageBox.Show(ex.Message, "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnRetourClick?.Invoke(this, e);
        }
        public new void Show()
        {
            //On appelle la fonction de  base
            base.Show();

            //On initialize le gestionnaire
            this.ge = JsonConvert.DeserializeObject<GestionnaireSTE>(File.ReadAllText(GestionnaireSTE.JSONFILE));

            //Initialise la liste des prix et le txt box
            Init();
        }
        public void Init()
        {
            txtBoxPoints.Text = ge.getSessionDonateur().PtsPrix.ToString();

            dgvListPrix.Rows.Clear();
            for (int i = 0; i < ge.getListAllPrix().Count; i++)
            {
                dgvListPrix.Rows.Add(ge.getListAllPrix()[i].ToString());
            }
        }
    }
}
