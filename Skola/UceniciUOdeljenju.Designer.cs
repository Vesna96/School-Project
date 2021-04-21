namespace Skola
{
    partial class UceniciUOdeljenju
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPremestaj = new System.Windows.Forms.Button();
            this.cbxOdeljenja = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.cbxPredmeti = new System.Windows.Forms.ComboBox();
            this.btnObrisiPredmet = new System.Windows.Forms.Button();
            this.cbxProfesori = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(56, 66);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(376, 306);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id ucenika";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime ucenika";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime ucenika";
            this.columnHeader3.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(493, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesi id ucenika";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime ucenika";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prezime ucenika";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(548, 210);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(203, 62);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj novog ucenika";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(624, 62);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 5;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(624, 118);
            this.txtIme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 22);
            this.txtIme.TabIndex = 6;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(624, 167);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 22);
            this.txtPrezime.TabIndex = 7;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(548, 297);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(203, 58);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obrisi selektovnaog ucenika";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPremestaj
            // 
            this.btnPremestaj.Location = new System.Drawing.Point(548, 379);
            this.btnPremestaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPremestaj.Name = "btnPremestaj";
            this.btnPremestaj.Size = new System.Drawing.Size(203, 47);
            this.btnPremestaj.TabIndex = 9;
            this.btnPremestaj.Text = "Premesti ucenika u drugo odeljenje";
            this.btnPremestaj.UseVisualStyleBackColor = true;
            this.btnPremestaj.Click += new System.EventHandler(this.btnPremestaj_Click);
            // 
            // cbxOdeljenja
            // 
            this.cbxOdeljenja.FormattingEnabled = true;
            this.cbxOdeljenja.Location = new System.Drawing.Point(813, 229);
            this.cbxOdeljenja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxOdeljenja.Name = "cbxOdeljenja";
            this.cbxOdeljenja.Size = new System.Drawing.Size(128, 24);
            this.cbxOdeljenja.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(811, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Izaberi novo odeljenje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView2.Location = new System.Drawing.Point(37, 434);
            this.listView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(580, 267);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sifra predmeta";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Naziv predmeta";
            this.columnHeader5.Width = 220;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ime profesora";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Prezime profesora";
            this.columnHeader7.Width = 101;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(843, 474);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 76);
            this.button1.TabIndex = 15;
            this.button1.Text = "Dodaj predmet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxPredmeti
            // 
            this.cbxPredmeti.FormattingEnabled = true;
            this.cbxPredmeti.Location = new System.Drawing.Point(624, 474);
            this.cbxPredmeti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxPredmeti.Name = "cbxPredmeti";
            this.cbxPredmeti.Size = new System.Drawing.Size(168, 24);
            this.cbxPredmeti.TabIndex = 16;
            this.cbxPredmeti.Text = "Izaberi predmet";
            this.cbxPredmeti.SelectedIndexChanged += new System.EventHandler(this.cbxPredmeti_SelectedIndexChanged);
            // 
            // btnObrisiPredmet
            // 
            this.btnObrisiPredmet.Location = new System.Drawing.Point(849, 615);
            this.btnObrisiPredmet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnObrisiPredmet.Name = "btnObrisiPredmet";
            this.btnObrisiPredmet.Size = new System.Drawing.Size(93, 87);
            this.btnObrisiPredmet.TabIndex = 17;
            this.btnObrisiPredmet.Text = "Obrisi selektovani predmet";
            this.btnObrisiPredmet.UseVisualStyleBackColor = true;
            this.btnObrisiPredmet.Click += new System.EventHandler(this.btnObrisiPredmet_Click);
            // 
            // cbxProfesori
            // 
            this.cbxProfesori.FormattingEnabled = true;
            this.cbxProfesori.Location = new System.Drawing.Point(632, 599);
            this.cbxProfesori.Margin = new System.Windows.Forms.Padding(4);
            this.cbxProfesori.Name = "cbxProfesori";
            this.cbxProfesori.Size = new System.Drawing.Size(160, 24);
            this.cbxProfesori.TabIndex = 18;
            this.cbxProfesori.Text = "Izaberi profesora";
            // 
            // UceniciUOdeljenju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 750);
            this.Controls.Add(this.cbxProfesori);
            this.Controls.Add(this.btnObrisiPredmet);
            this.Controls.Add(this.cbxPredmeti);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxOdeljenja);
            this.Controls.Add(this.btnPremestaj);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UceniciUOdeljenju";
            this.Text = "UceniciUOdeljenju";
            this.Load += new System.EventHandler(this.UceniciUOdeljenju_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPremestaj;
        private System.Windows.Forms.ComboBox cbxOdeljenja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxPredmeti;
        private System.Windows.Forms.Button btnObrisiPredmet;
        private System.Windows.Forms.ComboBox cbxProfesori;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}