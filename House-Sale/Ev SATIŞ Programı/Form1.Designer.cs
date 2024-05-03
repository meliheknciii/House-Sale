namespace Ev_SATIŞ_Programı
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_sehir = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaSayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arkaPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.varsayılanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.rdo_daire = new System.Windows.Forms.RadioButton();
            this.rdo_isyeri = new System.Windows.Forms.RadioButton();
            this.rdo_konut = new System.Windows.Forms.RadioButton();
            this.rdo_Satılık = new System.Windows.Forms.RadioButton();
            this.rdo_kiralık = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.ePostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(931, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(406, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emlakcım";
            // 
            // cmb_sehir
            // 
            this.cmb_sehir.FormattingEnabled = true;
            this.cmb_sehir.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.cmb_sehir.Location = new System.Drawing.Point(6, 109);
            this.cmb_sehir.Name = "cmb_sehir";
            this.cmb_sehir.Size = new System.Drawing.Size(146, 31);
            this.cmb_sehir.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şehir Seçiniz ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaSayfaToolStripMenuItem,
            this.arkaPlanToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaSayfaToolStripMenuItem
            // 
            this.anaSayfaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimBilgileriToolStripMenuItem});
            this.anaSayfaToolStripMenuItem.Name = "anaSayfaToolStripMenuItem";
            this.anaSayfaToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.anaSayfaToolStripMenuItem.Text = "Ana Sayfa";
            // 
            // iletişimBilgileriToolStripMenuItem
            // 
            this.iletişimBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ePostaToolStripMenuItem,
            this.aramaToolStripMenuItem});
            this.iletişimBilgileriToolStripMenuItem.Name = "iletişimBilgileriToolStripMenuItem";
            this.iletişimBilgileriToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.iletişimBilgileriToolStripMenuItem.Text = "İletişim Bilgileri";
            this.iletişimBilgileriToolStripMenuItem.Click += new System.EventHandler(this.iletişimBilgileriToolStripMenuItem_Click);
            // 
            // arkaPlanToolStripMenuItem
            // 
            this.arkaPlanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.varsayılanToolStripMenuItem});
            this.arkaPlanToolStripMenuItem.Name = "arkaPlanToolStripMenuItem";
            this.arkaPlanToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.arkaPlanToolStripMenuItem.Text = "Arka Plan";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // varsayılanToolStripMenuItem
            // 
            this.varsayılanToolStripMenuItem.Name = "varsayılanToolStripMenuItem";
            this.varsayılanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.varsayılanToolStripMenuItem.Text = "Varsayılan";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(15, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Emlak";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdo_daire
            // 
            this.rdo_daire.AutoSize = true;
            this.rdo_daire.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdo_daire.Location = new System.Drawing.Point(29, 112);
            this.rdo_daire.Name = "rdo_daire";
            this.rdo_daire.Size = new System.Drawing.Size(82, 27);
            this.rdo_daire.TabIndex = 10;
            this.rdo_daire.Text = "Daire";
            this.rdo_daire.UseVisualStyleBackColor = true;
            // 
            // rdo_isyeri
            // 
            this.rdo_isyeri.AutoSize = true;
            this.rdo_isyeri.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdo_isyeri.Location = new System.Drawing.Point(29, 145);
            this.rdo_isyeri.Name = "rdo_isyeri";
            this.rdo_isyeri.Size = new System.Drawing.Size(87, 27);
            this.rdo_isyeri.TabIndex = 11;
            this.rdo_isyeri.Text = "İş Yeri";
            this.rdo_isyeri.UseVisualStyleBackColor = true;
            // 
            // rdo_konut
            // 
            this.rdo_konut.AutoSize = true;
            this.rdo_konut.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdo_konut.ForeColor = System.Drawing.Color.Black;
            this.rdo_konut.Location = new System.Drawing.Point(29, 79);
            this.rdo_konut.Name = "rdo_konut";
            this.rdo_konut.Size = new System.Drawing.Size(87, 27);
            this.rdo_konut.TabIndex = 12;
            this.rdo_konut.Text = "Konut";
            this.rdo_konut.UseVisualStyleBackColor = true;
            // 
            // rdo_Satılık
            // 
            this.rdo_Satılık.AutoSize = true;
            this.rdo_Satılık.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdo_Satılık.Location = new System.Drawing.Point(23, 101);
            this.rdo_Satılık.Name = "rdo_Satılık";
            this.rdo_Satılık.Size = new System.Drawing.Size(89, 27);
            this.rdo_Satılık.TabIndex = 13;
            this.rdo_Satılık.Text = "Satılık";
            this.rdo_Satılık.UseVisualStyleBackColor = true;
            // 
            // rdo_kiralık
            // 
            this.rdo_kiralık.AutoSize = true;
            this.rdo_kiralık.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdo_kiralık.Location = new System.Drawing.Point(23, 134);
            this.rdo_kiralık.Name = "rdo_kiralık";
            this.rdo_kiralık.Size = new System.Drawing.Size(95, 27);
            this.rdo_kiralık.TabIndex = 14;
            this.rdo_kiralık.Text = "Kiralık";
            this.rdo_kiralık.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Beige;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdo_daire);
            this.groupBox1.Controls.Add(this.rdo_isyeri);
            this.groupBox1.Controls.Add(this.rdo_konut);
            this.groupBox1.Location = new System.Drawing.Point(232, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 201);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Beige;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.rdo_Satılık);
            this.groupBox2.Controls.Add(this.rdo_kiralık);
            this.groupBox2.Location = new System.Drawing.Point(414, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 201);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(18, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 38);
            this.label6.TabIndex = 15;
            this.label6.Text = "Durum";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Beige;
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.cmb_sehir);
            this.groupBox4.Location = new System.Drawing.Point(596, 139);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 201);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(414, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 41);
            this.button3.TabIndex = 19;
            this.button3.Text = "Sonraki Adım";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ePostaToolStripMenuItem
            // 
            this.ePostaToolStripMenuItem.Name = "ePostaToolStripMenuItem";
            this.ePostaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ePostaToolStripMenuItem.Text = "E-Posta";
            this.ePostaToolStripMenuItem.Click += new System.EventHandler(this.ePostaToolStripMenuItem_Click);
            // 
            // aramaToolStripMenuItem
            // 
            this.aramaToolStripMenuItem.Name = "aramaToolStripMenuItem";
            this.aramaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aramaToolStripMenuItem.Text = "Arama";
            this.aramaToolStripMenuItem.Click += new System.EventHandler(this.aramaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emlakcım.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_sehir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaSayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arkaPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdo_daire;
        private System.Windows.Forms.RadioButton rdo_isyeri;
        private System.Windows.Forms.RadioButton rdo_konut;
        private System.Windows.Forms.RadioButton rdo_Satılık;
        private System.Windows.Forms.RadioButton rdo_kiralık;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem iletişimBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem varsayılanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ePostaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aramaToolStripMenuItem;
    }
}

