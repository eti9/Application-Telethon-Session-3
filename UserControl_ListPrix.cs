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
    public partial class UserControl_ListPrix : UserControl
    {
        public event EventHandler BtnRetour;
        private GestionnaireSTE ge;
        public UserControl_ListPrix()
        {
            InitializeComponent();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            BtnRetour?.Invoke(this, e);
        }
        public new void Show()
        {
            //On appelle la methode mere en premier
            base.Show();

            //On initialise notre GestionnaireSTE
            this.ge = JsonConvert.DeserializeObject<GestionnaireSTE>(File.ReadAllText(GestionnaireSTE.JSONFILE));
            Init();
        }
        public void Init()
        {
            dgvPrix.Rows.Clear();
            for (int i = 0; i < ge.getListAllPrix().Count; i++)
            {
                dgvPrix.Rows.Add(ge.getListAllPrix()[i].ToString());
            }
        }
    }
}
