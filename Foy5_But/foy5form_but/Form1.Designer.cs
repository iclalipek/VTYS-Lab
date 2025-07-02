namespace foy5form_but
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOgrenciTemizle = new System.Windows.Forms.Button();
            this.btnOgrenciSil = new System.Windows.Forms.Button();
            this.btnOgrenciGuncelle = new System.Windows.Forms.Button();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.cmbOgrenciBolum = new System.Windows.Forms.ComboBox();
            this.txtOgrenciSoyad = new System.Windows.Forms.TextBox();
            this.txtOgrenciAd = new System.Windows.Forms.TextBox();
            this.txtOgrenciID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnDersTemizle = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnDersGuncelle = new System.Windows.Forms.Button();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.txtDersAd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvDersler = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnBolumTemizle = new System.Windows.Forms.Button();
            this.dgvBolumler = new System.Windows.Forms.DataGridView();
            this.btnBolumSil = new System.Windows.Forms.Button();
            this.btnBolumGuncelle = new System.Windows.Forms.Button();
            this.btnBolumEkle = new System.Windows.Forms.Button();
            this.txtBolumAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBolumFakulte = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnOgrencininDersiniSil = new System.Windows.Forms.Button();
            this.dgvOgrencininDersleri = new System.Windows.Forms.DataGridView();
            this.btnDersAta = new System.Windows.Forms.Button();
            this.txtAtamaYil = new System.Windows.Forms.TextBox();
            this.cmbAtamaYariyil = new System.Windows.Forms.ComboBox();
            this.cmbAtamaDers = new System.Windows.Forms.ComboBox();
            this.cmbAtamaOgrenci = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvListeDersSayilari = new System.Windows.Forms.DataGridView();
            this.btnListeDersSayilari = new System.Windows.Forms.Button();
            this.cmbListeYariyil = new System.Windows.Forms.ComboBox();
            this.txtListeYil = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvListeOgrenciDersleri = new System.Windows.Forms.DataGridView();
            this.btnListeOgrenciDersleri = new System.Windows.Forms.Button();
            this.txtListeOgrenciNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnNotlariKaydet = new System.Windows.Forms.Button();
            this.dgvNotlar = new System.Windows.Forms.DataGridView();
            this.cmbNotDersler = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolumler)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrencininDersleri)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDersSayilari)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeOgrenciDersleri)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotlar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1108, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnOgrenciTemizle);
            this.tabPage1.Controls.Add(this.btnOgrenciSil);
            this.tabPage1.Controls.Add(this.btnOgrenciGuncelle);
            this.tabPage1.Controls.Add(this.btnOgrenciEkle);
            this.tabPage1.Controls.Add(this.cmbOgrenciBolum);
            this.tabPage1.Controls.Add(this.txtOgrenciSoyad);
            this.tabPage1.Controls.Add(this.txtOgrenciAd);
            this.tabPage1.Controls.Add(this.txtOgrenciID);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.dgvOgrenciler);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1100, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Öğrenci";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOgrenciTemizle
            // 
            this.btnOgrenciTemizle.Location = new System.Drawing.Point(53, 416);
            this.btnOgrenciTemizle.Name = "btnOgrenciTemizle";
            this.btnOgrenciTemizle.Size = new System.Drawing.Size(98, 23);
            this.btnOgrenciTemizle.TabIndex = 12;
            this.btnOgrenciTemizle.Text = "Temizle";
            this.btnOgrenciTemizle.UseVisualStyleBackColor = true;
            this.btnOgrenciTemizle.Click += new System.EventHandler(this.btnOgrenciTemizle_Click);
            // 
            // btnOgrenciSil
            // 
            this.btnOgrenciSil.Location = new System.Drawing.Point(183, 416);
            this.btnOgrenciSil.Name = "btnOgrenciSil";
            this.btnOgrenciSil.Size = new System.Drawing.Size(98, 23);
            this.btnOgrenciSil.TabIndex = 11;
            this.btnOgrenciSil.Text = "Sil";
            this.btnOgrenciSil.UseVisualStyleBackColor = true;
            this.btnOgrenciSil.Click += new System.EventHandler(this.btnOgrenciSil_Click);
            // 
            // btnOgrenciGuncelle
            // 
            this.btnOgrenciGuncelle.Location = new System.Drawing.Point(164, 346);
            this.btnOgrenciGuncelle.Name = "btnOgrenciGuncelle";
            this.btnOgrenciGuncelle.Size = new System.Drawing.Size(117, 24);
            this.btnOgrenciGuncelle.TabIndex = 10;
            this.btnOgrenciGuncelle.Text = "Güncelle";
            this.btnOgrenciGuncelle.UseVisualStyleBackColor = true;
            this.btnOgrenciGuncelle.Click += new System.EventHandler(this.btnOgrenciGuncelle_Click);
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(53, 347);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(98, 23);
            this.btnOgrenciEkle.TabIndex = 9;
            this.btnOgrenciEkle.Text = "Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // cmbOgrenciBolum
            // 
            this.cmbOgrenciBolum.FormattingEnabled = true;
            this.cmbOgrenciBolum.Location = new System.Drawing.Point(53, 281);
            this.cmbOgrenciBolum.Name = "cmbOgrenciBolum";
            this.cmbOgrenciBolum.Size = new System.Drawing.Size(228, 24);
            this.cmbOgrenciBolum.TabIndex = 8;
            // 
            // txtOgrenciSoyad
            // 
            this.txtOgrenciSoyad.Location = new System.Drawing.Point(53, 219);
            this.txtOgrenciSoyad.Name = "txtOgrenciSoyad";
            this.txtOgrenciSoyad.Size = new System.Drawing.Size(139, 22);
            this.txtOgrenciSoyad.TabIndex = 7;
            // 
            // txtOgrenciAd
            // 
            this.txtOgrenciAd.Location = new System.Drawing.Point(53, 150);
            this.txtOgrenciAd.Name = "txtOgrenciAd";
            this.txtOgrenciAd.Size = new System.Drawing.Size(139, 22);
            this.txtOgrenciAd.TabIndex = 6;
            // 
            // txtOgrenciID
            // 
            this.txtOgrenciID.Location = new System.Drawing.Point(53, 88);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new System.Drawing.Size(139, 22);
            this.txtOgrenciID.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Bölüm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Öğrenci No";
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenciler_CellClick);
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Location = new System.Drawing.Point(443, 81);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.RowHeadersWidth = 51;
            this.dgvOgrenciler.RowTemplate.Height = 24;
            this.dgvOgrenciler.Size = new System.Drawing.Size(614, 358);
            this.dgvOgrenciler.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDersTemizle);
            this.tabPage2.Controls.Add(this.btnDersSil);
            this.tabPage2.Controls.Add(this.btnDersGuncelle);
            this.tabPage2.Controls.Add(this.btnDersEkle);
            this.tabPage2.Controls.Add(this.txtDersAd);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dgvDersler);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1100, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ders";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDersTemizle
            // 
            this.btnDersTemizle.Location = new System.Drawing.Point(166, 224);
            this.btnDersTemizle.Name = "btnDersTemizle";
            this.btnDersTemizle.Size = new System.Drawing.Size(104, 23);
            this.btnDersTemizle.TabIndex = 6;
            this.btnDersTemizle.Text = "Temizle";
            this.btnDersTemizle.UseVisualStyleBackColor = true;
            this.btnDersTemizle.Click += new System.EventHandler(this.btnDersTemizle_Click);
            // 
            // btnDersSil
            // 
            this.btnDersSil.Location = new System.Drawing.Point(59, 224);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(75, 23);
            this.btnDersSil.TabIndex = 5;
            this.btnDersSil.Text = "Sil";
            this.btnDersSil.UseVisualStyleBackColor = true;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // btnDersGuncelle
            // 
            this.btnDersGuncelle.Location = new System.Drawing.Point(166, 164);
            this.btnDersGuncelle.Name = "btnDersGuncelle";
            this.btnDersGuncelle.Size = new System.Drawing.Size(104, 23);
            this.btnDersGuncelle.TabIndex = 4;
            this.btnDersGuncelle.Text = "Güncelle";
            this.btnDersGuncelle.UseVisualStyleBackColor = true;
            this.btnDersGuncelle.Click += new System.EventHandler(this.btnDersGuncelle_Click);
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(59, 164);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDersEkle.TabIndex = 3;
            this.btnDersEkle.Text = "Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // txtDersAd
            // 
            this.txtDersAd.Location = new System.Drawing.Point(59, 122);
            this.txtDersAd.Name = "txtDersAd";
            this.txtDersAd.Size = new System.Drawing.Size(236, 22);
            this.txtDersAd.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ders Adı";
            // 
            // dgvDersler
            // 
            this.dgvDersler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDersler_CellClick);
            this.dgvDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDersler.Location = new System.Drawing.Point(357, 55);
            this.dgvDersler.Name = "dgvDersler";
            this.dgvDersler.RowHeadersWidth = 51;
            this.dgvDersler.RowTemplate.Height = 24;
            this.dgvDersler.Size = new System.Drawing.Size(671, 345);
            this.dgvDersler.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnBolumTemizle);
            this.tabPage3.Controls.Add(this.dgvBolumler);
            this.tabPage3.Controls.Add(this.btnBolumSil);
            this.tabPage3.Controls.Add(this.btnBolumGuncelle);
            this.tabPage3.Controls.Add(this.btnBolumEkle);
            this.tabPage3.Controls.Add(this.txtBolumAd);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cmbBolumFakulte);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1100, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bölüm";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnBolumTemizle
            // 
            this.btnBolumTemizle.Location = new System.Drawing.Point(59, 273);
            this.btnBolumTemizle.Name = "btnBolumTemizle";
            this.btnBolumTemizle.Size = new System.Drawing.Size(97, 23);
            this.btnBolumTemizle.TabIndex = 8;
            this.btnBolumTemizle.Text = "Temizle";
            this.btnBolumTemizle.UseVisualStyleBackColor = true;
            this.btnBolumTemizle.Click += new System.EventHandler(this.btnBolumTemizle_Click);
            // 
            // dgvBolumler
            // 
            this.dgvBolumler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBolumler.Location = new System.Drawing.Point(498, 58);
            this.dgvBolumler.Name = "dgvBolumler";
            this.dgvBolumler.RowHeadersWidth = 51;
            this.dgvBolumler.RowTemplate.Height = 24;
            this.dgvBolumler.Size = new System.Drawing.Size(565, 369);
            this.dgvBolumler.TabIndex = 7;
            this.dgvBolumler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBolumler_CellClick);
            // 
            // btnBolumSil
            // 
            this.btnBolumSil.Location = new System.Drawing.Point(287, 227);
            this.btnBolumSil.Name = "btnBolumSil";
            this.btnBolumSil.Size = new System.Drawing.Size(97, 23);
            this.btnBolumSil.TabIndex = 6;
            this.btnBolumSil.Text = "Sil";
            this.btnBolumSil.UseVisualStyleBackColor = true;
            this.btnBolumSil.Click += new System.EventHandler(this.btnBolumSil_Click);
            // 
            // btnBolumGuncelle
            // 
            this.btnBolumGuncelle.Location = new System.Drawing.Point(171, 227);
            this.btnBolumGuncelle.Name = "btnBolumGuncelle";
            this.btnBolumGuncelle.Size = new System.Drawing.Size(97, 23);
            this.btnBolumGuncelle.TabIndex = 5;
            this.btnBolumGuncelle.Text = "Güncelle";
            this.btnBolumGuncelle.UseVisualStyleBackColor = true;
            this.btnBolumGuncelle.Click += new System.EventHandler(this.btnBolumGuncelle_Click);
            // 
            // btnBolumEkle
            // 
            this.btnBolumEkle.Location = new System.Drawing.Point(59, 227);
            this.btnBolumEkle.Name = "btnBolumEkle";
            this.btnBolumEkle.Size = new System.Drawing.Size(97, 23);
            this.btnBolumEkle.TabIndex = 4;
            this.btnBolumEkle.Text = "Ekle";
            this.btnBolumEkle.UseVisualStyleBackColor = true;
            this.btnBolumEkle.Click += new System.EventHandler(this.btnBolumEkle_Click);
            // 
            // txtBolumAd
            // 
            this.txtBolumAd.Location = new System.Drawing.Point(59, 153);
            this.txtBolumAd.Name = "txtBolumAd";
            this.txtBolumAd.Size = new System.Drawing.Size(209, 22);
            this.txtBolumAd.TabIndex = 3;
            this.txtBolumAd.TextChanged += new System.EventHandler(this.txtBolumAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bölüm Adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbBolumFakulte
            // 
            this.cmbBolumFakulte.FormattingEnabled = true;
            this.cmbBolumFakulte.Location = new System.Drawing.Point(59, 92);
            this.cmbBolumFakulte.Name = "cmbBolumFakulte";
            this.cmbBolumFakulte.Size = new System.Drawing.Size(230, 24);
            this.cmbBolumFakulte.TabIndex = 1;
            this.cmbBolumFakulte.SelectedIndexChanged += new System.EventHandler(this.cmbBolumFakulte_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fakülte";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnOgrencininDersiniSil);
            this.tabPage4.Controls.Add(this.dgvOgrencininDersleri);
            this.tabPage4.Controls.Add(this.btnDersAta);
            this.tabPage4.Controls.Add(this.txtAtamaYil);
            this.tabPage4.Controls.Add(this.cmbAtamaYariyil);
            this.tabPage4.Controls.Add(this.cmbAtamaDers);
            this.tabPage4.Controls.Add(this.cmbAtamaOgrenci);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1100, 525);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ders Atama";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnOgrencininDersiniSil
            // 
            this.btnOgrencininDersiniSil.Location = new System.Drawing.Point(168, 362);
            this.btnOgrencininDersiniSil.Name = "btnOgrencininDersiniSil";
            this.btnOgrencininDersiniSil.Size = new System.Drawing.Size(136, 23);
            this.btnOgrencininDersiniSil.TabIndex = 10;
            this.btnOgrencininDersiniSil.Text = "Seçili Dersi Sil";
            this.btnOgrencininDersiniSil.UseVisualStyleBackColor = true;
            this.btnOgrencininDersiniSil.Click += new System.EventHandler(this.btnOgrencininDersiniSil_Click);
            // 
            // dgvOgrencininDersleri
            // 
            this.dgvOgrencininDersleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrencininDersleri.Location = new System.Drawing.Point(432, 62);
            this.dgvOgrencininDersleri.Name = "dgvOgrencininDersleri";
            this.dgvOgrencininDersleri.RowHeadersWidth = 51;
            this.dgvOgrencininDersleri.RowTemplate.Height = 24;
            this.dgvOgrencininDersleri.Size = new System.Drawing.Size(612, 384);
            this.dgvOgrencininDersleri.TabIndex = 9;
            // 
            // btnDersAta
            // 
            this.btnDersAta.Location = new System.Drawing.Point(64, 362);
            this.btnDersAta.Name = "btnDersAta";
            this.btnDersAta.Size = new System.Drawing.Size(90, 23);
            this.btnDersAta.TabIndex = 8;
            this.btnDersAta.Text = "Dersi Ata";
            this.btnDersAta.UseVisualStyleBackColor = true;
            this.btnDersAta.Click += new System.EventHandler(this.btnDersAta_Click);
            // 
            // txtAtamaYil
            // 
            this.txtAtamaYil.Location = new System.Drawing.Point(64, 211);
            this.txtAtamaYil.Name = "txtAtamaYil";
            this.txtAtamaYil.Size = new System.Drawing.Size(240, 22);
            this.txtAtamaYil.TabIndex = 7;
            // 
            // cmbAtamaYariyil
            // 
            this.cmbAtamaYariyil.FormattingEnabled = true;
            this.cmbAtamaYariyil.Items.AddRange(new object[] {
            "Güz",
            "Bahar"});
            this.cmbAtamaYariyil.Location = new System.Drawing.Point(64, 276);
            this.cmbAtamaYariyil.Name = "cmbAtamaYariyil";
            this.cmbAtamaYariyil.Size = new System.Drawing.Size(261, 24);
            this.cmbAtamaYariyil.TabIndex = 6;
            // 
            // cmbAtamaDers
            // 
            this.cmbAtamaDers.FormattingEnabled = true;
            this.cmbAtamaDers.Location = new System.Drawing.Point(64, 151);
            this.cmbAtamaDers.Name = "cmbAtamaDers";
            this.cmbAtamaDers.Size = new System.Drawing.Size(261, 24);
            this.cmbAtamaDers.TabIndex = 5;
            // 
            // cmbAtamaOgrenci
            // 
            this.cmbAtamaOgrenci.FormattingEnabled = true;
            this.cmbAtamaOgrenci.Location = new System.Drawing.Point(64, 89);
            this.cmbAtamaOgrenci.Name = "cmbAtamaOgrenci";
            this.cmbAtamaOgrenci.Size = new System.Drawing.Size(261, 24);
            this.cmbAtamaOgrenci.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(61, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Yarıyıl";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(61, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Yıl";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Ders Seç";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Öğrenci Seç";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1100, 525);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Listeleme";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvListeDersSayilari);
            this.groupBox2.Controls.Add(this.btnListeDersSayilari);
            this.groupBox2.Controls.Add(this.cmbListeYariyil);
            this.groupBox2.Controls.Add(this.txtListeYil);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(26, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1045, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Döneme Göre Ders İstatistikleri";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dgvListeDersSayilari
            // 
            this.dgvListeDersSayilari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeDersSayilari.Location = new System.Drawing.Point(290, 21);
            this.dgvListeDersSayilari.Name = "dgvListeDersSayilari";
            this.dgvListeDersSayilari.RowHeadersWidth = 51;
            this.dgvListeDersSayilari.RowTemplate.Height = 24;
            this.dgvListeDersSayilari.Size = new System.Drawing.Size(749, 211);
            this.dgvListeDersSayilari.TabIndex = 5;
            // 
            // btnListeDersSayilari
            // 
            this.btnListeDersSayilari.Location = new System.Drawing.Point(23, 156);
            this.btnListeDersSayilari.Name = "btnListeDersSayilari";
            this.btnListeDersSayilari.Size = new System.Drawing.Size(185, 23);
            this.btnListeDersSayilari.TabIndex = 4;
            this.btnListeDersSayilari.Text = "İstatistikleri Listele";
            this.btnListeDersSayilari.UseVisualStyleBackColor = true;
            this.btnListeDersSayilari.Click += new System.EventHandler(this.btnListeDersSayilari_Click);
            // 
            // cmbListeYariyil
            // 
            this.cmbListeYariyil.FormattingEnabled = true;
            this.cmbListeYariyil.Items.AddRange(new object[] {
            "Güz",
            "Bahar"});
            this.cmbListeYariyil.Location = new System.Drawing.Point(23, 112);
            this.cmbListeYariyil.Name = "cmbListeYariyil";
            this.cmbListeYariyil.Size = new System.Drawing.Size(150, 24);
            this.cmbListeYariyil.TabIndex = 3;
            // 
            // txtListeYil
            // 
            this.txtListeYil.Location = new System.Drawing.Point(23, 68);
            this.txtListeYil.Name = "txtListeYil";
            this.txtListeYil.Size = new System.Drawing.Size(129, 22);
            this.txtListeYil.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "Yarıyıl";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Yıl";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvListeOgrenciDersleri);
            this.groupBox1.Controls.Add(this.btnListeOgrenciDersleri);
            this.groupBox1.Controls.Add(this.txtListeOgrenciNo);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(26, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrencinin Dersleri";
            // 
            // dgvListeOgrenciDersleri
            // 
            this.dgvListeOgrenciDersleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeOgrenciDersleri.Location = new System.Drawing.Point(290, 9);
            this.dgvListeOgrenciDersleri.Name = "dgvListeOgrenciDersleri";
            this.dgvListeOgrenciDersleri.RowHeadersWidth = 51;
            this.dgvListeOgrenciDersleri.RowTemplate.Height = 24;
            this.dgvListeOgrenciDersleri.Size = new System.Drawing.Size(749, 233);
            this.dgvListeOgrenciDersleri.TabIndex = 3;
            this.dgvListeOgrenciDersleri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListeOgrenciDersleri_CellContentClick);
            // 
            // btnListeOgrenciDersleri
            // 
            this.btnListeOgrenciDersleri.Location = new System.Drawing.Point(23, 102);
            this.btnListeOgrenciDersleri.Name = "btnListeOgrenciDersleri";
            this.btnListeOgrenciDersleri.Size = new System.Drawing.Size(169, 23);
            this.btnListeOgrenciDersleri.TabIndex = 2;
            this.btnListeOgrenciDersleri.Text = "Dersleri Listele";
            this.btnListeOgrenciDersleri.UseVisualStyleBackColor = true;
            this.btnListeOgrenciDersleri.Click += new System.EventHandler(this.btnListeOgrenciDersleri_Click);
            // 
            // txtListeOgrenciNo
            // 
            this.txtListeOgrenciNo.Location = new System.Drawing.Point(23, 73);
            this.txtListeOgrenciNo.Name = "txtListeOgrenciNo";
            this.txtListeOgrenciNo.Size = new System.Drawing.Size(141, 22);
            this.txtListeOgrenciNo.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Öğrenci No";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnNotlariKaydet);
            this.tabPage6.Controls.Add(this.dgvNotlar);
            this.tabPage6.Controls.Add(this.cmbNotDersler);
            this.tabPage6.Controls.Add(this.label3);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1100, 525);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Not Girişi";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnNotlariKaydet
            // 
            this.btnNotlariKaydet.Location = new System.Drawing.Point(47, 204);
            this.btnNotlariKaydet.Name = "btnNotlariKaydet";
            this.btnNotlariKaydet.Size = new System.Drawing.Size(164, 23);
            this.btnNotlariKaydet.TabIndex = 3;
            this.btnNotlariKaydet.Text = "Notları Kaydet";
            this.btnNotlariKaydet.UseVisualStyleBackColor = true;
            this.btnNotlariKaydet.Click += new System.EventHandler(this.btnNotlariKaydet_Click);
            // 
            // dgvNotlar
            // 
            this.dgvNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotlar.Location = new System.Drawing.Point(249, 69);
            this.dgvNotlar.Name = "dgvNotlar";
            this.dgvNotlar.RowHeadersWidth = 51;
            this.dgvNotlar.RowTemplate.Height = 24;
            this.dgvNotlar.Size = new System.Drawing.Size(822, 329);
            this.dgvNotlar.TabIndex = 2;
            this.dgvNotlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotlar_CellContentClick);
            // 
            // cmbNotDersler
            // 
            this.cmbNotDersler.FormattingEnabled = true;
            this.cmbNotDersler.Location = new System.Drawing.Point(47, 142);
            this.cmbNotDersler.Name = "cmbNotDersler";
            this.cmbNotDersler.Size = new System.Drawing.Size(164, 24);
            this.cmbNotDersler.TabIndex = 1;
            this.cmbNotDersler.SelectedIndexChanged += new System.EventHandler(this.cmbNotDersler_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ders Seçin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 554);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDersler)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBolumler)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrencininDersleri)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeDersSayilari)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeOgrenciDersleri)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button btnBolumGuncelle;
        private System.Windows.Forms.Button btnBolumEkle;
        private System.Windows.Forms.TextBox txtBolumAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBolumFakulte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBolumler;
        private System.Windows.Forms.Button btnBolumSil;
        private System.Windows.Forms.Button btnNotlariKaydet;
        private System.Windows.Forms.DataGridView dgvNotlar;
        private System.Windows.Forms.ComboBox cmbNotDersler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvOgrenciler;
        private System.Windows.Forms.Button btnOgrenciTemizle;
        private System.Windows.Forms.Button btnOgrenciSil;
        private System.Windows.Forms.Button btnOgrenciGuncelle;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.ComboBox cmbOgrenciBolum;
        private System.Windows.Forms.TextBox txtOgrenciSoyad;
        private System.Windows.Forms.TextBox txtOgrenciAd;
        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDersTemizle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnDersGuncelle;
        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.TextBox txtDersAd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvDersler;
        private System.Windows.Forms.Button btnBolumTemizle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDersAta;
        private System.Windows.Forms.TextBox txtAtamaYil;
        private System.Windows.Forms.ComboBox cmbAtamaYariyil;
        private System.Windows.Forms.ComboBox cmbAtamaDers;
        private System.Windows.Forms.ComboBox cmbAtamaOgrenci;
        private System.Windows.Forms.Button btnOgrencininDersiniSil;
        private System.Windows.Forms.DataGridView dgvOgrencininDersleri;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvListeOgrenciDersleri;
        private System.Windows.Forms.Button btnListeOgrenciDersleri;
        private System.Windows.Forms.TextBox txtListeOgrenciNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbListeYariyil;
        private System.Windows.Forms.TextBox txtListeYil;
        private System.Windows.Forms.DataGridView dgvListeDersSayilari;
        private System.Windows.Forms.Button btnListeDersSayilari;
    }
}

