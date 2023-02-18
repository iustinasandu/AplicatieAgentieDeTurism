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
    public partial class EditareTranzactie : MaterialSkin.Controls.MaterialForm
    {
        private Tranzactie tranzactie;
        public EditareTranzactie(Tranzactie tranzactie)
        {
            InitializeComponent();
            this.tranzactie = tranzactie;
        }

        private void EditareTranzactie_Load(object sender, EventArgs e)
        {
            tbId.Text = tranzactie.idTranzactie.ToString();
            tbNumeClient.Text = tranzactie.numeClient;
            tbPrenumeClient.Text = tranzactie.prenumeClient;
            tbNrFactura.Text = tranzactie.nrFactura.ToString();
            tbPret.Text = tranzactie.pret.ToString();

        }

        private void btnCalculTVA_Click(object sender, EventArgs e)
        {
            tbTVA.Text = (float.Parse(tbPret.Text) * 0.19).ToString();
        }

        private void btnCalculPretFinal_Click(object sender, EventArgs e)
        {
            tbPretFinal.Text = (float.Parse(tbPret.Text) + float.Parse(tbTVA.Text)).ToString();
        }

        private void btnOkTranzactie_Click(object sender, EventArgs e)
        {
            tranzactie.idTranzactie = int.Parse(tbId.Text);
            tranzactie.numeClient = tbNumeClient.Text;
            tranzactie.prenumeClient = tbPrenumeClient.Text;
            tranzactie.nrFactura = int.Parse(tbNrFactura.Text);
            tranzactie.pret = float.Parse(tbPret.Text);

        }
    }
}
