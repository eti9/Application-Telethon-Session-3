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
    public partial class UserControl_Objectif : UserControl
    {
        private GestionnaireSTE ge;
        public UserControl_Objectif()
        {
            InitializeComponent();
        }
        public new void Show()
        {
            //On appelle la methode mere en premier
            base.Show();
            
            //On initialise notre GestionnaireSTE
            this.ge =  JsonConvert.DeserializeObject<GestionnaireSTE>(File.ReadAllText(GestionnaireSTE.JSONFILE));
            if (ge.SessionState != -1) ge.fermerSession();

            //On affiche les nouvelles valeurs sur les txtbox et progressbar
            txtTotalDons.Text = ge.MontantAcqueris.ToString() + "$";
            txtDifferenceObjectif.Text = (100000-ge.MontantAcqueris).ToString()+"$";
            int montantAmmasse = (int)ge.MontantAcqueris;
            if (montantAmmasse > 100000) montantAmmasse = 100000;
            progressBar1.Value = montantAmmasse;
            
        }

        private void lblObjectif_Click(object sender, EventArgs e)
        {

        }
    }
}
