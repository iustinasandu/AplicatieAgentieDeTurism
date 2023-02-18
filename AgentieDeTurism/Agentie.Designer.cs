
namespace AgentieDeTurism
{
    partial class frmAgentie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgentie));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCazare = new System.Windows.Forms.Button();
            this.btnTranzactii = new System.Windows.Forms.Button();
            this.btnBileteAvion = new System.Windows.Forms.Button();
            this.btnTuristi = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(239)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCazare);
            this.panel1.Controls.Add(this.btnTranzactii);
            this.panel1.Controls.Add(this.btnBileteAvion);
            this.panel1.Controls.Add(this.btnTuristi);
            this.panel1.Location = new System.Drawing.Point(1, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 127);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(810, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 559);
            this.panel2.TabIndex = 3;
            // 
            // btnCazare
            // 
            this.btnCazare.BackColor = System.Drawing.Color.White;
            this.btnCazare.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCazare.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCazare.ForeColor = System.Drawing.Color.Black;
            this.btnCazare.Image = ((System.Drawing.Image)(resources.GetObject("btnCazare.Image")));
            this.btnCazare.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCazare.Location = new System.Drawing.Point(201, 17);
            this.btnCazare.Name = "btnCazare";
            this.btnCazare.Size = new System.Drawing.Size(147, 76);
            this.btnCazare.TabIndex = 3;
            this.btnCazare.Text = "&Cazare";
            this.btnCazare.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCazare.UseVisualStyleBackColor = false;
            this.btnCazare.Click += new System.EventHandler(this.btnCazare_Click);
            // 
            // btnTranzactii
            // 
            this.btnTranzactii.BackColor = System.Drawing.Color.White;
            this.btnTranzactii.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTranzactii.ForeColor = System.Drawing.Color.Black;
            this.btnTranzactii.Image = ((System.Drawing.Image)(resources.GetObject("btnTranzactii.Image")));
            this.btnTranzactii.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTranzactii.Location = new System.Drawing.Point(615, 17);
            this.btnTranzactii.Name = "btnTranzactii";
            this.btnTranzactii.Size = new System.Drawing.Size(169, 76);
            this.btnTranzactii.TabIndex = 2;
            this.btnTranzactii.Text = "&Tranzactii";
            this.btnTranzactii.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTranzactii.UseVisualStyleBackColor = false;
            this.btnTranzactii.Click += new System.EventHandler(this.btnTranzactii_Click);
            // 
            // btnBileteAvion
            // 
            this.btnBileteAvion.BackColor = System.Drawing.Color.White;
            this.btnBileteAvion.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBileteAvion.ForeColor = System.Drawing.Color.Black;
            this.btnBileteAvion.Image = ((System.Drawing.Image)(resources.GetObject("btnBileteAvion.Image")));
            this.btnBileteAvion.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBileteAvion.Location = new System.Drawing.Point(391, 17);
            this.btnBileteAvion.Name = "btnBileteAvion";
            this.btnBileteAvion.Size = new System.Drawing.Size(184, 76);
            this.btnBileteAvion.TabIndex = 1;
            this.btnBileteAvion.Text = "&Bilete Avion";
            this.btnBileteAvion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBileteAvion.UseVisualStyleBackColor = false;
            this.btnBileteAvion.Click += new System.EventHandler(this.btnBileteAvion_Click);
            // 
            // btnTuristi
            // 
            this.btnTuristi.BackColor = System.Drawing.Color.White;
            this.btnTuristi.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTuristi.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuristi.ForeColor = System.Drawing.Color.Black;
            this.btnTuristi.Image = ((System.Drawing.Image)(resources.GetObject("btnTuristi.Image")));
            this.btnTuristi.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnTuristi.Location = new System.Drawing.Point(12, 17);
            this.btnTuristi.Name = "btnTuristi";
            this.btnTuristi.Size = new System.Drawing.Size(147, 76);
            this.btnTuristi.TabIndex = 0;
            this.btnTuristi.Text = "&Turisti";
            this.btnTuristi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTuristi.UseVisualStyleBackColor = false;
            this.btnTuristi.Click += new System.EventHandler(this.btnTuristi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 188);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 438);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgentie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(216)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(806, 627);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "frmAgentie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agentie de turism";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCazare;
        private System.Windows.Forms.Button btnTuristi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTranzactii;
        private System.Windows.Forms.Button btnBileteAvion;
    }
}

