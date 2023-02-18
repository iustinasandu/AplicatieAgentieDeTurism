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
    public partial class frmTranzactii : Form
    {
        private List<Tranzactie> tranzactii;
        public frmTranzactii()
        {
            InitializeComponent();
            tranzactii = new List<Tranzactie>();
        }

        private void btnAdaugaTranzactie_Click(object sender, EventArgs e)
        {
            int idTranzactie = int.Parse(tbId.Text);
            string numeClient = tbNumeClient.Text;
            string prenumeClient = tbPrenumeClient.Text;
            float pret = float.Parse(tbPret.Text);
            float tva = float.Parse(tbTVA.Text);
            float pretFinal = float.Parse(tbPretFinal.Text);
            int nrFactura = int.Parse(tbNrFactura.Text);

            bool formValid = true;
            if (idTranzactie == 0)
            {
                errorProvider.SetError(tbId, "Introduceti id-ul tranzactiei!");
                formValid = false;
            }

            if (numeClient.Trim().Length < 3)
            {
                errorProvider.SetError(tbNumeClient, "Textul introdus contine mai putin de 3 caractere!");
                formValid = false;
            }

            if (prenumeClient.Trim().Length < 3)
            {
                errorProvider.SetError(tbPrenumeClient, "Textul introdus contine mai putin de 3 caractere!");
                formValid = false;
            }

            if (nrFactura == 0)
            {
                errorProvider.SetError(tbNrFactura, "Introduceti numarul facturii!");
                formValid = false;
            }
            if (pret == 0)
            {
                errorProvider.SetError(tbPret, "Introduceti pretul tranzactiei!");
                formValid = false;
            }
      

            Tranzactie tranzactie = new Tranzactie(idTranzactie, numeClient, prenumeClient, pret, nrFactura);
            tranzactii.Add(tranzactie);

            tbId.Text = string.Empty;
            tbNumeClient.Text = string.Empty;
            tbPrenumeClient.Text = string.Empty;
            tbPret.Text = string.Empty;
            tbTVA.Text = string.Empty;
            tbPretFinal.Text = string.Empty;
            tbNrFactura.Text = string.Empty;

            afisareTranzactii();
        }

        private void btnCalculTVA_Click(object sender, EventArgs e)
        {
            tbTVA.Text = (float.Parse(tbPret.Text) * 0.19).ToString();
        }

        private void btnCalculPretFinal_Click(object sender, EventArgs e)
        {
            tbPretFinal.Text = (float.Parse(tbPret.Text) + float.Parse(tbTVA.Text)).ToString();
        }

        void afisareTranzactii()
        {
            lvTranzactii.Items.Clear();
            foreach(Tranzactie t in tranzactii)
            {
                ListViewItem item = new ListViewItem(t.idTranzactie.ToString());
                item.SubItems.Add(t.numeClient);
                item.SubItems.Add(t.prenumeClient);
                item.SubItems.Add(t.pret.ToString());
                item.SubItems.Add(t.TVA().ToString());
                item.SubItems.Add(t.pretFinal().ToString());
                item.SubItems.Add(t.nrFactura.ToString());

                item.Tag = t;

                lvTranzactii.Items.Add(item);
            }

        }

        private void btnStergereTranzactie_Click(object sender, EventArgs e)
        {
            if (lvTranzactii.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o stergeti!");
            }
            else
            {
                if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti inregistrarea?", "Sterge", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem selectedItem = lvTranzactii.SelectedItems[0];

                    Tranzactie t = (Tranzactie)selectedItem.Tag;

                    tranzactii.Remove(t);

                    afisareTranzactii();
                }
            }
        }

        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if (tbId.Text.Trim().Length == 0)
                errorProvider.SetError(tbId, "Introduceti id-ul tranzactiei!");
            else
                errorProvider.SetError(tbId, null);
        }

        private void tbNumeClient_Validating(object sender, CancelEventArgs e)
        {
            if (tbNumeClient.Text.Trim().Length < 3)
                errorProvider.SetError(tbNumeClient, "Textul introdus contine mai putin de 3 caractere!");
            else
                errorProvider.SetError(tbNumeClient, null);
        }

        private void tbPrenumeClient_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrenumeClient.Text.Trim().Length < 3)
                errorProvider.SetError(tbPrenumeClient, "Textul introdus contine mai putin de 3 caractere!");
            else
                errorProvider.SetError(tbPrenumeClient, null);
        }

        private void tbNrFactura_Validating(object sender, CancelEventArgs e)
        {
            if (tbNrFactura.Text.Trim().Length == 0)
                errorProvider.SetError(tbNrFactura, "Introduceti numarul facturii!");
            else
                errorProvider.SetError(tbNrFactura, null);
        }

        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void tbPret_Validating(object sender, CancelEventArgs e)
        {
            if (tbPret.Text.Trim().Length == 0)
                errorProvider.SetError(tbPret, "Introduceti pretul tranzactiei!");
            else
                errorProvider.SetError(tbPret, null);
        }

        private void tbNrFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void btnEditareTranzactie_Click(object sender, EventArgs e)
        {
            if (lvTranzactii.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o editati!");
            }
            else
            {
                ListViewItem selectedItem = lvTranzactii.SelectedItems[0];
                Tranzactie t = (Tranzactie)selectedItem.Tag; //tag stocheaza un atribut de tip object, de-asta trebuie facut cast


                EditareTranzactie editForm = new EditareTranzactie(t);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    afisareTranzactii();
                }
            }
        }

        private void btnSerializareTranzactii_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fisierTranzactii = File.Create("serializareTranzactii.bin"))
            {
                formatter.Serialize(fisierTranzactii, tranzactii);
            }
        }

        private void btnListTranzactii_Click(object sender, EventArgs e)
        {
            lvTranzactii.View = View.List;
        }

        private void btnDetailsTranzactii_Click(object sender, EventArgs e)
        {
            lvTranzactii.View = View.Details;
        }

        private void btnDeserializareTranzactii_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fisierTranzactii = File.OpenRead("serializareTranzactii.bin"))
            {
                tranzactii = (List<Tranzactie>)formatter.Deserialize(fisierTranzactii);

                afisareTranzactii();
            }
        }

        private void btnSerializareXMLTranzactii_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Tranzactie>));
            using (FileStream fisierTranzactii = File.Create("serializareTranzactii.xml"))
            {
                serializer.Serialize(fisierTranzactii, tranzactii);
            }
        }

        private void btnDeserializareXMLTranzactii_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Tranzactie>));
            using (FileStream fisierTranzactii = File.OpenRead("serializareTranzactii.xml"))
            {
                tranzactii = (List<Tranzactie>)serializer.Deserialize(fisierTranzactii);

                afisareTranzactii();
            }
        }

        private void btnAdaugaTranzactie_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelTranzactii.Text = "Click pentru a adauga o noua tranzactie";
        }

        private void btnAdaugaTranzactie_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelTranzactii.Text = "";
        }

        private void btnEditareTranzactie_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelTranzactii.Text = "Click pentru a edita o tranzactie";
        }

        private void btnEditareTranzactie_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelTranzactii.Text = "";
        }

        private void btnStergereTranzactie_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelTranzactii.Text = "Click pentru a sterge o tranzactie";
        }

        private void btnStergereTranzactie_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelTranzactii.Text = "";
        }

        private void frmTranzactii_Load(object sender, EventArgs e)
        {
            statusStripTranzactii.BackColor = Color.White;
        }

        private void toolStripButtonSaveTranzactii_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV | *.csv";
            saveFileDialog.Title = "Export in format csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Id, Nume, Prenume, Pret, TVA, PretFinal, NrFactura");

                    foreach (Tranzactie t in tranzactii)
                        sw.WriteLine($"{t.idTranzactie},{t.numeClient},{t.prenumeClient},{t.pret},{t.TVA()}, {t.pretFinal()}, {t.nrFactura}");
                }
            }
        }

        int currentPrintIndex = 0;

        private void printDocumentTranzactii_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            currentPrintIndex = 0;
        }

        private void tsbPrintPreviewTranzactii_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialogTranzactii.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void tsbPrintTranzactii_Click(object sender, EventArgs e)
        {
            if (printDialogTranzactii.ShowDialog() == DialogResult.OK)
                printDocumentTranzactii.Print();
        }

        private void printDocumentTranzactii_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Calibri", 12);
            int currentY = printDocumentTranzactii.DefaultPageSettings.Margins.Top;
            while (currentPrintIndex < tranzactii.Count)
            {
                Tranzactie tranzactie = tranzactii[currentPrintIndex];
                e.Graphics.DrawString($"{tranzactie.idTranzactie} {tranzactie.numeClient} {tranzactie.prenumeClient} {tranzactie.nrFactura} {tranzactie.pret} {tranzactie.TVA()} {tranzactie.pretFinal()}", font, Brushes.Black, printDocumentTranzactii.DefaultPageSettings.Margins.Left, currentY);
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
