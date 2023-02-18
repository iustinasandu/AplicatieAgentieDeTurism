using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace AgentieDeTurism
{
    public partial class frmCazari : Form
    {
        private List<Cazare> cazari;
        public frmCazari()
        {
            InitializeComponent();
            InitializeComboBox();
            cazari = new List<Cazare>();
        }

        private void InitializeComboBox()
        {
            cmbTipCamera.Items.AddRange(Enum.GetNames(typeof(TipCameraEnum)));
            cmbTipPensiune.Items.AddRange(Enum.GetNames(typeof(TipPensiuneEnum)));
        }

        private void btnAdaugaCazare_Click(object sender, EventArgs e)
        {
            string numeHotel = tbNumeHotel.Text;
            DateTime dataCheckIn = dtpDataCheckIn.Value;
            DateTime dataCheckOut = dtpDataCheckOut.Value;
            float tarif = float.Parse(tbTarif.Text);
            int nrPersoane = int.Parse(tbNrPersoane.Text);

            string tipCamera = cmbTipCamera.Text;
            TipCameraEnum getParse1;
            bool checkParse1 = Enum.TryParse(tipCamera, out getParse1);

            string tipPensiune = cmbTipPensiune.Text;
            TipPensiuneEnum getParse2;
            bool checkPArse2 = Enum.TryParse(tipPensiune, out getParse2);

            int nrNopti = int.Parse(tbNrNopti.Text);
            float pretTotal = float.Parse(tbPretTotal.Text);

            bool formValid = true;
            if (numeHotel.Trim().Length < 3)
            {
                errorProvider.SetError(tbNumeHotel, "Textul introdus contine mai putin de 3 caractere!");
                formValid = false;
            }

            if (dataCheckOut < dataCheckIn)
            {
                errorProvider.SetError(dtpDataCheckOut, "Data de check-out trebuie sa fie dupa data de check-in!");
                formValid = false;
            }

            if (dataCheckIn > dataCheckOut)
            {
                errorProvider.SetError(dtpDataCheckIn, "Data de check-in trebuie sa fie anterioara datei de check-out!");
                formValid = false;
            }

            if (tarif == 0)
            {
                errorProvider.SetError(tbTarif, "Introduceti tariful!");
                formValid = false;
            }

            if (nrPersoane == 0)
            { 
                errorProvider.SetError(tbNrPersoane, "Introduceti numarul de persoane!");
                formValid = false;
            }

            if (!formValid)
            {
                MessageBox.Show("Formularul contine erori!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cazare cazare = new Cazare(numeHotel, getParse1, getParse2, dataCheckIn, dataCheckOut, nrPersoane, tarif);
            cazari.Add(cazare);

            tbNumeHotel.Text = string.Empty;
            dtpDataCheckIn.Value = DateTime.Now;
            dtpDataCheckOut.Value = DateTime.Now;
            tbTarif.Text = string.Empty;
            tbNrPersoane.Text = string.Empty;
            cmbTipCamera.Items.Clear();//se sterg valorile dupa ce se apasa pe adauga
            cmbTipPensiune.Items.Clear();
            InitializeComboBox();
            tbNrNopti.Text = string.Empty;
            tbPretTotal.Text = string.Empty;

            afisareCazari();

        }

        void afisareCazari()
        {
            lvCazari.Items.Clear();
            foreach (Cazare c in cazari)
            {
                ListViewItem item = new ListViewItem(c.numeHotel);
                item.SubItems.Add(c.checkIn.ToShortDateString());
                item.SubItems.Add(c.checkOut.ToShortDateString());
                item.SubItems.Add(c.nrNopti().ToString());
                item.SubItems.Add(c.tipCamera.ToString());
                item.SubItems.Add(c.tipPensiune.ToString());
                item.SubItems.Add(c.tarif.ToString());
                item.SubItems.Add(c.nrPersoane.ToString());
                item.SubItems.Add(c.pretTotal().ToString());

                item.Tag = c;

                lvCazari.Items.Add(item);
            }

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


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            tbPretTotal.Text = (int.Parse(tbNrNopti.Text) * float.Parse(tbTarif.Text) * int.Parse(tbNrPersoane.Text)).ToString();
        }

        private void btnStergereCazare_Click(object sender, EventArgs e)
        {
            if (lvCazari.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o stergeti!");
            }
            else
            {
                if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti inregistrarea?", "Sterge", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem selectedItem = lvCazari.SelectedItems[0];

                    Cazare c = (Cazare)selectedItem.Tag;

                    cazari.Remove(c);

                    afisareCazari();
                }
            }
        }

        private void tbNumeHotel_Validating(object sender, CancelEventArgs e)
        {
            if (tbNumeHotel.Text.Trim().Length < 3)
                errorProvider.SetError(tbNumeHotel, "Textul introdus contine mai putin de 3 caractere!");
            else
                errorProvider.SetError(tbNumeHotel, null);
        }

        private void dtpDataCheckOut_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDataCheckOut.Value < dtpDataCheckIn.Value)
                errorProvider.SetError(dtpDataCheckOut, "Data de check-out trebuie sa fie dupa data de check-in!");
            else
                errorProvider.SetError(dtpDataCheckOut, null);
        }
        private void dtpDataCheckIn_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDataCheckIn.Value > dtpDataCheckOut.Value)
                errorProvider.SetError(dtpDataCheckIn, "Data de check-in trebuie sa fie anterioara datei de check-out!");
            else
                errorProvider.SetError(dtpDataCheckIn, null);
        }

        private void tbTarif_Validating(object sender, CancelEventArgs e)
        {
            if (tbTarif.Text.Trim().Length == 0)
                errorProvider.SetError(tbTarif, "Introduceti tariful!");
            else
                errorProvider.SetError(tbTarif, null);

        }

        private void tbTarif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void tbNrPersoane_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void tbNrPersoane_Validating(object sender, CancelEventArgs e)
        {
            if (tbNrPersoane.Text.Trim().Length == 0)
                errorProvider.SetError(tbNrPersoane, "Introduceti numarul de persoane!");
            else
                errorProvider.SetError(tbNrPersoane, null);
        }

        private void btnEditareCazare_Click(object sender, EventArgs e)
        {
            if (lvCazari.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o editati!");
            }
            else
            {
                ListViewItem selectedItem = lvCazari.SelectedItems[0];
                Cazare c = (Cazare)selectedItem.Tag; //tag stocheaza un atribut de tip object, de-asta trebuie facut cast


                EditareCazare editForm = new EditareCazare(c);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    afisareCazari();
                }
            }
        }

        private void btnSerializareCazari_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fisierCazari = File.Create("serializareCazari.bin"))
            {
                formatter.Serialize(fisierCazari, cazari);
            }
        }

        private void btnListTranzactii_Click(object sender, EventArgs e)
        {
            lvCazari.View = View.List;
        }

        private void btnDetailsTranzactii_Click(object sender, EventArgs e)
        {
            lvCazari.View = View.Details;
        }

        private void btnDeserializareCazari_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fisierCazari = File.OpenRead("serializareCazari.bin"))
            {
                cazari = (List<Cazare>)formatter.Deserialize(fisierCazari);

                afisareCazari();
            }
        }

        private void btnSerializareXMLCazari_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Cazare>));
            using (FileStream fisierCazari = File.Create("serializareCazari.xml"))
            {
                serializer.Serialize(fisierCazari, cazari);
            }
        }

        private void btnDeserializareXMLCazari_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Cazare>));
            using (FileStream fisierCazari = File.OpenRead("serializareCazari.xml"))
            {
                cazari = (List<Cazare>)serializer.Deserialize(fisierCazari);

                afisareCazari();
            }
        }


        private void btnAdaugaCazare_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelCazari.Text = "Click pentru a adauga o noua cazare";
        }

        private void btnAdaugaCazare_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelCazari.Text = "";
        }

        private void btnEditareCazare_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelCazari.Text = "Click pentru a edita o cazare";
        }

        private void btnEditareCazare_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelCazari.Text = "";
        }

        private void btnStergereCazare_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelCazari.Text = "Click pentru a sterge o cazare";
        }

        private void btnStergereCazare_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelCazari.Text = "";
        }

        private void frmCazari_Load(object sender, EventArgs e)
        {
            statusStripCazari.BackColor = Color.White;
        }

        private void toolStripButtonSaveCazari_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV | *.csv";
            saveFileDialog.Title = "Export in format csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("NumeHotel, DataCheckIn, DataCheckOut, NrNopti, TipCamera, TipPensiune, Tarif, NrPersoane, PretTotal");

                    foreach (Cazare c in cazari)
                        sw.WriteLine($"{c.numeHotel},{c.checkIn.ToShortDateString()},{c.checkOut.ToShortDateString()},{c.nrNopti()},{c.tipCamera}, {c.tipPensiune}, {c.tarif},{c.nrPersoane}, {c.pretTotal()}");
                }
            }
        }

        int currentPrintIndex = 0;

        private void printDocumentCazari_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            currentPrintIndex = 0;
        }

        private void tsbPrintPreviewCazari_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialogCazari.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void tsbPrintCazari_Click(object sender, EventArgs e)
        {
            if (printDialogCazari.ShowDialog() == DialogResult.OK)
                printDocumentCazari.Print();
        }

        private void printDocumentCazari_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Calibri", 12);
            int currentY = printDocumentCazari.DefaultPageSettings.Margins.Top;
            while (currentPrintIndex < cazari.Count)
            {
                Cazare cazare = cazari[currentPrintIndex];
                e.Graphics.DrawString($"{cazare.numeHotel} {cazare.checkIn} {cazare.checkOut} {cazare.nrNopti()} {cazare.tipCamera} {cazare.tipPensiune} {cazare.tarif} {cazare.nrPersoane} {cazare.pretTotal()}", 
                                         font, Brushes.Black, printDocumentCazari.DefaultPageSettings.Margins.Left, currentY);
                currentY += 40;

                if (currentY > e.MarginBounds.Height) //suport pt mai multe pagini
                {
                    e.HasMorePages = true;
                    break;
                }

                currentPrintIndex++;
            }
        }
    }
}

