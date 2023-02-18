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
    public partial class EditareBiletAvioncs : MaterialSkin.Controls.MaterialForm
    {
        private BiletAvion biletAvion;
        public EditareBiletAvioncs(BiletAvion biletAvion)
        {
            InitializeComponent();
            this.biletAvion = biletAvion;
        }

        private void EditareBiletAvioncs_Load(object sender, EventArgs e)
        {
            dtpDataPlecare.Value = biletAvion.dataPlecare;
            dtpDataIntoarcere.Value = biletAvion.dataIntoarcere;
            tbOrasPlecare.Text = biletAvion.orasPlecare;
            tbOrasDestinatie.Text = biletAvion.orasDestinatie;
            tbNrLoc.Text = biletAvion.nrLoc;
            tbPret.Text = biletAvion.pret.ToString();
        }

        private void btnOkBiletAvion_Click(object sender, EventArgs e)
        {
            biletAvion.dataPlecare = dtpDataPlecare.Value;
            biletAvion.dataIntoarcere = dtpDataIntoarcere.Value;
            biletAvion.orasPlecare = tbOrasPlecare.Text;
            biletAvion.orasDestinatie = tbOrasDestinatie.Text;
            biletAvion.nrLoc = tbNrLoc.Text;
            biletAvion.pret = float.Parse(tbPret.Text);
        }
    }
}
