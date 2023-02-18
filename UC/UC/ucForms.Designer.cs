
namespace UC
{
    partial class ucForms
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbFormulare = new System.Windows.Forms.ComboBox();
            this.btnAcces = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selectare formular";
            // 
            // cbFormulare
            // 
            this.cbFormulare.FormattingEnabled = true;
            this.cbFormulare.Location = new System.Drawing.Point(156, 19);
            this.cbFormulare.Name = "cbFormulare";
            this.cbFormulare.Size = new System.Drawing.Size(164, 21);
            this.cbFormulare.TabIndex = 1;
            // 
            // btnAcces
            // 
            this.btnAcces.Location = new System.Drawing.Point(58, 63);
            this.btnAcces.Name = "btnAcces";
            this.btnAcces.Size = new System.Drawing.Size(172, 23);
            this.btnAcces.TabIndex = 2;
            this.btnAcces.Text = "Accesare formular";
            this.btnAcces.UseVisualStyleBackColor = true;
            // 
            // ucForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAcces);
            this.Controls.Add(this.cbFormulare);
            this.Controls.Add(this.label1);
            this.Name = "ucForms";
            this.Size = new System.Drawing.Size(373, 105);
            this.Load += new System.EventHandler(this.ucForms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFormulare;
        private System.Windows.Forms.Button btnAcces;
    }
}
