using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UC
{
    public partial class ucForms : UserControl
    {
        public ucForms()
        {
            InitializeComponent();
        }

        public Formular selectedForm
        {
            get
            {
                return (Formular)cbFormulare.SelectedItem;
            }
        }

        private void ucForms_Load(object sender, EventArgs e)
        {
            List<Formular> lista = new List<Formular>();
            lista.Add(new Formular() { ID = 1, nume = "Turisti" });
            lista.Add(new Formular() { ID = 2, nume = "Cazari" });
            lista.Add(new Formular() { ID = 3, nume = "Bilete Avion" });
            lista.Add(new Formular() { ID = 4, nume = "Tranzactii" });
            cbFormulare.DataSource = lista;
            cbFormulare.ValueMember = "ID";
            cbFormulare.DisplayMember = "Nume";
        }
    }
}
