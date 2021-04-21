namespace Skola
{
    partial class RazredniForm
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
            this.btnPrikaziUcenike = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPrikaziOcene = new System.Windows.Forms.Button();
            this.btnPrikaziIzostanke = new System.Windows.Forms.Button();
            this.btnPrikaziNapomene = new System.Windows.Forms.Button();
            this.lblOdeljenje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrikaziUcenike
            // 
            this.btnPrikaziUcenike.Location = new System.Drawing.Point(92, 81);
            this.btnPrikaziUcenike.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrikaziUcenike.Name = "btnPrikaziUcenike";
            this.btnPrikaziUcenike.Size = new System.Drawing.Size(87, 37);
            this.btnPrikaziUcenike.TabIndex = 0;
            this.btnPrikaziUcenike.Text = "Prikazi ucenike";
            this.btnPrikaziUcenike.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odeljenje:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(214, 11);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(294, 152);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID ucenika";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime ucenika";
            this.columnHeader2.Width = 109;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime ucenika";
            this.columnHeader3.Width = 99;
            // 
            // btnPrikaziOcene
            // 
            this.btnPrikaziOcene.Location = new System.Drawing.Point(92, 220);
            this.btnPrikaziOcene.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrikaziOcene.Name = "btnPrikaziOcene";
            this.btnPrikaziOcene.Size = new System.Drawing.Size(108, 63);
            this.btnPrikaziOcene.TabIndex = 3;
            this.btnPrikaziOcene.Text = "Prikazi ocene";
            this.btnPrikaziOcene.UseVisualStyleBackColor = true;
            this.btnPrikaziOcene.Click += new System.EventHandler(this.btnPrikaziOcene_Click);
            // 
            // btnPrikaziIzostanke
            // 
            this.btnPrikaziIzostanke.Location = new System.Drawing.Point(232, 220);
            this.btnPrikaziIzostanke.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrikaziIzostanke.Name = "btnPrikaziIzostanke";
            this.btnPrikaziIzostanke.Size = new System.Drawing.Size(109, 63);
            this.btnPrikaziIzostanke.TabIndex = 4;
            this.btnPrikaziIzostanke.Text = "Prikazi izostanke";
            this.btnPrikaziIzostanke.UseVisualStyleBackColor = true;
            this.btnPrikaziIzostanke.Click += new System.EventHandler(this.btnPrikaziIzostanke_Click);
            // 
            // btnPrikaziNapomene
            // 
            this.btnPrikaziNapomene.Location = new System.Drawing.Point(386, 220);
            this.btnPrikaziNapomene.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrikaziNapomene.Name = "btnPrikaziNapomene";
            this.btnPrikaziNapomene.Size = new System.Drawing.Size(102, 63);
            this.btnPrikaziNapomene.TabIndex = 5;
            this.btnPrikaziNapomene.Text = "Prikazi napomene";
            this.btnPrikaziNapomene.UseVisualStyleBackColor = true;
            this.btnPrikaziNapomene.Click += new System.EventHandler(this.btnPrikaziNapomene_Click);
            // 
            // lblOdeljenje
            // 
            this.lblOdeljenje.AutoSize = true;
            this.lblOdeljenje.Location = new System.Drawing.Point(100, 30);
            this.lblOdeljenje.Name = "lblOdeljenje";
            this.lblOdeljenje.Size = new System.Drawing.Size(35, 13);
            this.lblOdeljenje.TabIndex = 6;
            this.lblOdeljenje.Text = "label2";
            // 
            // RazredniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 366);
            this.Controls.Add(this.lblOdeljenje);
            this.Controls.Add(this.btnPrikaziNapomene);
            this.Controls.Add(this.btnPrikaziIzostanke);
            this.Controls.Add(this.btnPrikaziOcene);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrikaziUcenike);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RazredniForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RazredniForm";
            this.Load += new System.EventHandler(this.RazredniForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrikaziUcenike;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnPrikaziOcene;
        private System.Windows.Forms.Button btnPrikaziIzostanke;
        private System.Windows.Forms.Button btnPrikaziNapomene;
        private System.Windows.Forms.Label lblOdeljenje;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}