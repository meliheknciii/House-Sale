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
    public partial class sonuclar : Form
    {
        public sonuclar()
        {
            InitializeComponent();
        }

        private void sonuclar_Load(object sender, EventArgs e)
        {
            digerbilgier_sinif dbgsinif = new digerbilgier_sinif();
            Form1 frm1 = new Form1();
            diger_Bilgiler dbg = new diger_Bilgiler();
            form1_sinif frm1_sinif = new form1_sinif();
            frm1.durum = label8.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
