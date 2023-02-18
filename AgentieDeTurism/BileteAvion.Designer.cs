
namespace AgentieDeTurism
{
    partial class frmBileteAvion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBileteAvion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStergereBilet = new System.Windows.Forms.Button();
            this.btnEditareBilet = new System.Windows.Forms.Button();
            this.dtpDataIntoarcere = new System.Windows.Forms.DateTimePicker();
            this.dtpDataPlecare = new System.Windows.Forms.DateTimePicker();
            this.btnAdaugaBilet = new System.Windows.Forms.Button();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbNrLoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbOrasDestinatie = new System.Windows.Forms.TextBox();
            this.tbOrasPlecare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lvBilete = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializareBinaraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializareBilete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializareBilete = new System.Windows.Forms.ToolStripMenuItem();
            this.serializareXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSerializareXMLBilete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeserializareXMLBilete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDetailsBilete = new System.Windows.Forms.Button();
            this.btnListBilete = new System.Windows.Forms.Button();
            this.statusStripBilete = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelBilete = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSaveBilete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrintBilete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPrintPreviewBilete = new System.Windows.Forms.ToolStripButton();
            this.printDialogBilete = new System.Windows.Forms.PrintDialog();
            this.printDocumentBilete = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogBilete = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStripBilete.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(186)))));
            this.groupBox1.Controls.Add(this.btnStergereBilet);
            this.groupBox1.Controls.Add(this.btnEditareBilet);
            this.groupBox1.Controls.Add(this.dtpDataIntoarcere);
            this.groupBox1.Controls.Add(this.dtpDataPlecare);
            this.groupBox1.Controls.Add(this.btnAdaugaBilet);
            this.groupBox1.Controls.Add(this.tbPret);
            this.groupBox1.Controls.Add(this.tbNrLoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbOrasDestinatie);
            this.groupBox1.Controls.Add(this.tbOrasPlecare);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 243);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnStergereBilet
            // 
            this.btnStergereBilet.BackColor = System.Drawing.Color.White;
            this.btnStergereBilet.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStergereBilet.Location = new System.Drawing.Point(307, 186);
            this.btnStergereBilet.Name = "btnStergereBilet";
            this.btnStergereBilet.Size = new System.Drawing.Size(130, 27);
            this.btnStergereBilet.TabIndex = 12;
            this.btnStergereBilet.Text = "&Sterge bilet";
            this.btnStergereBilet.UseVisualStyleBackColor = false;
            this.btnStergereBilet.Click += new System.EventHandler(this.btnStergereBilet_Click);
            this.btnStergereBilet.MouseLeave += new System.EventHandler(this.btnStergereBilet_MouseLeave);
            this.btnStergereBilet.MouseHover += new System.EventHandler(this.btnStergereBilet_MouseHover);
            // 
            // btnEditareBilet
            // 
            this.btnEditareBilet.BackColor = System.Drawing.Color.White;
            this.btnEditareBilet.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditareBilet.Location = new System.Drawing.Point(158, 186);
            this.btnEditareBilet.Name = "btnEditareBilet";
            this.btnEditareBilet.Size = new System.Drawing.Size(130, 27);
            this.btnEditareBilet.TabIndex = 11;
            this.btnEditareBilet.Text = "&Editeaza bilet";
            this.btnEditareBilet.UseVisualStyleBackColor = false;
            this.btnEditareBilet.Click += new System.EventHandler(this.btnEditareBilet_Click);
            this.btnEditareBilet.MouseLeave += new System.EventHandler(this.btnEditareBilet_MouseLeave);
            this.btnEditareBilet.MouseHover += new System.EventHandler(this.btnEditareBilet_MouseHover);
            // 
            // dtpDataIntoarcere
            // 
            this.dtpDataIntoarcere.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataIntoarcere.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataIntoarcere.Location = new System.Drawing.Point(148, 57);
            this.dtpDataIntoarcere.Name = "dtpDataIntoarcere";
            this.dtpDataIntoarcere.Size = new System.Drawing.Size(289, 26);
            this.dtpDataIntoarcere.TabIndex = 2;
            // 
            // dtpDataPlecare
            // 
            this.dtpDataPlecare.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPlecare.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataPlecare.Location = new System.Drawing.Point(148, 15);
            this.dtpDataPlecare.Name = "dtpDataPlecare";
            this.dtpDataPlecare.Size = new System.Drawing.Size(289, 26);
            this.dtpDataPlecare.TabIndex = 1;
            // 
            // btnAdaugaBilet
            // 
            this.btnAdaugaBilet.BackColor = System.Drawing.Color.White;
            this.btnAdaugaBilet.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaBilet.Location = new System.Drawing.Point(10, 186);
            this.btnAdaugaBilet.Name = "btnAdaugaBilet";
            this.btnAdaugaBilet.Size = new System.Drawing.Size(130, 27);
            this.btnAdaugaBilet.TabIndex = 7;
            this.btnAdaugaBilet.Text = "&Adauga bilet";
            this.btnAdaugaBilet.UseVisualStyleBackColor = false;
            this.btnAdaugaBilet.Click += new System.EventHandler(this.btnAdaugaBilet_Click);
            this.btnAdaugaBilet.MouseLeave += new System.EventHandler(this.btnAdaugaBilet_MouseLeave);
            this.btnAdaugaBilet.MouseHover += new System.EventHandler(this.btnAdaugaBilet_MouseHover);
            // 
            // tbPret
            // 
            this.tbPret.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPret.Location = new System.Drawing.Point(569, 98);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(59, 26);
            this.tbPret.TabIndex = 6;
            this.tbPret.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPret_KeyPress);
            this.tbPret.Validating += new System.ComponentModel.CancelEventHandler(this.tbPret_Validating);
            // 
            // tbNrLoc
            // 
            this.tbNrLoc.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNrLoc.Location = new System.Drawing.Point(569, 56);
            this.tbNrLoc.Name = "tbNrLoc";
            this.tbNrLoc.Size = new System.Drawing.Size(59, 26);
            this.tbNrLoc.TabIndex = 5;
            this.tbNrLoc.Validating += new System.ComponentModel.CancelEventHandler(this.tbNrLoc_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pret:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(473, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nr loc:";
            // 
            // tbOrasDestinatie
            // 
            this.tbOrasDestinatie.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrasDestinatie.Location = new System.Drawing.Point(148, 139);
            this.tbOrasDestinatie.Name = "tbOrasDestinatie";
            this.tbOrasDestinatie.Size = new System.Drawing.Size(289, 26);
            this.tbOrasDestinatie.TabIndex = 4;
            this.tbOrasDestinatie.Validating += new System.ComponentModel.CancelEventHandler(this.tbOrasDestinatie_Validating);
            // 
            // tbOrasPlecare
            // 
            this.tbOrasPlecare.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrasPlecare.Location = new System.Drawing.Point(148, 102);
            this.tbOrasPlecare.Name = "tbOrasPlecare";
            this.tbOrasPlecare.Size = new System.Drawing.Size(289, 26);
            this.tbOrasPlecare.TabIndex = 3;
            this.tbOrasPlecare.Validating += new System.ComponentModel.CancelEventHandler(this.tbOrasPlecare_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Oras destinatie:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oras plecare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data intoarcere:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data plecare:";
            // 
            // lvBilete
            // 
            this.lvBilete.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvBilete.FullRowSelect = true;
            this.lvBilete.GridLines = true;
            this.lvBilete.HideSelection = false;
            this.lvBilete.Location = new System.Drawing.Point(12, 345);
            this.lvBilete.Name = "lvBilete";
            this.lvBilete.Size = new System.Drawing.Size(782, 259);
            this.lvBilete.TabIndex = 1;
            this.lvBilete.UseCompatibleStateImageBehavior = false;
            this.lvBilete.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Data plecare";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data intoarcere";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Oras plecare";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Oras destinatie";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nr loc";
            this.columnHeader5.Width = 93;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Pret";
            this.columnHeader6.Width = 108;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareBinaraToolStripMenuItem,
            this.serializareXMLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializareBinaraToolStripMenuItem
            // 
            this.serializareBinaraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializareBilete,
            this.btnDeserializareBilete});
            this.serializareBinaraToolStripMenuItem.Name = "serializareBinaraToolStripMenuItem";
            this.serializareBinaraToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.serializareBinaraToolStripMenuItem.Text = "Serializare binara";
            // 
            // btnSerializareBilete
            // 
            this.btnSerializareBilete.Name = "btnSerializareBilete";
            this.btnSerializareBilete.Size = new System.Drawing.Size(139, 22);
            this.btnSerializareBilete.Text = "Serializare";
            this.btnSerializareBilete.Click += new System.EventHandler(this.btnSerializareBilete_Click);
            // 
            // btnDeserializareBilete
            // 
            this.btnDeserializareBilete.Name = "btnDeserializareBilete";
            this.btnDeserializareBilete.Size = new System.Drawing.Size(139, 22);
            this.btnDeserializareBilete.Text = "Deserializare";
            this.btnDeserializareBilete.Click += new System.EventHandler(this.btnDeserializareBilete_Click);
            // 
            // serializareXMLToolStripMenuItem
            // 
            this.serializareXMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSerializareXMLBilete,
            this.btnDeserializareXMLBilete});
            this.serializareXMLToolStripMenuItem.Name = "serializareXMLToolStripMenuItem";
            this.serializareXMLToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.serializareXMLToolStripMenuItem.Text = "Serializare XML";
            // 
            // btnSerializareXMLBilete
            // 
            this.btnSerializareXMLBilete.Name = "btnSerializareXMLBilete";
            this.btnSerializareXMLBilete.Size = new System.Drawing.Size(139, 22);
            this.btnSerializareXMLBilete.Text = "Serializare";
            this.btnSerializareXMLBilete.Click += new System.EventHandler(this.btnSerializareXMLBilete_Click);
            // 
            // btnDeserializareXMLBilete
            // 
            this.btnDeserializareXMLBilete.Name = "btnDeserializareXMLBilete";
            this.btnDeserializareXMLBilete.Size = new System.Drawing.Size(139, 22);
            this.btnDeserializareXMLBilete.Text = "Deserializare";
            this.btnDeserializareXMLBilete.Click += new System.EventHandler(this.btnDeserializareXMLBilete_Click);
            // 
            // btnDetailsBilete
            // 
            this.btnDetailsBilete.BackColor = System.Drawing.Color.White;
            this.btnDetailsBilete.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailsBilete.Location = new System.Drawing.Point(140, 312);
            this.btnDetailsBilete.Name = "btnDetailsBilete";
            this.btnDetailsBilete.Size = new System.Drawing.Size(104, 27);
            this.btnDetailsBilete.TabIndex = 14;
            this.btnDetailsBilete.Text = "&Details";
            this.btnDetailsBilete.UseVisualStyleBackColor = false;
            this.btnDetailsBilete.Click += new System.EventHandler(this.btnDetailsBilete_Click);
            // 
            // btnListBilete
            // 
            this.btnListBilete.BackColor = System.Drawing.Color.White;
            this.btnListBilete.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListBilete.Location = new System.Drawing.Point(12, 312);
            this.btnListBilete.Name = "btnListBilete";
            this.btnListBilete.Size = new System.Drawing.Size(107, 27);
            this.btnListBilete.TabIndex = 13;
            this.btnListBilete.Text = "&List";
            this.btnListBilete.UseVisualStyleBackColor = false;
            this.btnListBilete.Click += new System.EventHandler(this.btnListBilete_Click);
            // 
            // statusStripBilete
            // 
            this.statusStripBilete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelBilete});
            this.statusStripBilete.Location = new System.Drawing.Point(0, 605);
            this.statusStripBilete.Name = "statusStripBilete";
            this.statusStripBilete.Size = new System.Drawing.Size(806, 22);
            this.statusStripBilete.TabIndex = 15;
            this.statusStripBilete.Text = "statusStrip1";
            // 
            // toolStripStatusLabelBilete
            // 
            this.toolStripStatusLabelBilete.Name = "toolStripStatusLabelBilete";
            this.toolStripStatusLabelBilete.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSaveBilete,
            this.toolStripSeparator1,
            this.tsbPrintBilete,
            this.toolStripSeparator2,
            this.tsbPrintPreviewBilete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(806, 33);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSaveBilete
            // 
            this.tsbSaveBilete.AutoSize = false;
            this.tsbSaveBilete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSaveBilete.Image = ((System.Drawing.Image)(resources.GetObject("tsbSaveBilete.Image")));
            this.tsbSaveBilete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSaveBilete.Name = "tsbSaveBilete";
            this.tsbSaveBilete.Size = new System.Drawing.Size(30, 30);
            this.tsbSaveBilete.Text = "Save Bilete";
            this.tsbSaveBilete.Click += new System.EventHandler(this.toolStripButtonSaveBilete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbPrintBilete
            // 
            this.tsbPrintBilete.AutoSize = false;
            this.tsbPrintBilete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrintBilete.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintBilete.Image")));
            this.tsbPrintBilete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintBilete.Name = "tsbPrintBilete";
            this.tsbPrintBilete.Size = new System.Drawing.Size(30, 30);
            this.tsbPrintBilete.Text = "Print Bilete";
            this.tsbPrintBilete.Click += new System.EventHandler(this.tsbPrintBilete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // tsbPrintPreviewBilete
            // 
            this.tsbPrintPreviewBilete.AutoSize = false;
            this.tsbPrintPreviewBilete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrintPreviewBilete.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrintPreviewBilete.Image")));
            this.tsbPrintPreviewBilete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrintPreviewBilete.Name = "tsbPrintPreviewBilete";
            this.tsbPrintPreviewBilete.Size = new System.Drawing.Size(30, 30);
            this.tsbPrintPreviewBilete.Text = "Print Preview Bilete";
            this.tsbPrintPreviewBilete.Click += new System.EventHandler(this.tsbPrintPreviewBilete_Click);
            // 
            // printDialogBilete
            // 
            this.printDialogBilete.Document = this.printDocumentBilete;
            this.printDialogBilete.UseEXDialog = true;
            // 
            // printDocumentBilete
            // 
            this.printDocumentBilete.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocumentBilete_BeginPrint);
            this.printDocumentBilete.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentBilete_PrintPage);
            // 
            // printPreviewDialogBilete
            // 
            this.printPreviewDialogBilete.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogBilete.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogBilete.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogBilete.Document = this.printDocumentBilete;
            this.printPreviewDialogBilete.Enabled = true;
            this.printPreviewDialogBilete.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogBilete.Icon")));
            this.printPreviewDialogBilete.Name = "printPreviewDialogTuristi";
            this.printPreviewDialogBilete.Visible = false;
            // 
            // frmBileteAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(806, 627);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStripBilete);
            this.Controls.Add(this.btnDetailsBilete);
            this.Controls.Add(this.btnListBilete);
            this.Controls.Add(this.lvBilete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmBileteAvion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilete de avion";
            this.Load += new System.EventHandler(this.frmBileteAvion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripBilete.ResumeLayout(false);
            this.statusStripBilete.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOrasDestinatie;
        private System.Windows.Forms.TextBox tbOrasPlecare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbNrLoc;
        private System.Windows.Forms.Button btnAdaugaBilet;
        private System.Windows.Forms.ListView lvBilete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.DateTimePicker dtpDataIntoarcere;
        private System.Windows.Forms.DateTimePicker dtpDataPlecare;
        private System.Windows.Forms.Button btnStergereBilet;
        private System.Windows.Forms.Button btnEditareBilet;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareBinaraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializareBilete;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializareBilete;
        private System.Windows.Forms.Button btnDetailsBilete;
        private System.Windows.Forms.Button btnListBilete;
        private System.Windows.Forms.ToolStripMenuItem serializareXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSerializareXMLBilete;
        private System.Windows.Forms.ToolStripMenuItem btnDeserializareXMLBilete;
        private System.Windows.Forms.StatusStrip statusStripBilete;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBilete;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSaveBilete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPrintBilete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbPrintPreviewBilete;
        private System.Windows.Forms.PrintDialog printDialogBilete;
        private System.Drawing.Printing.PrintDocument printDocumentBilete;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogBilete;
    }
}