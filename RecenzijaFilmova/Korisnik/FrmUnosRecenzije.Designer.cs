namespace RecenzijaFilma
{
    partial class FrmUnosRecenzije
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
            this.cmbFilmovi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUloge = new System.Windows.Forms.ComboBox();
            this.txtRecenzijaUloge = new System.Windows.Forms.TextBox();
            this.btnPotvrdiUlogu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRecenzijaFilma = new System.Windows.Forms.TextBox();
            this.btnPotvrdiFilm = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.btnFilm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnObrisiRecenzijuUloge = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFilmovi
            // 
            this.cmbFilmovi.FormattingEnabled = true;
            this.cmbFilmovi.Location = new System.Drawing.Point(164, 62);
            this.cmbFilmovi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbFilmovi.Name = "cmbFilmovi";
            this.cmbFilmovi.Size = new System.Drawing.Size(299, 24);
            this.cmbFilmovi.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Izaberite film:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Izaberite ulogu:";
            // 
            // cmbUloge
            // 
            this.cmbUloge.FormattingEnabled = true;
            this.cmbUloge.Location = new System.Drawing.Point(164, 352);
            this.cmbUloge.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUloge.Name = "cmbUloge";
            this.cmbUloge.Size = new System.Drawing.Size(299, 24);
            this.cmbUloge.TabIndex = 29;
            // 
            // txtRecenzijaUloge
            // 
            this.txtRecenzijaUloge.Location = new System.Drawing.Point(10, 33);
            this.txtRecenzijaUloge.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecenzijaUloge.Multiline = true;
            this.txtRecenzijaUloge.Name = "txtRecenzijaUloge";
            this.txtRecenzijaUloge.Size = new System.Drawing.Size(443, 84);
            this.txtRecenzijaUloge.TabIndex = 31;
            // 
            // btnPotvrdiUlogu
            // 
            this.btnPotvrdiUlogu.Location = new System.Drawing.Point(10, 141);
            this.btnPotvrdiUlogu.Margin = new System.Windows.Forms.Padding(4);
            this.btnPotvrdiUlogu.Name = "btnPotvrdiUlogu";
            this.btnPotvrdiUlogu.Size = new System.Drawing.Size(195, 39);
            this.btnPotvrdiUlogu.TabIndex = 32;
            this.btnPotvrdiUlogu.Text = "Dodaj Recenziju Uloge";
            this.btnPotvrdiUlogu.UseVisualStyleBackColor = true;
            this.btnPotvrdiUlogu.Click += new System.EventHandler(this.btnPotvrdiUlogu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisiRecenzijuUloge);
            this.groupBox1.Controls.Add(this.txtRecenzijaUloge);
            this.groupBox1.Controls.Add(this.btnPotvrdiUlogu);
            this.groupBox1.Location = new System.Drawing.Point(43, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 203);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recenzija uloge";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtRecenzijaFilma);
            this.groupBox2.Location = new System.Drawing.Point(43, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 146);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recenzija filma";
            // 
            // txtRecenzijaFilma
            // 
            this.txtRecenzijaFilma.Location = new System.Drawing.Point(10, 45);
            this.txtRecenzijaFilma.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecenzijaFilma.Multiline = true;
            this.txtRecenzijaFilma.Name = "txtRecenzijaFilma";
            this.txtRecenzijaFilma.Size = new System.Drawing.Size(443, 70);
            this.txtRecenzijaFilma.TabIndex = 32;
            // 
            // btnPotvrdiFilm
            // 
            this.btnPotvrdiFilm.Location = new System.Drawing.Point(43, 783);
            this.btnPotvrdiFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btnPotvrdiFilm.Name = "btnPotvrdiFilm";
            this.btnPotvrdiFilm.Size = new System.Drawing.Size(477, 53);
            this.btnPotvrdiFilm.TabIndex = 35;
            this.btnPotvrdiFilm.Text = "Potvrdi Recenziju Filma";
            this.btnPotvrdiFilm.UseVisualStyleBackColor = true;
            this.btnPotvrdiFilm.Click += new System.EventHandler(this.btnPotvrdiFilm_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 21);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 17);
            this.label12.TabIndex = 36;
            this.label12.Text = "Ulogovani korisnik: ";
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Location = new System.Drawing.Point(179, 21);
            this.lblKorisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(131, 17);
            this.lblKorisnik.TabIndex = 37;
            this.lblKorisnik.Text = "Ulogovani korisnik: ";
            // 
            // btnFilm
            // 
            this.btnFilm.Location = new System.Drawing.Point(43, 111);
            this.btnFilm.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(477, 53);
            this.btnFilm.TabIndex = 38;
            this.btnFilm.Text = "Potvrdi film";
            this.btnFilm.UseVisualStyleBackColor = true;
            this.btnFilm.Click += new System.EventHandler(this.btnFilm_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 593);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(477, 150);
            this.dataGridView1.TabIndex = 39;
            // 
            // btnObrisiRecenzijuUloge
            // 
            this.btnObrisiRecenzijuUloge.Location = new System.Drawing.Point(269, 141);
            this.btnObrisiRecenzijuUloge.Margin = new System.Windows.Forms.Padding(4);
            this.btnObrisiRecenzijuUloge.Name = "btnObrisiRecenzijuUloge";
            this.btnObrisiRecenzijuUloge.Size = new System.Drawing.Size(184, 39);
            this.btnObrisiRecenzijuUloge.TabIndex = 33;
            this.btnObrisiRecenzijuUloge.Text = "Obrisi Recenziju Uloge";
            this.btnObrisiRecenzijuUloge.UseVisualStyleBackColor = true;
            this.btnObrisiRecenzijuUloge.Click += new System.EventHandler(this.btnObrisiRecenzijuUloge_Click);
            // 
            // FrmUnosRecenzije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 852);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnPotvrdiFilm);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbUloge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFilmovi);
            this.Controls.Add(this.label7);
            this.Name = "FrmUnosRecenzije";
            this.Text = "Recenzija filma";
            this.Load += new System.EventHandler(this.FrmUnosRecenzije_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbFilmovi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUloge;
        private System.Windows.Forms.TextBox txtRecenzijaUloge;
        private System.Windows.Forms.Button btnPotvrdiUlogu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRecenzijaFilma;
        private System.Windows.Forms.Button btnPotvrdiFilm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblKorisnik;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnObrisiRecenzijuUloge;
    }
}