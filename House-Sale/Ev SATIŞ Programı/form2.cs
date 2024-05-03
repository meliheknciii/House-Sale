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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }
        public string emlak, durum, sehir;

        private void button1_Click(object sender, EventArgs e)
        {
            Point lbl8konum = new Point(400,190);
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label8.Visible = true;
            label8.Location = lbl8konum;
            
            Random rnd = new Random();
            int sayı;
            sayı = rnd.Next(1, 50);
            label8.Text = sayı + " adet sonuç bulundu.";

            
            

        }

        private void form2_Load(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            
            
            
        }
    }
}
