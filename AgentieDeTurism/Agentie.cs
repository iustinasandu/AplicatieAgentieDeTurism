using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgentieDeTurism
{
    public partial class frmAgentie : MaterialSkin.Controls.MaterialForm
    {
        public frmAgentie()
        {
            InitializeComponent();
        }

        private void btnTuristi_Click(object sender, EventArgs e)
        {
            frmTuristi turisti = new frmTuristi();
            turisti.ShowDialog();

        }

        private void btnCazare_Click(object sender, EventArgs e)
        {
            frmCazari cazari = new frmCazari();
            cazari.ShowDialog();
        }

        private void btnBileteAvion_Click(object sender, EventArgs e)
        {
            frmBileteAvion bilete = new frmBileteAvion();
            bilete.ShowDialog();
        }

        private void btnTranzactii_Click(object sender, EventArgs e)
        {
            frmTranzactii tranzactii = new frmTranzactii();
            tranzactii.ShowDialog();
        }
    }
}
