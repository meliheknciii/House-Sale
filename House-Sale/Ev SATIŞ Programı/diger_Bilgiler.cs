using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Ev_SATIŞ_Programı
{
    public partial class diger_Bilgiler : Form
    {
        public diger_Bilgiler()
        {
            InitializeComponent();
        }
        public string oda_Sayisi;
        public string bina_yasi;
        public bool deprem;
        
        private void button1_Click(object sender, EventArgs e)
        {
            
           
            
            Form1 frm1 = new Form1();

            label5.Text = frm1.emlak;
            
            if(rd_1oda.Checked == true)
            {
                oda_Sayisi = "1 oda";

            }
            else if(rd_2oda.Checked == true)
            {
                oda_Sayisi = "2 oda";
            }
            else if(rd_3oda.Checked == true)
            {
                oda_Sayisi = "3 oda";
            }
            else if(rd_4oda.Checked == true)
            {
                oda_Sayisi = "4 oda";
            }
            if (rd_bina0_2.Checked == true)
            {
                bina_yasi = "0-2 yaşındadır";
            }
            else if (rd_bina3_6.Checked == true)
            {
                bina_yasi = "3-6 yaşındadır";
            }
            else if (rd_bina7_10.Checked == true)
            {
                bina_yasi = "7-10 yaşındadır";
            }
            else if (rd_bina10üssü.Checked == true)
            {
                bina_yasi = "10 yaşından fazladır";
            }
            if (rd_deprem_true.Checked == true)
            {
                deprem = true;
            }
            else
            {
                deprem = false;
            }
            label5.Text = frm1.emlak;
            
            
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.durum = label5.Text;
           
        }
    }
}
