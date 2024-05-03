using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_SATIŞ_Programı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public string emlak;
        public string durum;
        public string sehir;
        private void button3_Click(object sender, EventArgs e)
        {
            if (rdo_konut.Checked == true)
            {
               emlak = "Konut";
            }
            else if (rdo_daire.Checked == true)
            {
                emlak = "Daire";
            }
            else if(rdo_isyeri.Checked == true)
            {
                emlak = "İş Yeri";
            }


            if (rdo_Satılık.Checked == true)
            {
                durum = "Satılık";
            }
            else
            {
               durum = "Kiralık";
            }

            sehir = cmb_sehir.Text;
            button3.Focus();
            form2 frm2 = new form2();

            frm2.label4.Text = emlak;
            frm2.label5.Text = durum;
            frm2.label6.Text = sehir;

            
            frm2.ShowDialog();

        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Button name = new Button();
            name.Show();
            name.Text = "melih";
            

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            BackgroundImage = null;
            label2.ForeColor = Color.White;
            label2.BackColor = Color.DarkGray;
            groupBox1.BackColor = Color.DarkGray;
            groupBox2.BackColor = Color.DarkGray;
            groupBox4.BackColor = Color.DarkGray;
            menuStrip1.BackColor = Color.DarkGray;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
            this.BackColor = Color.LightGray;
            groupBox1.BackColor = Color.LightCoral;
            
        }

        private void iletişimBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ePostaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("          Meliheknciii@gmail.com adresine e-posta atabilirsiniz.        ");
        }

        private void aramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("            0555 555 55 55 Numarasını arayabilirsiniz.           ");
        }
    }
}
