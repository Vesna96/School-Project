namespace Skola
{
    partial class IzostanciForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpisiteIzostanke = new System.Windows.Forms.Button();
            this.txtImeUcenika1 = new System.Windows.Forms.TextBox();
            this.txtPrezimeUcenika1 = new System.Windows.Forms.TextBox();
            this.txtRbrUcenika = new System.Windows.Forms.TextBox();
            this.dtmDatumIzostanaka = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite ime ucenika:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Unesite prezime ucenika:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Unesite id ucenika:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(469, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Unesite datum unosenja izostanaka:";
            // 
            // btnUpisiteIzostanke
            // 
            this.btnUpisiteIzostanke.Location = new System.Drawing.Point(333, 306);
            this.btnUpisiteIzostanke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpisiteIzostanke.Name = "btnUpisiteIzostanke";
            this.btnUpisiteIzostanke.Size = new System.Drawing.Size(141, 58);
            this.btnUpisiteIzostanke.TabIndex = 6;
            this.btnUpisiteIzostanke.Text = "Upisite izostanke";
            this.btnUpisiteIzostanke.UseVisualStyleBackColor = true;
            this.btnUpisiteIzostanke.Click += new System.EventHandler(this.btnUpisiteIzostanke_Click);
            // 
            // txtImeUcenika1
            // 
            this.txtImeUcenika1.Location = new System.Drawing.Point(239, 114);
            this.txtImeUcenika1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImeUcenika1.Name = "txtImeUcenika1";
            this.txtImeUcenika1.Size = new System.Drawing.Size(120, 22);
            this.txtImeUcenika1.TabIndex = 8;
            // 
            // txtPrezimeUcenika1
            // 
            this.txtPrezimeUcenika1.Location = new System.Drawing.Point(239, 170);
            this.txtPrezimeUcenika1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezimeUcenika1.Name = "txtPrezimeUcenika1";
            this.txtPrezimeUcenika1.Size = new System.Drawing.Size(120, 22);
            this.txtPrezimeUcenika1.TabIndex = 9;
            // 
            // txtRbrUcenika
            // 
            this.txtRbrUcenika.Location = new System.Drawing.Point(239, 222);
            this.txtRbrUcenika.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRbrUcenika.Name = "txtRbrUcenika";
            this.txtRbrUcenika.Size = new System.Drawing.Size(120, 22);
            this.txtRbrUcenika.TabIndex = 11;
            // 
            // dtmDatumIzostanaka
            // 
            this.dtmDatumIzostanaka.Location = new System.Drawing.Point(473, 128);
            this.dtmDatumIzostanaka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmDatumIzostanaka.Name = "dtmDatumIzostanaka";
            this.dtmDatumIzostanaka.Size = new System.Drawing.Size(200, 22);
            this.dtmDatumIzostanaka.TabIndex = 13;
            // 
            // IzostanciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 414);
            this.Controls.Add(this.dtmDatumIzostanaka);
            this.Controls.Add(this.txtRbrUcenika);
            this.Controls.Add(this.txtPrezimeUcenika1);
            this.Controls.Add(this.txtImeUcenika1);
            this.Controls.Add(this.btnUpisiteIzostanke);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "IzostanciForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IzostanciForm";
            this.Load += new System.EventHandler(this.IzostanciForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUpisiteIzostanke;
        private System.Windows.Forms.TextBox txtImeUcenika1;
        private System.Windows.Forms.TextBox txtPrezimeUcenika1;
        private System.Windows.Forms.TextBox txtRbrUcenika;
        private System.Windows.Forms.DateTimePicker dtmDatumIzostanaka;
    }
}