using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tatil_Köyü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            try
            {
                int günSayısı = Convert.ToInt32(txtKonaklama.Text);
                int Yas = Convert.ToInt32(txtYas.Text);

                if (Yas > 0 && Yas < 12)
                {
                    lblDurum.Text = "Ücretsiz";
                    lblTutar.Text = "0";
                }
                if (Yas > 13 && Yas < 25)
                {
                    lblDurum.Text = "Genç";
                    int Toplam = günSayısı * 50;
                    lblTutar.Text = Toplam.ToString();

                }
                if (Yas >= 25 && Yas < 65)
                {
                    lblDurum.Text = "İndirim Yok";
                    int Toplam = günSayısı * 100;
                    lblTutar.Text = Toplam.ToString();
                }
                if (Yas >= 65)
                {
                    lblDurum.Text = "Yaslı İndirimi";
                    int Toplam = günSayısı * 30;
                    lblTutar.Text = Toplam.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Çıkış Yyapmak istediginizden  eminmisiniz  ?","Çıkış",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cevap==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtYas.Text = "";
            txtKonaklama.Text = "";
            comboBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }

        private void lblTutar_Click(object sender, EventArgs e)
        {

        }
    }
}
