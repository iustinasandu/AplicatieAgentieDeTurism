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
using System.Drawing;
using System.Data.SQLite;

namespace AgentieDeTurism
{
    public partial class frmTuristi : Form
    {
        private const string ConnectionString = "Data source=BazaDeDate.db";
        private List<Turist> turisti;

        public frmTuristi()
        {
            InitializeComponent();
            turisti = new List<Turist>();
        }

        private void btnAdaugaTurist_Click(object sender, EventArgs e)
        {
            string nume = tbNume.Text;
            string prenume = tbPrenume.Text;
            DateTime dataNasterii = dtpDataNasterii.Value;
            string telefon = tbTelefon.Text;
            string email = tbEmail.Text;

            bool formValid = true;
            if(nume.Trim().Length<3)
            {
                errorProvider.SetError(tbNume, "Textul introdus contine mai putin de 3 caractere!");
                formValid = false;
            }

            if (prenume.Trim().Length < 3)
            {
                errorProvider.SetError(tbPrenume, "Textul introdus contine mai putin de 3 caractere!");
                formValid = false;
            }

            if(dataNasterii > DateTime.Now)
            {
                errorProvider.SetError(dtpDataNasterii, "Data nasterii trebuie sa fie anterioara datei curente!");
                formValid = false;
            }

            if(telefon.Trim().Length != 10)
            {
                errorProvider.SetError(tbTelefon, "Numarul de telefon trebuie sa fie format din 10 cifre!");
                formValid = false;
            }

            if ((tbEmail.Text.Trim().Length == 0) || (!tbEmail.Text.Contains('@') || !tbEmail.Text.Contains('.'))) 
            {
                errorProvider.SetError(tbEmail, "Adresa de e-mail invalida!");
                formValid = false;
            }

            if (!formValid)
            {
                MessageBox.Show("Formularul contine erori!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Turist turist = new Turist(nume, prenume, dataNasterii, telefon, email);
            //turisti.Add(turist);
            AdaugaTuristBD(turist);

            tbNume.Text = string.Empty;
            tbPrenume.Text = string.Empty;
            dtpDataNasterii.Value = DateTime.Now;
            tbTelefon.Text = string.Empty;
            tbEmail.Text = string.Empty;

            afisareTuristi();
        }

        void afisareTuristi()
        {
            lvTuristi.Items.Clear();
            foreach(Turist t in turisti)
            {
                ListViewItem item = new ListViewItem(t.nume);
                item.SubItems.Add(t.prenume);
                item.SubItems.Add(t.data_nasterii.ToShortDateString());
                item.SubItems.Add(t.telefon);
                item.SubItems.Add(t.email);

                item.Tag = t; //stocam prin tag turistul t pt care a fost creat listView item-ul

                lvTuristi.Items.Add(item);
            }
        }

        public void AdaugaTuristBD(Turist turist)
        {
            var query = "INSERT INTO Turist(Nume, Prenume, DataNasterii, Telefon, Email) " + " VALUES (@nume, @prenume, @dataNasterii, @telefon, @email); " + " SELECT last_insert_rowid()";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@nume", turist.nume);
                command.Parameters.AddWithValue("@prenume", turist.prenume);
                command.Parameters.AddWithValue("@dataNasterii", turist.data_nasterii);
                command.Parameters.AddWithValue("@telefon", turist.telefon);
                command.Parameters.AddWithValue("@email", turist.email);

                connection.Open();
                turist.IdTurist = (long)command.ExecuteScalar();

                turisti.Add(turist);
            }
        }

        public void LoadTuristi()
        {
            var query = "SELECT * FROM Turist";

            using(SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);

                connection.Open();
                using(SQLiteDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        long IdTurist = (long)reader["id"];
                        string nume = (string)reader["nume"];
                        string prenume = (string)reader["prenume"];
                        DateTime dataNasterii = DateTime.Parse((string)reader["dataNasterii"]);
                        string telefon = (string)reader["telefon"];
                        string email = (string)reader["email"];

                        Turist turist = new Turist(IdTurist, nume, prenume, dataNasterii, telefon, email);
                        turisti.Add(turist);
                    }
                }
            }
            
        }

        void StergereTuristBD(Turist turist)
        {
            var query = "DELETE FROM Turist WHERE Id=@id";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@id", turist.IdTurist);

                connection.Open();
                command.ExecuteNonQuery();

                turisti.Remove(turist);
            }
        }

        private void tbNume_Validating(object sender, CancelEventArgs e)
        {
            if (tbNume.Text.Trim().Length < 3)
                errorProvider.SetError(tbNume, "Textul introdus contine mai putin de 3 caractere!");
            else
                errorProvider.SetError(tbNume, null);
        }

        private void tbPrenume_Validating(object sender, CancelEventArgs e)
        {
            if (tbPrenume.Text.Trim().Length < 3)
                errorProvider.SetError(tbPrenume, "Textul introdus contine mai putin de 3 caractere!");
            else
                errorProvider.SetError(tbPrenume, null);
        }

        private void dtpDataNasterii_Validating(object sender, CancelEventArgs e)
        {
            if (dtpDataNasterii.Value > DateTime.Now)
                errorProvider.SetError(dtpDataNasterii, "Data nasterii trebuie sa fie anterioara datei curente!");
            else
                errorProvider.SetError(dtpDataNasterii, null);
        }

        private void tbTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (tbTelefon.Text.Trim().Length != 10)
                errorProvider.SetError(tbTelefon, "Numarul de telefon trebuie sa fie format din 10 cifre!");
            else
                errorProvider.SetError(tbTelefon, null);
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if ((tbEmail.Text.Trim().Length == 0) || (!tbEmail.Text.Contains('@') || !tbEmail.Text.Contains('.')))
                errorProvider.SetError(tbEmail, "Adresa de e-mail invalida!");
            else
                errorProvider.SetError(tbEmail, null);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lvTuristi.View = View.List;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            lvTuristi.View = View.Details;
        }

        private void tbTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //permite doar introducerea de cifre
            if (e.KeyChar == (char)8) e.Handled = false;            //permite apasarea tastei Backspace   
        }

        private void btnStergereTurist_Click(object sender, EventArgs e)
        {
            if(lvTuristi.SelectedItems.Count ==0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o stergeti!");
            }
            else
            {
                if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti inregistrarea?", "Sterge", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ListViewItem selectedItem = lvTuristi.SelectedItems[0]; //obtinere item selectat

                    //creare legatura dintre lvTuristi si turisti prin metoda afisareTuristi
                    Turist t = (Turist)selectedItem.Tag; //recuperez turistul salvat in tag

                    //turisti.Remove(t);
                    StergereTuristBD(t);
                    afisareTuristi();
                }
            }
        }

        private void btnEditareturist_Click(object sender, EventArgs e)
        {
            if(lvTuristi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selectati inregistrarea pe care doriti sa o editati!");
            }
            else
            {
                ListViewItem selectedItem = lvTuristi.SelectedItems[0];
                Turist t = (Turist)selectedItem.Tag; //tag stocheaza un atribut de tip object, de-asta trebuie facut cast


                EditareTurist editForm = new EditareTurist(t);
                if(editForm.ShowDialog()==DialogResult.OK)
                {
                    var querry = "UPDATE Turist SET Nume = @nume, Prenume = @prenume, DataNasterii = @dataNasterii, Telefon = @telefon, Email = @email WHERE Id = @id";
                    using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand(querry, connection))
                        {
                            command.Parameters.AddWithValue("@id", t.IdTurist);
                            command.Parameters.AddWithValue("@nume", t.nume);
                            command.Parameters.AddWithValue("@prenume", t.prenume);
                            command.Parameters.AddWithValue("@dataNasterii", t.data_nasterii);
                            command.Parameters.AddWithValue("@telefon", t.telefon);
                            command.Parameters.AddWithValue("@email", t.email);
                            command.ExecuteNonQuery();

                        }
                    }
                    afisareTuristi();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSerializare_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fisierTuristi = File.Create("serializareTuristi.bin"))
            {
                formatter.Serialize(fisierTuristi, turisti);
            }
        }

        private void btnDeserializare_Click(object sender, EventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fisierTuristi = File.OpenRead("serializareTuristi.bin"))
            {
                turisti = (List<Turist>)formatter.Deserialize(fisierTuristi);

                afisareTuristi();
            }
        }

        private void btnSerializareXMLTuristi_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Turist>));
            using(FileStream fisierTuristi = File.Create("serializareTuristi.xml"))
            {
                serializer.Serialize(fisierTuristi, turisti);
            }
        }

        private void btnDeserializareXMLTuristi_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Turist>));
            using (FileStream fisierTuristi = File.OpenRead("serializareTuristi.xml"))
            {
                turisti = (List<Turist>)serializer.Deserialize(fisierTuristi);

                afisareTuristi();
            }
        }

        private void btnAdaugaTurist_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelTurist.Text = "Click pentru a adauga un nou turist";
        }

        private void btnAdaugaTurist_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelTurist.Text = "";
        }

        private void btnEditareturist_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelTurist.Text = "Click pentru a edita un turist";
        }

        private void btnEditareturist_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelTurist.Text = "";
        }

        private void btnStergereTurist_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabelTurist.Text = "Click pentru a sterge un turist";
        }

        private void btnStergereTurist_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabelTurist.Text = "";
        }

        private void frmTuristi_Load(object sender, EventArgs e)
        {
            statusStripTuristi.BackColor = Color.White;
            LoadTuristi();
            afisareTuristi();
        }

        private void toolStripButtonSveTuristi_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV | *.csv";
            saveFileDialog.Title = "Export in format csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine("Nume, Prenume, DataNasterii, Telefon, Email");

                    foreach (Turist t in turisti)
                        sw.WriteLine($"{t.nume},{t.prenume},{t.data_nasterii.ToShortDateString()},{t.telefon},{t.email}");
                }
            }
        }

        private void printDocumentTuristi_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Calibri", 12);
            int currentY = printDocumentTuristi.DefaultPageSettings.Margins.Top;
            while(currentPrintIndex<turisti.Count)
            {
                Turist turist = turisti[currentPrintIndex];
                e.Graphics.DrawString($"{turist.nume} {turist.prenume} {turist.data_nasterii} {turist.telefon} {turist.email}", font, Brushes.Black, printDocumentTuristi.DefaultPageSettings.Margins.Left, currentY);
                currentY += 40;

                if(currentY > e.MarginBounds.Height) //suport pt mai multe pagini
                {
                    e.HasMorePages = true;
                    break;
                }

                currentPrintIndex++;
            }
        }

        int currentPrintIndex = 0;

        private void printDocumentTuristi_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            currentPrintIndex = 0;
        }

        private void tsbPrintPreviewTuristi_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialogTuristi.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void tsbPrintTuristi_Click(object sender, EventArgs e)
        {
            if (printDialogTuristi.ShowDialog() == DialogResult.OK)
                printDocumentTuristi.Print();
        }

        private void tbTelefon_MouseDown(object sender, MouseEventArgs e)
        {
            tbTelefon.SelectAll();
            lbCopiereDate.DoDragDrop(tbTelefon.Text, DragDropEffects.All);
        }
        private void lbCopiereDate_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            lbCopiereDate.Items.Add(e.Data.GetData(DataFormats.Text));
            tbNume.Clear();
            tbTelefon.Clear();
        }

        private void btnCopiereTelefon_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbCopiereDate.SelectedItem.ToString());
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    btnAdaugaTurist.ForeColor = cd.Color;
                }
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    btnAdaugaTurist.BackColor = cd.Color;
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    btnEditareturist.ForeColor = cd.Color;
                }
            }
        }

        private void bgTSEditare_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    btnEditareturist.BackColor = cd.Color;
                }
            }
        }

        private void fgTSStergere_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    btnStergereTurist.ForeColor = cd.Color;
                }
            }
        }

        private void bgTSStergere_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    btnStergereTurist.BackColor = cd.Color;
                }
            }
        }

        
    }
}