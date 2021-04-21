namespace Skola
{
    partial class ProfesorForm
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
            this.txtIme = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPredajePredmete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIme
            // 
            this.txtIme.AutoSize = true;
            this.txtIme.Location = new System.Drawing.Point(24, 33);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(35, 13);
            this.txtIme.TabIndex = 0;
            this.txtIme.Text = "txtIme";
            // 
            // txtPrezime
            // 
            this.txtPrezime.AutoSize = true;
            this.txtPrezime.Location = new System.Drawing.Point(69, 33);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(55, 13);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.Text = "txtPrezime";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(26, 113);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(299, 272);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Odeljenju";
            this.columnHeader1.Width = 92;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Predaje predmet";
            this.columnHeader2.Width = 142;
            // 
            // txtPredajePredmete
            // 
            this.txtPredajePredmete.AutoSize = true;
            this.txtPredajePredmete.Location = new System.Drawing.Point(24, 58);
            this.txtPredajePredmete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtPredajePredmete.Name = "txtPredajePredmete";
            this.txtPredajePredmete.Size = new System.Drawing.Size(87, 13);
            this.txtPredajePredmete.TabIndex = 3;
            this.txtPredajePredmete.Text = "predajePredmete";
            // 
            // ProfesorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 433);
            this.Controls.Add(this.txtPredajePredmete);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ProfesorForm";
            this.Text = "Profesor";
            this.Load += new System.EventHandler(this.ProfesorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtIme;
        private System.Windows.Forms.Label txtPrezime;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label txtPredajePredmete;
    }
}