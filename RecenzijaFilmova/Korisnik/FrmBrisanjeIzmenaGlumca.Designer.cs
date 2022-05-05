namespace RecenzijaFilma
{
    partial class FrmBrisanjeIzmenaGlumca
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
            this.cmbGlumci = new System.Windows.Forms.ComboBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPotvrdiIzmenu = new System.Windows.Forms.Button();
            this.cmbPol = new System.Windows.Forms.ComboBox();
            this.txtDrzava = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izaberite glumca:";
            // 
            // cmbGlumci
            // 
            this.cmbGlumci.FormattingEnabled = true;
            this.cmbGlumci.Location = new System.Drawing.Point(105, 13);
            this.cmbGlumci.Name = "cmbGlumci";
            this.cmbGlumci.Size = new System.Drawing.Size(204, 21);
            this.cmbGlumci.TabIndex = 1;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(15, 72);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(144, 23);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi glumca";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(165, 72);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(144, 23);
            this.btnIzmeni.TabIndex = 3;
            this.btnIzmeni.Text = "Izmeni glumca";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sta zelite da uradite?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPotvrdiIzmenu);
            this.groupBox1.Controls.Add(this.cmbPol);
            this.groupBox1.Controls.Add(this.txtDrzava);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(18, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 250);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Izmena glumca";
            // 
            // btnPotvrdiIzmenu
            // 
            this.btnPotvrdiIzmenu.Location = new System.Drawing.Point(22, 195);
            this.btnPotvrdiIzmenu.Name = "btnPotvrdiIzmenu";
            this.btnPotvrdiIzmenu.Size = new System.Drawing.Size(248, 23);
            this.btnPotvrdiIzmenu.TabIndex = 21;
            this.btnPotvrdiIzmenu.Text = "Potvrdi izmenu glumca";
            this.btnPotvrdiIzmenu.UseVisualStyleBackColor = true;
            this.btnPotvrdiIzmenu.Click += new System.EventHandler(this.btnPotvrdiIzmenu_Click);
            // 
            // cmbPol
            // 
            this.cmbPol.FormattingEnabled = true;
            this.cmbPol.Items.AddRange(new object[] {
            "Muski",
            "Zenski"});
            this.cmbPol.Location = new System.Drawing.Point(118, 142);
            this.cmbPol.Name = "cmbPol";
            this.cmbPol.Size = new System.Drawing.Size(152, 21);
            this.cmbPol.TabIndex = 20;
            // 
            // txtDrzava
            // 
            this.txtDrzava.Location = new System.Drawing.Point(118, 107);
            this.txtDrzava.Name = "txtDrzava";
            this.txtDrzava.Size = new System.Drawing.Size(152, 20);
            this.txtDrzava.TabIndex = 19;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(118, 70);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(152, 20);
            this.txtPrezime.TabIndex = 18;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(118, 30);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(152, 20);
            this.txtIme.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pol:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Drzava rodjenja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ime:";
            // 
            // FrmBrisanjeIzmenaGlumca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.cmbGlumci);
            this.Controls.Add(this.label1);
            this.Name = "FrmBrisanjeIzmenaGlumca";
            this.Text = "Izmena / brisanje glumca";
            this.Load += new System.EventHandler(this.FrmBrisanjeIzmenaGlumca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGlumci;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPotvrdiIzmenu;
        private System.Windows.Forms.ComboBox cmbPol;
        private System.Windows.Forms.TextBox txtDrzava;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}