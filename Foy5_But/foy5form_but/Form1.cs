using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using foy5form_but.Models;

using System.Data.Entity;

namespace foy5form_but
{
    public partial class Form1 : Form
    {
        // Seçili satırların ID'lerini tutmak için değişkenler
        private int seciliOgrenciID = 0;
        private int seciliDersID = 0;
        private int seciliBolumID = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Uygulama ilk açıldığında veritabanında temel veriler yoksa oluşturalım.
            //SeedData();

            // Tüm ekranların başlangıç verilerini yükleyelim
            // Ekran 1
            OgrenciListele();
            OgrenciBolumleriDoldur();
            // Ekran 2
            DersListele();
            // Ekran 3
            BolumleriListele();
            BolumFakulteleriDoldur();
            // Ekran 4
            AtamaOgrencileriDoldur();
            AtamaDersleriDoldur();
            // Ekran 6
            NotGirisDersleriDoldur();
        }

        /// <summary>
        /// Veritabanı boş ise test için temel verileri ekler.
        /// </summary>
        //private void SeedData()
        //{
        //    using (var db = new ProjeContext())
        //    {
        //        if (!db.Fakulteler.Any())
        //        {
        //            db.Fakulteler.Add(new tFakulte { fakulteAd = "Mühendislik Fakültesi" });
        //            db.Fakulteler.Add(new tFakulte { fakulteAd = "İktisadi ve İdari Bilimler Fakültesi" });
        //            db.SaveChanges();
        //        }

        //        if (!db.Dersler.Any())
        //        {
        //            db.Dersler.Add(new tDers { dersAd = "Veritabanı Yönetim Sistemleri" });
        //            db.Dersler.Add(new tDers { dersAd = "Nesne Yönelimli Programlama" });
        //            db.Dersler.Add(new tDers { dersAd = "Calculus I" });
        //            db.Dersler.Add(new tDers { dersAd = "Mikroekonomi" });
        //            db.SaveChanges();
        //        }
        //    }
        //}


        #region Ekran 1: Öğrenci CRUD İşlemleri

        private void OgrenciBolumleriDoldur()
        {
            using (var db = new ProjeContext())
            {
                cmbOgrenciBolum.DataSource = db.Bolumler.ToList();
                cmbOgrenciBolum.DisplayMember = "bolumAd";
                cmbOgrenciBolum.ValueMember = "bolumID";
                cmbOgrenciBolum.SelectedIndex = -1;
            }
        }

        private void OgrenciListele()
        {
            using (var db = new ProjeContext())
            {
                dgvOgrenciler.DataSource = db.Ogrenciler
                    .Include(o => o.Bolum)
                    .Select(o => new
                    {
                        o.ogrenciID,
                        o.ad,
                        o.soyad,
                        BolumAdi = o.Bolum.bolumAd
                    }).ToList();
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOgrenciID.Text, out int ogrenciNo))
            {
                MessageBox.Show("Öğrenci Numarası geçerli bir sayı olmalıdır.");
                return;
            }

            using (var db = new ProjeContext())
            {
                if (db.Ogrenciler.Any(o => o.ogrenciID == ogrenciNo))
                {
                    MessageBox.Show("Bu öğrenci numarası zaten kayıtlı.");
                    return;
                }

                var yeniOgrenci = new tOgrenci
                {
                    ogrenciID = ogrenciNo,
                    ad = txtOgrenciAd.Text,
                    soyad = txtOgrenciSoyad.Text,
                    bolumID = (int)cmbOgrenciBolum.SelectedValue
                };
                db.Ogrenciler.Add(yeniOgrenci);
                db.SaveChanges();
            }
            OgrenciListele();
            btnOgrenciTemizle_Click(sender, e);
        }

        private void btnOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliOgrenciID == 0) return;
            using (var db = new ProjeContext())
            {
                var ogrenci = db.Ogrenciler.Find(seciliOgrenciID);
                ogrenci.ad = txtOgrenciAd.Text;
                ogrenci.soyad = txtOgrenciSoyad.Text;
                ogrenci.bolumID = (int)cmbOgrenciBolum.SelectedValue;
                db.SaveChanges();
            }
            OgrenciListele();
            btnOgrenciTemizle_Click(sender, e);
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            if (seciliOgrenciID == 0) return;
            using (var db = new ProjeContext())
            {
                var ogrenci = db.Ogrenciler.Find(seciliOgrenciID);
                db.Ogrenciler.Remove(ogrenci);
                db.SaveChanges();
            }
            OgrenciListele();
            btnOgrenciTemizle_Click(sender, e);
        }

        private void btnOgrenciTemizle_Click(object sender, EventArgs e)
        {
            txtOgrenciID.Clear();
            txtOgrenciAd.Clear();
            txtOgrenciSoyad.Clear();
            cmbOgrenciBolum.SelectedIndex = -1;
            seciliOgrenciID = 0;
            txtOgrenciID.Enabled = true;
        }

        private void dgvOgrenciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvOgrenciler.Rows[e.RowIndex];
                seciliOgrenciID = (int)row.Cells["ogrenciID"].Value;

                txtOgrenciID.Text = row.Cells["ogrenciID"].Value.ToString();
                txtOgrenciAd.Text = row.Cells["ad"].Value.ToString();
                txtOgrenciSoyad.Text = row.Cells["soyad"].Value.ToString();
                cmbOgrenciBolum.Text = row.Cells["BolumAdi"].Value.ToString();
                txtOgrenciID.Enabled = false; // Primary key güncellenmemeli
            }
        }

        #endregion

        #region Ekran 2: Ders CRUD İşlemleri

        private void DersListele()
        {
            using (var db = new ProjeContext())
            {
                dgvDersler.DataSource = db.Dersler
                    .Select(d => new { d.dersID, d.dersAd })
                    .ToList();
            }
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            using (var db = new ProjeContext())
            {
                db.Dersler.Add(new tDers { dersAd = txtDersAd.Text });
                db.SaveChanges();
            }
            DersListele();
            btnDersTemizle_Click(sender, e);
        }

        private void btnDersGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliDersID == 0) return;
            using (var db = new ProjeContext())
            {
                var ders = db.Dersler.Find(seciliDersID);
                ders.dersAd = txtDersAd.Text;
                db.SaveChanges();
            }
            DersListele();
            btnDersTemizle_Click(sender, e);
        }

        private void btnDersSil_Click(object sender, EventArgs e)
        {
            if (seciliDersID == 0) return;
            using (var db = new ProjeContext())
            {
                var ders = db.Dersler.Find(seciliDersID);
                db.Dersler.Remove(ders);
                db.SaveChanges();
            }
            DersListele();
            btnDersTemizle_Click(sender, e);
        }

        private void btnDersTemizle_Click(object sender, EventArgs e)
        {
            txtDersAd.Clear();
            seciliDersID = 0;
            dgvDersler.ClearSelection();
        }

        private void dgvDersler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDersler.Rows[e.RowIndex];
                seciliDersID = (int)row.Cells["dersID"].Value;
                txtDersAd.Text = row.Cells["dersAd"].Value.ToString();
            }
        }

        #endregion

        #region Ekran 3: Bölüm CRUD İşlemleri

        private void BolumFakulteleriDoldur()
        {
            using (var db = new ProjeContext())
            {
                cmbBolumFakulte.DataSource = db.Fakulteler.ToList();
                cmbBolumFakulte.DisplayMember = "fakulteAd";
                cmbBolumFakulte.ValueMember = "fakulteID";
                cmbBolumFakulte.SelectedIndex = -1;
            }
        }

        private void BolumleriListele()
        {
            using (var db = new ProjeContext())
            {
                dgvBolumler.DataSource = db.Bolumler
                    .Include(b => b.Fakulte)
                    .Select(b => new {
                        b.bolumID,
                        b.bolumAd,
                        FakulteAdi = b.Fakulte.fakulteAd
                    }).ToList();
            }
        }

        private void btnBolumEkle_Click(object sender, EventArgs e)
        {
            using (var db = new ProjeContext())
            {
                var yeniBolum = new tBolum
                {
                    bolumAd = txtBolumAd.Text,
                    fakulteID = (int)cmbBolumFakulte.SelectedValue
                };
                db.Bolumler.Add(yeniBolum);
                db.SaveChanges();
            }
            BolumleriListele();
            btnBolumTemizle_Click(sender, e);
        }

        private void btnBolumGuncelle_Click(object sender, EventArgs e)
        {
            if (seciliBolumID == 0) return;
            using (var db = new ProjeContext())
            {
                var bolum = db.Bolumler.Find(seciliBolumID);
                bolum.bolumAd = txtBolumAd.Text;
                bolum.fakulteID = (int)cmbBolumFakulte.SelectedValue;
                db.SaveChanges();
            }
            BolumleriListele();
            btnBolumTemizle_Click(sender, e);
        }

        private void btnBolumSil_Click(object sender, EventArgs e)
        {
            if (seciliBolumID == 0) return;
            using (var db = new ProjeContext())
            {
                var bolum = db.Bolumler.Find(seciliBolumID);
                db.Bolumler.Remove(bolum);
                db.SaveChanges();
            }
            BolumleriListele();
            btnBolumTemizle_Click(sender, e);
        }

        private void btnBolumTemizle_Click(object sender, EventArgs e)
        {
            txtBolumAd.Clear();
            cmbBolumFakulte.SelectedIndex = -1;
            seciliBolumID = 0;
            dgvBolumler.ClearSelection();
        }

        private void dgvBolumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBolumler.Rows[e.RowIndex];
                seciliBolumID = (int)row.Cells["bolumID"].Value;
                txtBolumAd.Text = row.Cells["bolumAd"].Value.ToString();
                cmbBolumFakulte.Text = row.Cells["FakulteAdi"].Value.ToString();
            }
        }

        #endregion

        #region Ekran 4: Öğrenciye Ders Atama

        private void AtamaOgrencileriDoldur()
        {
            using (var db = new ProjeContext())
            {
                cmbAtamaOgrenci.DataSource = db.Ogrenciler
                    .Select(o => new { o.ogrenciID, AdSoyad = o.ad + " " + o.soyad })
                    .ToList();
                cmbAtamaOgrenci.DisplayMember = "AdSoyad";
                cmbAtamaOgrenci.ValueMember = "ogrenciID";
                cmbAtamaOgrenci.SelectedIndex = -1;
            }
        }

        private void AtamaDersleriDoldur()
        {
            using (var db = new ProjeContext())
            {
                cmbAtamaDers.DataSource = db.Dersler.ToList();
                cmbAtamaDers.DisplayMember = "dersAd";
                cmbAtamaDers.ValueMember = "dersID";
                cmbAtamaDers.SelectedIndex = -1;
            }
        }

        private void OgrencininDersleriniListele()
        {
            if (cmbAtamaOgrenci.SelectedValue == null)
            {
                dgvOgrencininDersleri.DataSource = null;
                return;
            }
            int ogrenciId = (int)cmbAtamaOgrenci.SelectedValue;
            using (var db = new ProjeContext())
            {
                dgvOgrencininDersleri.DataSource = db.OgrenciDersleri
                    .Where(od => od.ogrenciID == ogrenciId)
                    .Select(od => new
                    {
                        od.dersID,
                        DersAdi = od.Ders.dersAd,
                        od.yil,
                        od.yariyil
                    }).ToList();
            }
        }

        private void cmbAtamaOgrenci_SelectedIndexChanged(object sender, EventArgs e)
        {
            OgrencininDersleriniListele();
        }

        private void btnDersAta_Click(object sender, EventArgs e)
        {
            if (cmbAtamaOgrenci.SelectedValue == null || cmbAtamaDers.SelectedValue == null || string.IsNullOrWhiteSpace(txtAtamaYil.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            var atama = new tOgrenciDers
            {
                ogrenciID = (int)cmbAtamaOgrenci.SelectedValue,
                dersID = (int)cmbAtamaDers.SelectedValue,
                yil = int.Parse(txtAtamaYil.Text),
                yariyil = cmbAtamaYariyil.SelectedItem.ToString()
            };

            using (var db = new ProjeContext())
            {
                // Aynı dersin aynı öğrenciye tekrar atanmasını engelle
                if (db.OgrenciDersleri.Any(od => od.ogrenciID == atama.ogrenciID && od.dersID == atama.dersID))
                {
                    MessageBox.Show("Bu ders bu öğrenciye zaten atanmış.");
                    return;
                }
                db.OgrenciDersleri.Add(atama);
                db.SaveChanges();
            }
            OgrencininDersleriniListele();
        }

        private void btnOgrencininDersiniSil_Click(object sender, EventArgs e)
        {
            if (dgvOgrencininDersleri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir ders seçin.");
                return;
            }

            int ogrenciId = (int)cmbAtamaOgrenci.SelectedValue;
            int dersId = (int)dgvOgrencininDersleri.SelectedRows[0].Cells["dersID"].Value;

            using (var db = new ProjeContext())
            {
                var kayit = db.OgrenciDersleri.Find(ogrenciId, dersId);
                if (kayit != null)
                {
                    db.OgrenciDersleri.Remove(kayit);
                    db.SaveChanges();
                }
            }
            OgrencininDersleriniListele();
        }

        #endregion

        #region Ekran 5: Listeleme Ekranı

        private void btnListeOgrenciDersleri_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtListeOgrenciNo.Text, out int ogrenciNo))
            {
                MessageBox.Show("Geçerli bir öğrenci numarası girin.");
                return;
            }

            using (var db = new ProjeContext())
            {
                dgvListeOgrenciDersleri.DataSource = db.OgrenciDersleri
                    .Where(od => od.ogrenciID == ogrenciNo)
                    .Select(od => new
                    {
                        DersAdi = od.Ders.dersAd,
                        od.yil,
                        od.yariyil,
                        VizeNotu = od.vize,
                        FinalNotu = od.final
                    }).ToList();
            }
        }

        private void btnListeDersSayilari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtListeYil.Text) || cmbListeYariyil.SelectedItem == null)
            {
                MessageBox.Show("Lütfen yıl ve yarıyıl bilgilerini girin.");
                return;
            }

            int yil = int.Parse(txtListeYil.Text);
            string yariyil = cmbListeYariyil.SelectedItem.ToString();

            using (var db = new ProjeContext())
            {
                dgvListeDersSayilari.DataSource = db.OgrenciDersleri
                    .Where(od => od.yil == yil && od.yariyil == yariyil)
                    .GroupBy(od => od.Ders.dersAd)
                    .Select(g => new
                    {
                        DersAdi = g.Key,
                        OgrenciSayisi = g.Count()
                    }).ToList();
            }
        }

        #endregion

        #region Ekran 6: Not Girişi

        private void NotGirisDersleriDoldur()
        {
            using (var db = new ProjeContext())
            {
                cmbNotDersler.DataSource = db.Dersler.ToList();
                cmbNotDersler.DisplayMember = "dersAd";
                cmbNotDersler.ValueMember = "dersID";
                cmbNotDersler.SelectedIndex = -1;
            }
        }

        private void cmbNotDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNotDersler.SelectedValue == null) return;

            int seciliDersID = (int)cmbNotDersler.SelectedValue;
            using (var db = new ProjeContext())
            {
                var notListesi = db.OgrenciDersleri
                    .Where(od => od.dersID == seciliDersID)
                    .Select(od => new
                    {
                        od.ogrenciID,
                        OgrenciNo = od.Ogrenci.ogrenciID,
                        Ad = od.Ogrenci.ad,
                        Soyad = od.Ogrenci.soyad,
                        Vize = od.vize,
                        Final = od.final
                    }).ToList();

                // DataTable oluştur
                DataTable dt = new DataTable();
                dt.Columns.Add("ogrenciID", typeof(int));
                dt.Columns.Add("OgrenciNo", typeof(int));
                dt.Columns.Add("Ad", typeof(string));
                dt.Columns.Add("Soyad", typeof(string));
                dt.Columns.Add("Vize", typeof(int));
                dt.Columns.Add("Final", typeof(int));

                foreach (var item in notListesi)
                {
                    dt.Rows.Add(item.ogrenciID, item.OgrenciNo, item.Ad, item.Soyad, item.Vize, item.Final);
                }

                dgvNotlar.DataSource = dt;
                dgvNotlar.Columns["ogrenciID"].Visible = false; // ID’yi gizle

                // Sadece Vize ve Final kolonlarını editable yap
                foreach (DataGridViewColumn col in dgvNotlar.Columns)
                {
                    if (col.Name == "Vize" || col.Name == "Final")
                        col.ReadOnly = false;
                    else
                        col.ReadOnly = true;
                }
            }
        }


        private void btnNotlariKaydet_Click(object sender, EventArgs e)
        {
            if (cmbNotDersler.SelectedValue == null) return;

            int seciliDersID = (int)cmbNotDersler.SelectedValue;
            using (var db = new ProjeContext())
            {
                foreach (DataGridViewRow row in dgvNotlar.Rows)
                {
                    if (row.IsNewRow) continue; // Son boş satırı atla

                    // ogrenciID alanı null ise işlemi geç
                    if (row.Cells["ogrenciID"].Value == null)
                        continue;

                    int ogrenciID = Convert.ToInt32(row.Cells["ogrenciID"].Value);

                    var kayit = db.OgrenciDersleri.Find(ogrenciID, seciliDersID);

                    if (kayit != null)
                    {
                        // Vize notunu al, boş veya hatalı ise null yap
                        if (row.Cells["Vize"].Value != null && int.TryParse(row.Cells["Vize"].Value.ToString(), out int vizeNotu))
                            kayit.vize = vizeNotu;
                        else
                            kayit.vize = null;

                        // Final notunu al, boş veya hatalı ise null yap
                        if (row.Cells["Final"].Value != null && int.TryParse(row.Cells["Final"].Value.ToString(), out int finalNotu))
                            kayit.final = finalNotu;
                        else
                            kayit.final = null;
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Notlar başarıyla kaydedildi!");
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void cmbBolumFakulte_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void txtBolumAd_TextChanged(object sender, EventArgs e) { }
        private void dgvBolumler_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void dgvNotlar_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label15_Click(object sender, EventArgs e) { }

        #endregion

        private void dgvListeOgrenciDersleri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

    }
}