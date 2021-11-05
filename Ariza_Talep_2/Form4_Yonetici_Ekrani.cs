using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ariza_Talep_2
{
    public partial class Form4_Yonetici_Ekrani : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form4_Yonetici_Ekrani()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        Form4_mdi_Yonetici_TalepSorun f4_Mdi_Yonetici_TalepSorun = new Form4_mdi_Yonetici_TalepSorun();

        public void mesaj_sayisi()
        {
            SqlCommand cmd = new SqlCommand("Okunmamis_Mesaj_Sayisi_Yonetici", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            int sayi_bilgisi = Convert.ToInt32(dt.Rows[0]["sayi"]);

            if (sayi_bilgisi.ToString() == "0")
            {
                barBtn_MesajSayisi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            else
            {
                //barBtn_MesajSayisi.Caption = sayi_bilgisi.ToString();
                barBtn_MesajSayisi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
        }

        private void Form4_Yonetici_Ekrani_Load(object sender, EventArgs e)
        {
            f4_Mdi_Yonetici_TalepSorun.MdiParent = this;
            f4_Mdi_Yonetici_TalepSorun.Show();
            mesaj_sayisi();

        }

        private void barBtn_talepvesorunlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f4_Mdi_Yonetici_TalepSorun.MdiParent = this;
            f4_Mdi_Yonetici_TalepSorun.Show();
        }

        private void barBtn_Goruntule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild1_2 = this.ActiveMdiChild;
            if (activeChild1_2.Name.ToString() == "Form4_mdi_Yonetici_TalepSorun")
            {
                Class_Detay.k_id = f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("ts_id").ToString();
                //Class_Detay.k_konu = f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("ts_konu").ToString();
                Class_Detay.k_oncelik_duzeyi = f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("oncelik_duzey_adi").ToString();
                Class_Detay.k_icerik = f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("ts_acıklama").ToString();
                Class_Detay.k_olusturulma_tarihi = f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("ts_olusturulma_Tarihi").ToString();
                Class_Detay.k_tur = f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("tur_ad").ToString();
                Class_Detay.k_tamamlanma_durumu = f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("ts_Tamamlanma_Durumu").ToString();

                Class_Detay.k_kisi_id = f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("kullanici_id").ToString();

                Class_Detay.k_kullanici_adi = f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("kullanici_adi_soyadi").ToString();
                //Class_Detay.k_kullanici_soyadi = f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("kullanici_soyadi").ToString();
                Class_Detay.k_bolum_adi = f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("bolum_adi").ToString();
                //Class_Detay.k_kullanici_Gorev = f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("kullanici_Gorev").ToString();

                Form4_2_GoruntuleTalepDetay form4_2_Goruntule = new Form4_2_GoruntuleTalepDetay();
                form4_2_Goruntule.ShowDialog();
            }
        }

        private void barBtn_mesajlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild1 = this.ActiveMdiChild;
            if (activeChild1.Name.ToString() != "Form4_mdi_Yonetici_Mesajlar")
            {
                Form4_mdi_Yonetici_Mesajlar f4_Mdi_Yonetici_Mesajlar = new Form4_mdi_Yonetici_Mesajlar();
                f4_Mdi_Yonetici_Mesajlar.MdiParent = this;
                f4_Mdi_Yonetici_Mesajlar.Show();
            }
            mesaj_sayisi();
        }

        private void barBtn_tamamlandi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild1_2 = this.ActiveMdiChild;
            if (activeChild1_2.Name.ToString() == "Form4_mdi_Yonetici_TalepSorun")
            {
                f4_Mdi_Yonetici_TalepSorun.gridView1.SetFocusedRowCellValue("ts_Tamamlanma_Durumu", true);

                SqlCommand cmd = new SqlCommand("TS_Tamamla", con.baglanti());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ts_id", f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("ts_id").ToString());

                cmd.Parameters.AddWithValue("@ts_Tamamlanma_Durumu", "True");

                cmd.ExecuteNonQuery();

                f4_Mdi_Yonetici_TalepSorun.talepsorun_yonetici_listele();
            }
        }

        private void barBtn_tamamlanmadi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild1_2 = this.ActiveMdiChild;
            if (activeChild1_2.Name.ToString() == "Form4_mdi_Yonetici_TalepSorun")
            {
                f4_Mdi_Yonetici_TalepSorun.gridView1.SetFocusedRowCellValue("ts_Tamamlanma_Durumu", false);

                SqlCommand cmd = new SqlCommand("TS_Tamamla", con.baglanti());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ts_id", f4_Mdi_Yonetici_TalepSorun.gridView1.GetFocusedRowCellValue("ts_id").ToString());

                cmd.Parameters.AddWithValue("@ts_Tamamlanma_Durumu", "False");

                cmd.ExecuteNonQuery();

                f4_Mdi_Yonetici_TalepSorun.talepsorun_yonetici_listele();
            }
        }

        internal void barBtn_MesajSayisi_ItemClick(object sender, EventArgs e)
        {
            mesaj_sayisi();
        }

        private void barBtn_Kullanıcilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild2 = this.ActiveMdiChild;
            if (activeChild2.Name.ToString() != "Form4_mdi_KullanicilarGoruntule_Duzenle")
            {
                Form4_mdi_KullanicilarGoruntule_Duzenle f4_Mdi_KullanicilarGoruntule_Duzenle = new Form4_mdi_KullanicilarGoruntule_Duzenle();
                f4_Mdi_KullanicilarGoruntule_Duzenle.MdiParent = this;
                f4_Mdi_KullanicilarGoruntule_Duzenle.Show();
            }
        }

        private void barBtn_Bolumler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild3 = this.ActiveMdiChild;
            if (activeChild3.Name.ToString() != "Form4_mdi_BolumGoruntuleDuzenle")
            {
                Form4_mdi_BolumGoruntuleDuzenle f4_Mdi_BolumGoruntuleDuzenle = new Form4_mdi_BolumGoruntuleDuzenle();
                f4_Mdi_BolumGoruntuleDuzenle.MdiParent = this;
                f4_Mdi_BolumGoruntuleDuzenle.Show();
            }
        }

        private void barBtn_oncelik_duzeyi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild4 = this.ActiveMdiChild;
            if (activeChild4.Name.ToString() != "Form4_mdi_oncelikduzey_eklesil")
            {
                Form4_mdi_oncelikduzey_eklesil f4_Mdi_Oncelikduzey_Eklesil = new Form4_mdi_oncelikduzey_eklesil();
                f4_Mdi_Oncelikduzey_Eklesil.MdiParent = this;
                f4_Mdi_Oncelikduzey_Eklesil.Show();
            }
        }

        private void barBtn_Bildiri_Turu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild5 = this.ActiveMdiChild;
            if (activeChild5.Name.ToString() != "Form4_mdi_bildiri_turu_ekle_sil")
            {
                Form4_mdi_bildiri_turu_ekle_sil f4_Mdi_Bildiri_Turu_Ekle_Sil = new Form4_mdi_bildiri_turu_ekle_sil();
                f4_Mdi_Bildiri_Turu_Ekle_Sil.MdiParent = this;
                f4_Mdi_Bildiri_Turu_Ekle_Sil.Show();
            }
        }

        private void Form4_Yonetici_Ekrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Application.Exit();
        }

        private void barBtn_Beklemede_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
