namespace Skola
{
    partial class RedovniProfesorForm
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
            this.cmbxRedProfPredmeti = new System.Windows.Forms.ComboBox();
            this.cmbxOdSlusaPredmet = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbxRedProfPredmeti
            // 
            this.cmbxRedProfPredmeti.FormattingEnabled = true;
            this.cmbxRedProfPredmeti.Location = new System.Drawing.Point(15, 65);
            this.cmbxRedProfPredmeti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxRedProfPredmeti.Name = "cmbxRedProfPredmeti";
            this.cmbxRedProfPredmeti.Size = new System.Drawing.Size(249, 24);
            this.cmbxRedProfPredmeti.TabIndex = 1;
            this.cmbxRedProfPredmeti.Text = "Odaberite predmet koji predajete";
            this.cmbxRedProfPredmeti.SelectedIndexChanged += new System.EventHandler(this.cmbxRedProfPredmeti_SelectedIndexChanged);
            // 
            // cmbxOdSlusaPredmet
            // 
            this.cmbxOdSlusaPredmet.FormattingEnabled = true;
            this.cmbxOdSlusaPredmet.Location = new System.Drawing.Point(15, 117);
            this.cmbxOdSlusaPredmet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxOdSlusaPredmet.Name = "cmbxOdSlusaPredmet";
            this.cmbxOdSlusaPredmet.Size = new System.Drawing.Size(249, 24);
            this.cmbxOdSlusaPredmet.TabIndex = 2;
            this.cmbxOdSlusaPredmet.Text = "Odaberite odeljenje kojem predajete";
            this.cmbxOdSlusaPredmet.SelectedIndexChanged += new System.EventHandler(this.cmbxOdSlusaPredmet_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader8,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Location = new System.Drawing.Point(271, 47);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(928, 258);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ucenik ID";
            this.columnHeader4.Width = 71;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ime ucenika";
            this.columnHeader6.Width = 95;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Prezime ucenika";
            this.columnHeader8.Width = 107;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Test1";
            this.columnHeader1.Width = 48;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Test2";
            this.columnHeader2.Width = 47;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Test3";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Test4";
            this.columnHeader5.Width = 48;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Prosek";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Zakljucna ocena";
            this.columnHeader10.Width = 95;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 345);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 59);
            this.button1.TabIndex = 5;
            this.button1.Text = "Odaberi ucenika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 345);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 59);
            this.button2.TabIndex = 6;
            this.button2.Text = "Dodaj cas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RedovniProfesorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 514);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cmbxOdSlusaPredmet);
            this.Controls.Add(this.cmbxRedProfPredmeti);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RedovniProfesorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RedovniProfesorForm";
            this.Load += new System.EventHandler(this.RedovniProfesorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbxRedProfPredmeti;
        private System.Windows.Forms.ComboBox cmbxOdSlusaPredmet;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}