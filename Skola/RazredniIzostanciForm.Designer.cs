namespace Skola
{
    partial class RazredniIzostanciForm
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
            this.btnZapamtiPromene = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNeopravdani = new System.Windows.Forms.RadioButton();
            this.rbOpravdani = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZapamtiPromene
            // 
            this.btnZapamtiPromene.Location = new System.Drawing.Point(466, 309);
            this.btnZapamtiPromene.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZapamtiPromene.Name = "btnZapamtiPromene";
            this.btnZapamtiPromene.Size = new System.Drawing.Size(131, 53);
            this.btnZapamtiPromene.TabIndex = 0;
            this.btnZapamtiPromene.Text = "Zapamti promene";
            this.btnZapamtiPromene.UseVisualStyleBackColor = true;
            this.btnZapamtiPromene.Click += new System.EventHandler(this.btnZapamtiPromene_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Location = new System.Drawing.Point(40, 46);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(671, 222);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID ucenika";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ime ";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prezime";
            this.columnHeader3.Width = 76;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum";
            this.columnHeader4.Width = 77;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID casa";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tip";
            this.columnHeader6.Width = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista izostanaka ucenika vaseg odeljenja";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbOpravdani);
            this.groupBox1.Controls.Add(this.rbNeopravdani);
            this.groupBox1.Location = new System.Drawing.Point(132, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // rbNeopravdani
            // 
            this.rbNeopravdani.AutoSize = true;
            this.rbNeopravdani.Location = new System.Drawing.Point(24, 32);
            this.rbNeopravdani.Name = "rbNeopravdani";
            this.rbNeopravdani.Size = new System.Drawing.Size(110, 21);
            this.rbNeopravdani.TabIndex = 0;
            this.rbNeopravdani.TabStop = true;
            this.rbNeopravdani.Text = "Neopravdani";
            this.rbNeopravdani.UseVisualStyleBackColor = true;
            // 
            // rbOpravdani
            // 
            this.rbOpravdani.AutoSize = true;
            this.rbOpravdani.Location = new System.Drawing.Point(24, 73);
            this.rbOpravdani.Name = "rbOpravdani";
            this.rbOpravdani.Size = new System.Drawing.Size(95, 21);
            this.rbOpravdani.TabIndex = 1;
            this.rbOpravdani.TabStop = true;
            this.rbOpravdani.Text = "Opravdani";
            this.rbOpravdani.UseVisualStyleBackColor = true;
            // 
            // RazredniIzostanciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnZapamtiPromene);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RazredniIzostanciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RazredniIzostanciForm";
            this.Load += new System.EventHandler(this.RazredniIzostanciForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZapamtiPromene;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbOpravdani;
        private System.Windows.Forms.RadioButton rbNeopravdani;
    }
}