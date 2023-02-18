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
    public partial class EditareCazare : MaterialSkin.Controls.MaterialForm
    {
        private Cazare cazare;
        public EditareCazare(Cazare cazare)
        {
            InitializeComponent();
            this.cazare = cazare;
        }

        private void EditareCazare_Load(object sender, EventArgs e)
        {
            tbNumeHotel.Text = cazare.numeHotel;
            dtpDataCheckIn.Value = cazare.checkIn;
            dtpDataCheckOut.Value = cazare.checkOut;
            cmbTipCameraEditat.Items.AddRange(Enum.GetNames(typeof(TipCameraEnum)));
            cmbTipCameraEditat.Text = cazare.tipCamera.ToString();
            cmbTipPensiuneEditat.Items.AddRange(Enum.GetNames(typeof(TipPensiuneEnum)));
            cmbTipPensiuneEditat.Text = cazare.tipPensiune.ToString();
            tbTarif.Text = cazare.tarif.ToString();
            tbNrPersoane.Text = cazare.nrPersoane.ToString(); ;
        }

        private void btnOkCazare_Click(object sender, EventArgs e)
        {
            cazare.numeHotel = tbNumeHotel.Text;
            cazare.checkIn = dtpDataCheckIn.Value;
            cazare.checkOut = dtpDataCheckOut.Value;
            cazare.tipCamera = (TipCameraEnum)cmbTipCameraEditat.SelectedIndex;
            cazare.tipPensiune = (TipPensiuneEnum)cmbTipPensiuneEditat.SelectedIndex;
            cazare.tarif = float.Parse(tbTarif.Text);
            cazare.nrPersoane = int.Parse(tbNrPersoane.Text);


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            tbPretTotal.Text = (int.Parse(tbNrNopti.Text) * float.Parse(tbTarif.Text) * int.Parse(tbNrPersoane.Text)).ToString();
        }

        private void dtpDataCheckOut_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbNrNopti.Text = dtpDataCheckOut.Value.Subtract(dtpDataCheckIn.Value).Days.ToString();
            }
            catch
            {

            }
        }

        
    }
}
