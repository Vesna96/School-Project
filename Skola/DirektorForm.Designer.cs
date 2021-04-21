namespace Skola
{
    partial class DirektorForm
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
            this.btnDodajProfesora = new System.Windows.Forms.Button();
            this.btnDodajSmer = new System.Windows.Forms.Button();
            this.btnDodajNoviPredmet = new System.Windows.Forms.Button();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblImeD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDodajProfesora
            // 
            this.btnDodajProfesora.Location = new System.Drawing.Point(36, 132);
            this.btnDodajProfesora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajProfesora.Name = "btnDodajProfesora";
            this.btnDodajProfesora.Size = new System.Drawing.Size(200, 48);
            this.btnDodajProfesora.TabIndex = 0;
            this.btnDodajProfesora.Text = "Profesori";
            this.btnDodajProfesora.UseVisualStyleBackColor = true;
            this.btnDodajProfesora.Click += new System.EventHandler(this.btnDodajProfesora_Click);
            // 
            // btnDodajSmer
            // 
            this.btnDodajSmer.Location = new System.Drawing.Point(266, 132);
            this.btnDodajSmer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajSmer.Name = "btnDodajSmer";
            this.btnDodajSmer.Size = new System.Drawing.Size(200, 48);
            this.btnDodajSmer.TabIndex = 3;
            this.btnDodajSmer.Text = "Smerovi";
            this.btnDodajSmer.UseVisualStyleBackColor = true;
            this.btnDodajSmer.Click += new System.EventHandler(this.btnDodajSmer_Click);
            // 
            // btnDodajNoviPredmet
            // 
            this.btnDodajNoviPredmet.Location = new System.Drawing.Point(510, 132);
            this.btnDodajNoviPredmet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodajNoviPredmet.Name = "btnDodajNoviPredmet";
            this.btnDodajNoviPredmet.Size = new System.Drawing.Size(200, 48);
            this.btnDodajNoviPredmet.TabIndex = 4;
            this.btnDodajNoviPredmet.Text = "Predmeti";
            this.btnDodajNoviPredmet.UseVisualStyleBackColor = true;
            this.btnDodajNoviPredmet.Click += new System.EventHandler(this.btnDodajNoviPredmet_Click);
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(371, 25);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(0, 17);
            this.lblIme.TabIndex = 5;
            this.lblIme.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(147, 48);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(46, 17);
            this.lblPrezime.TabIndex = 6;
            this.lblPrezime.Text = "label2";
            // 
            // lblImeD
            // 
            this.lblImeD.AutoSize = true;
            this.lblImeD.Location = new System.Drawing.Point(69, 48);
            this.lblImeD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImeD.Name = "lblImeD";
            this.lblImeD.Size = new System.Drawing.Size(46, 17);
            this.lblImeD.TabIndex = 7;
            this.lblImeD.Text = "label1";
            // 
            // DirektorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblImeD);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.btnDodajNoviPredmet);
            this.Controls.Add(this.btnDodajSmer);
            this.Controls.Add(this.btnDodajProfesora);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DirektorForm";
            this.Text = "Direktor";
            this.Load += new System.EventHandler(this.DirektorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajProfesora;
        private System.Windows.Forms.Button btnDodajSmer;
        private System.Windows.Forms.Button btnDodajNoviPredmet;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblImeD;
    }
}