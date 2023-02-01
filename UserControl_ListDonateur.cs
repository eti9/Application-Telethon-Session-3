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
    public partial class UserControl_ListDonateur : UserControl
    {
        public event EventHandler BtnRetour;
        private GestionnaireSTE ge;
        public UserControl_ListDonateur()
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
            dgvDonnateur.Rows.Clear();
            for (int i = 0; i < ge.getDictDonateur().Count; i++)
            {
                dgvDonnateur.Rows.Add(ge.getDictDonateur().ElementAt(i).Value.ToString());
            }
        }
    }
}
