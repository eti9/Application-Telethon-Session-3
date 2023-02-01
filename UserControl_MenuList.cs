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
    public partial class UserControl_MenuList : UserControl
    {
        public event EventHandler BtnCommanditaire;
        public event EventHandler BtnDons;
        public event EventHandler BtnDonateur;
        public event EventHandler BtnPrix;
        private GestionnaireSTE ge;
        public UserControl_MenuList()
        {
            InitializeComponent();
        }

        private void btnListeDonateurs_Click(object sender, EventArgs e)
        {
            BtnDonateur?.Invoke(this, e);
        }

        private void btnListeDons_Click(object sender, EventArgs e)
        {
            BtnDons?.Invoke(this, e);
        }

        private void btnListeCommanditaires_Click(object sender, EventArgs e)
        {
            BtnCommanditaire?.Invoke(this, e);
        }

        private void btnListePrix_Click(object sender, EventArgs e)
        {
            BtnPrix?.Invoke(this, e);
        }
        public new void Show()
        {
            //On appelle la methode mere en premier
            base.Show();

            //On initialise notre GestionnaireSTE
            this.ge = JsonConvert.DeserializeObject<GestionnaireSTE>(File.ReadAllText(GestionnaireSTE.JSONFILE));
            if (ge.SessionState != -1) ge.fermerSession();
        }
    }
}
