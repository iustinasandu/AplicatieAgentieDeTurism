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
    public partial class EditareTurist : MaterialSkin.Controls.MaterialForm
    {
        private Turist turist;
        public EditareTurist(Turist turist)
        {
            InitializeComponent();
            this.turist = turist;
        }

        private void EditareTurist_Load(object sender, EventArgs e)
        {
            tbNume.Text = turist.nume;
            tbPrenume.Text = turist.prenume;
            dtpDataNasterii.Value = turist.data_nasterii;
            tbTelefon.Text = turist.telefon;
            tbEmail.Text = turist.email;
        }

        private void btnOkTurist_Click(object sender, EventArgs e)
        {
            turist.nume = tbNume.Text;
            turist.prenume = tbPrenume.Text;
            turist.data_nasterii = dtpDataNasterii.Value;
            turist.telefon = tbTelefon.Text;
            turist.email = tbEmail.Text;
        }
    }
}
