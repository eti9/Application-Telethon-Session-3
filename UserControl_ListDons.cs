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
    public partial class UserControl_ListDons : UserControl
    {
        public event EventHandler BtnRetour;
        private GestionnaireSTE ge;
        public UserControl_ListDons()
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
            dgvDons.Rows.Clear();
            for (int i = 0; i < ge.getListAllDon().Count; i++)
            {
                dgvDons.Rows.Add(ge.getListAllDon()[i].ToString());
            }
        }
    }
}
