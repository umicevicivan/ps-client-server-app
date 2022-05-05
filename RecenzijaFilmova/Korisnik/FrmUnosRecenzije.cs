using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecenzijaFilma
{
    public partial class FrmUnosRecenzije : Form
    {
        KUnosRecenzije kontroler;

        public FrmUnosRecenzije()
        {
            InitializeComponent();
            kontroler = new KUnosRecenzije(this);
        }

        private void FrmUnosRecenzije_Load(object sender, EventArgs e)
        {
            kontroler.srediFormu(cmbUloge, groupBox1, groupBox2, btnPotvrdiFilm, cmbFilmovi, lblKorisnik, dataGridView1);


        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            kontroler.srediFormu2(groupBox2, cmbUloge, cmbFilmovi, groupBox1, btnPotvrdiFilm);
        }

        private void btnUloga_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPotvrdiUlogu_Click(object sender, EventArgs e)
        {
            kontroler.UbaciRecenzijuUloge(cmbUloge, txtRecenzijaUloge, cmbFilmovi);
        }

        private void btnPotvrdiFilm_Click(object sender, EventArgs e)
        {

            bool uspelo = kontroler.dodajRecenziju(txtRecenzijaFilma, cmbFilmovi);
            if (uspelo)
            {
                this.Close();

            }
        }

        private void btnObrisiRecenzijuUloge_Click(object sender, EventArgs e)
        {
            kontroler.obrisiRecenzijuUloge(dataGridView1);

        }
    }
}
