
namespace SatrançAraYüz.Dialogs
{
    partial class dlgAddPiece
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTaşTipi = new System.Windows.Forms.ComboBox();
            this.rbBeyaz = new System.Windows.Forms.RadioButton();
            this.rbSiyah = new System.Windows.Forms.RadioButton();
            this.txtLokasyon = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Taş Tipi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taş Rengi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Balangıç Lokasyonu";
            // 
            // cmbTaşTipi
            // 
            this.cmbTaşTipi.FormattingEnabled = true;
            this.cmbTaşTipi.Location = new System.Drawing.Point(156, 12);
            this.cmbTaşTipi.Name = "cmbTaşTipi";
            this.cmbTaşTipi.Size = new System.Drawing.Size(315, 24);
            this.cmbTaşTipi.TabIndex = 3;
            // 
            // rbBeyaz
            // 
            this.rbBeyaz.AutoSize = true;
            this.rbBeyaz.Checked = true;
            this.rbBeyaz.Location = new System.Drawing.Point(156, 51);
            this.rbBeyaz.Name = "rbBeyaz";
            this.rbBeyaz.Size = new System.Drawing.Size(66, 20);
            this.rbBeyaz.TabIndex = 4;
            this.rbBeyaz.TabStop = true;
            this.rbBeyaz.Text = "Beyaz";
            this.rbBeyaz.UseVisualStyleBackColor = true;
            // 
            // rbSiyah
            // 
            this.rbSiyah.AutoSize = true;
            this.rbSiyah.Location = new System.Drawing.Point(334, 51);
            this.rbSiyah.Name = "rbSiyah";
            this.rbSiyah.Size = new System.Drawing.Size(62, 20);
            this.rbSiyah.TabIndex = 5;
            this.rbSiyah.Text = "Siyah";
            this.rbSiyah.UseVisualStyleBackColor = true;
            // 
            // txtLokasyon
            // 
            this.txtLokasyon.Location = new System.Drawing.Point(169, 101);
            this.txtLokasyon.Name = "txtLokasyon";
            this.txtLokasyon.Size = new System.Drawing.Size(188, 22);
            this.txtLokasyon.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(369, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 59);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Taş Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dlgAddPiece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 252);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtLokasyon);
            this.Controls.Add(this.rbSiyah);
            this.Controls.Add(this.rbBeyaz);
            this.Controls.Add(this.cmbTaşTipi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "dlgAddPiece";
            this.Text = "frmTaşEkle";
            this.Load += new System.EventHandler(this.frmTaşEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTaşTipi;
        private System.Windows.Forms.RadioButton rbBeyaz;
        private System.Windows.Forms.RadioButton rbSiyah;
        private System.Windows.Forms.TextBox txtLokasyon;
        private System.Windows.Forms.Button btnAdd;
    }
}