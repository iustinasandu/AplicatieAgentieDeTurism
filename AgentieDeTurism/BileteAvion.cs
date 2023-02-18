using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
    public partial class frmBileteAvion : Form
    {
        private const string ConnectionString = "Data source=BazaDeDate.db";
        private List<BiletAvion> bilete;
        public frmBileteAvion()
        {
            InitializeComponent();
            bilete = new List<BiletAvion>();
        }

        private void btnAdaugaBilet_Click(object sender, EventArgs e)
        {
            DateTime dataPlecare = dtpDataPlecare.Value;
            DateTime dataIntoarcere = dtpDataIntoarcere.Value;
            string orasPlecare = tbOrasPlecare.Text;
            string orasDestinatie = tbOrasDestinatie.Text;
            string nrLoc = tbNrLoc.Text;
            float pret = float.Parse(tbPret.Text);

            bool formValid = true;
            if (orasPlecare.Trim().Length < 3)
            {
                errorProvider.SetError(tbOrasPlecare, "Textul introdus contine mai putin de 3 caractere!");
                formValid = false;
            }

            if (orasDestinatie.Trim().Length < 3)
            {
                errorProvider.SetError(tbOrasDestinatie, "Textul introdus contine mai putin de 3 caractere!");
                formValid = false;
            }

            if (nrLoc.Trim().Length == 0)
            {
                errorProvider.SetError(tbNrLoc, "Textul introdus contine mai putin de 3 caractere!");
                formValid = false;
            }

            if (pret == 0)
            {
                errorProvider.SetError(tbPret, "Introduceti pretul biletului!");
                formValid = false;
            }

            if (!formValid)
            {
                MessageBox.Show("Formularul contine erori!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BiletAvion bilet = new BiletAvion(dataPlecare, dataIntoarcere, orasPlecare, orasDestinatie, nrLoc, pret);
            //bilete.Add(bilet);
            AdaugaBiletBD(bilet);

            dtpDataPlecare.Value = DateTime.Now;
            dtpDataIntoarcere.Value = DateTime.Now;
            tbOrasPlecare.Text = string.Empty;
            tbOrasDestinatie.Text = string.Empty;
            tbNrLoc.Text = string.Empty;
            tbPret.Text = string.Empty;

            afisareBilete();

        }

        void afisareBilete()
        {
            lvBilete.Items.Clear();
            foreach(BiletAvion b in bilete)
            {
                ListViewItem item = new ListViewItem(b.dataPlecare.ToShortDateString());
                item.SubItems.Add(b.dataIntoarcere.ToShortDateString());
                item.SubItems.Add(b.orasPlecare);
                item.SubItems.Add(b.orasDestinatie);
                item.SubItems.Add(b.nrLoc);
                item.SubItems.Add(b.pret.ToString());

                item.Tag = b;

                lvBilete.Items.Add(item);
            }
        }

        public void AdaugaBiletBD(BiletAvion bilet)
        {
            var query = "INSERT INTO BiletAvion(DataPlecare, DataIntoarcere, OrasPlecare, OrasDestinatie, NrLoc, Pret) " + " VALUES (@dataPlecare, @dataIntoarcere, @orasPlecare, @orasDestinatie, @nrLoc, @pret); " + " SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@dataPlecare", bilet.dataPlecare);
                command.Parameters.AddWithValue("@dataIntoarcere", bilet.dataIntoarcere);
                command.Parameters.AddWithValue("@orasPlecare", bilet.orasPlecare);
                command.Parameters.AddWithValue("@orasDestinatie", bilet.orasDestinatie);
                command.Parameters.AddWithValue("@nrLoc", bilet.nrLoc);
                command.Parameters.AddWithValue("@pret", bilet.pret);

                connection.Open();
                bilet.IdBilet = (long)command.ExecuteScalar();

                bilete.Add(bilet);
            }
        }

        public void LoadBilete()
        {
            var query = "SELECT * FROM BiletAvion";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);

                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long IdBilet = (long)reader["idBilet"];
                        DateTime dataPlecare = DateTime.Parse((string)reader["dataPlecare"]);
                        DateTime dataIntoarcere = DateTime.Parse((string)reader["dataIntoarcere"]);
                        string orasPlecare = (string)reader["orasPlecare"];
                        string orasDestinatie = (string)reader["orasDestinatie"];
                        string nrLoc = (string)reader["nrLoc"];
                        long pret = (long)reader["pret"];

                        BiletAvion bilet = new BiletAvion(IdBilet, dataPlecare, dataIntoarcere, orasPlecare, orasDestinatie, nrLoc, pret);
                        bilete.Add(bilet);
                    }
                }
            }

        }

        void StergereBiletBD(BiletAvion bilet)
        {
            var query = "DELETE FROM BiletAvion WHERE IdBilet=@idBilet";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@idBilet", bilet.IdBilet);

                connection.Open();
                command.ExecuteNonQuery();

                bilete.Remove(bilet);
            }
        }

        private void btnStergereBilet_Click(object sender, EventArgs e)
        {
            if (lvBilete.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o stergeti!");
            }
            else
            {
                if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti inregistrarea?", "Sterge", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem selectedItem = lvBilete.SelectedItems[0];

                    BiletAvion b = (BiletAvion)selectedItem.Tag;

                    //bilete.Remove(b);
                    StergereBiletBD(b);
                    afisareBilete();
                }
            }
        }


        private void tbOrasPlecare_Validating(object sender, CancelEventArgs e)
        {
            if (tbOrasPlecare.Text.Trim().Length < 3)
                errorProvider.SetError(tbOrasPlecare, "Textul introdus contine mai putin de 3 caractere!");
            else
                errorProvider.SetError(tbOrasPlecare, null);
        }

        private void tbOrasDestinatie_Validating(object sender, CancelEventArgs e)
        {
            if (tbOrasDestinatie.Text.Trim().Length < 3)
                errorProvider.SetError(tbOrasDestinatie, "Textul introdus contine mai putin de 3 caractere!");
            else
                errorProvider.SetError(tbOrasDestinatie, null);
        }

        private void tbPret_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         
            if (e.KeyChar == (char)8) e.Handled = false;
        }

        private void tbNrLoc_Validating(object sender, CancelEventArgs e)
        {
            if (tbNrLoc.Text.Trim().Length == 0)
                errorProvider.SetError(tbNrLoc, "Introduceti numarul locului!");
            else
                errorProvider.SetError(tbNrLoc, null);
        }

        private void tbPret_Validating(object sender, CancelEventArgs e)
        {
            if (tbPret.Text.Trim().Length == 0)
                errorProvider.SetError(tbPret, "Introduceti pretul biletului!");
            else
                errorProvider.SetError(tbPret, null);
        }

        private void btnEditareBilet_Click(object sender, EventArgs e)
        {
            if (lvBilete.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o editati!");
            }
            else
            {
                ListViewItem selectedItem = lvBilete.SelectedItems[0];
                BiletAvion b = (BiletAvion)selectedItem.Tag; //tag stocheaza un atribut de tip object, de-asta trebuie facut cast


                EditareBiletAvioncs editForm = new EditareBiletAvioncs(b);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    var querry = "UPDATE BiletAvion SET DataPlecare = @dataPlecare, DataIntoarcere = @dataIntoarcere, OrasPlecare = @orasPlecare, OrasDestinatie = @orasDestinatie, NrLoc = @nrLoc, Pret = @pret WHERE IdBilet = @idBilet";
                    using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand(querry, connection))
                        {
                            command.Parameters.AddWithValue("@idBilet", b.IdBilet);
                            command.Parameters.AddWithValue("@dataPlecare", b.dataPlecare);
                            command.Parameters.AddWithValue("@dataIntoarcere", b.dataIntoarcere);
                            command.Parameters.AddWithValue("@orasPlecare", b.orasPlecare);
                            command.Parameters.AddWithValue("@orasDestinatie", b.orasDestinatie);
                            command.Parameters.AddWithValue("@nrLoc", b.nrLoc);
                            command.Parameters.AddWithValue("@pret", b.pret);
                            command.ExecuteNonQuery();

                        }
                    }
                    afisareBilete();
                }
            }
        }

        private void btnSerializareBilete_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fisierBilete = File.Create("serializareBilete.bin"))
            {
                formatter.Serialize(fisierBilete, bilete);
            }
        }

        private void btnListBilete_Click(object sender, EventArgs e)
        {
            lvBilete.View = View.List;
        }

        private void btnDetailsBilete_Click(object sender, EventArgs e)
        {
            lvBilete.View = View.Details;
        }

        private void btnDeserializareBilete_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fisierBilete = File.OpenRead("serializareBilete.bin"))
            {
                bilete = (List<BiletAvion>)formatter.Deserialize(fisierBilete);

                afisareBilete();
            }
        }

        private void btnSerializareXMLBilete_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<BiletAvion>));
            using (FileStream fisierBilete = File.Create("serializareBilete.xml"))
            {
                serializer.Serialize(fisierBilete, bilete);
            }
        }

        private void btnDeserializareXMLBilete_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<BiletAvion>));
            using (FileStream fisierBilete = File.OpenRead("serializareBilete.xml"))
            {
                bilete = (List<BiletAvion>)serializer.Deserialize(fisierBilete);

                afisareBilete();
            }
        }


        private void btnAdaugaBilet_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelBilete.Text = "Click pentru a adauga un nou bilet";
        }

        private void btnAdaugaBilet_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelBilete.Text = "";
        }

        private void btnEditareBilet_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelBilete.Text = "Click pentru a edita un bilet";
        }

        private void btnEditareBilet_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelBilete.Text = "";
        }

        private void btnStergereBilet_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelBilete.Text = "Click pentru a sterge un bilet";
        }

        private void btnStergereBilet_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelBilete.Text = "";
        }

        private void frmBileteAvion_Load(object sender, EventArgs e)
        {
            statusStripBilete.BackColor = Color.White;
            LoadBilete();
            afisareBilete();
        }

        private void toolStripButtonSaveBilete_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV | *.csv";
            saveFileDialog.Title = "Export in format csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("DataPlecare, DataIntoarcere, OrasPlecare, OrasDestinatie, NrLoc, Pret");

                    foreach (BiletAvion b in bilete)
                        sw.WriteLine($"{b.dataPlecare.ToShortDateString()},{b.dataIntoarcere.ToShortDateString()},{b.orasPlecare},{b.orasDestinatie},{b.nrLoc}, {b.pret}");
                }
            }
        }

        int currentPrintIndex = 0;

        private void printDocumentBilete_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            currentPrintIndex = 0;
        }

        private void tsbPrintPreviewBilete_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialogBilete.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void tsbPrintBilete_Click(object sender, EventArgs e)
        {
            if (printDialogBilete.ShowDialog() == DialogResult.OK)
                printDocumentBilete.Print();
        }

        private void printDocumentBilete_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Calibri", 12);
            int currentY = printDocumentBilete.DefaultPageSettings.Margins.Top;
            while (currentPrintIndex < bilete.Count)
            {
                BiletAvion bilet = bilete[currentPrintIndex];
                e.Graphics.DrawString($"{bilet.dataPlecare} {bilet.dataIntoarcere} {bilet.orasPlecare} {bilet.orasDestinatie} {bilet.nrLoc} {bilet.pret}",
                                         font, Brushes.Black, printDocumentBilete.DefaultPageSettings.Margins.Left, currentY);
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
