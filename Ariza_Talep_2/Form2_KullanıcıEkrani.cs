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
    public partial class Form2_KullanıcıEkrani : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form2_KullanıcıEkrani()
        {
            InitializeComponent();
        }
        
        Sqlbaglantisi con = new Sqlbaglantisi();
        Form2_Kullanici_mdi_TalepveSorunlar f2_Kullanici_Mdi_TalepveSorunlar = new Form2_Kullanici_mdi_TalepveSorunlar();

        public void mesaj_sayisi()
        {
            SqlCommand cmd = new SqlCommand("Okunmamis_Mesaj_Sayisi", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mesaj_kisi_id", Class_KullanıcıBilgileri.k_id);

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
                barBtn_MesajSayisi.Caption = sayi_bilgisi.ToString();
                barBtn_MesajSayisi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            //MessageBox.Show("Test", sayi_bilgisi.ToString());
        }

        private void Form2_KullanıcıEkrani_Load(object sender, EventArgs e)
        {
            //Form2_Kullanici_mdi_TalepveSorunlar f2_Kullanici_Mdi_TalepveSorunlar = new Form2_Kullanici_mdi_TalepveSorunlar();
            f2_Kullanici_Mdi_TalepveSorunlar.MdiParent = this;
            f2_Kullanici_Mdi_TalepveSorunlar.Show();
            mesaj_sayisi();
        }


        private void barBtn_talepvesorunlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form activeChild1 = this.ActiveMdiChild;
            //if (activeChild1.Name.ToString() == "Form2_Kullanici_mdi_TalepveSorunlar")
            //{

            f2_Kullanici_Mdi_TalepveSorunlar.MdiParent = this;
            f2_Kullanici_Mdi_TalepveSorunlar.Show();
            //}
        }

        private void barBtn_mesajlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild2 = this.ActiveMdiChild;
            if (activeChild2.Name.ToString() != "Form2_Kullanici_mdi_Mesajlar")
            {
                Form2_Kullanici_mdi_Mesajlar f2_kullanici_mdi_mesajlar = new Form2_Kullanici_mdi_Mesajlar();
                f2_kullanici_mdi_mesajlar.MdiParent = this;
                f2_kullanici_mdi_mesajlar.Show();
            }
            barBtn_MesajSayisi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
        }

        private void barBtn_yenitalep_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form3_Kullanici_TalepBildir f3_Kullanici_TalepBildir = new Form3_Kullanici_TalepBildir();
            f3_Kullanici_TalepBildir.ShowDialog();

            f2_Kullanici_Mdi_TalepveSorunlar.talepsorun_listele();
        }

        private void barBtn_yenisorun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form3_Kullanici_SorunBildir f3_Kullanici_SorunBildir = new Form3_Kullanici_SorunBildir();
            f3_Kullanici_SorunBildir.ShowDialog();

            f2_Kullanici_Mdi_TalepveSorunlar.talepsorun_listele();
        }

        private void Form2_KullanıcıEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Application.Exit();
        }

        private void barBtn_Goruntule_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form activeChild1_2 = this.ActiveMdiChild;
            if (activeChild1_2.Name.ToString() == "Form2_Kullanici_mdi_TalepveSorunlar")
            {
                if (f2_Kullanici_Mdi_TalepveSorunlar.txt_hangi_Grid.Text == "1")
                {
                    Class_Detay.k_id = f2_Kullanici_Mdi_TalepveSorunlar.gridView1.GetFocusedRowCellValue("ts_id").ToString();
                    //Class_Detay.k_konu = f2_Kullanici_Mdi_TalepveSorunlar.gridView1.GetFocusedRowCellValue("ts_konu").ToString();
                    Class_Detay.k_oncelik_duzeyi = f2_Kullanici_Mdi_TalepveSorunlar.gridView1.GetFocusedRowCellValue("oncelik_duzey_adi").ToString();
                    Class_Detay.k_icerik = f2_Kullanici_Mdi_TalepveSorunlar.gridView1.GetFocusedRowCellValue("ts_acıklama").ToString();
                    Class_Detay.k_olusturulma_tarihi = f2_Kullanici_Mdi_TalepveSorunlar.gridView1.GetFocusedRowCellValue("ts_olusturulma_Tarihi").ToString();
                    Class_Detay.k_tur = f2_Kullanici_Mdi_TalepveSorunlar.gridView1.GetFocusedRowCellValue("tur_ad").ToString();
                    Class_Detay.k_tamamlanma_durumu = f2_Kullanici_Mdi_TalepveSorunlar.gridView1.GetFocusedRowCellValue("ts_Tamamlanma_Durumu").ToString();

                    Form3_Goruntule f3_Goruntule = new Form3_Goruntule();
                    f3_Goruntule.ShowDialog();
                }
                else
                {
                    Class_Detay.k_id = f2_Kullanici_Mdi_TalepveSorunlar.gridView2.GetFocusedRowCellValue("ts_id").ToString();
                    
                    Class_Detay.k_oncelik_duzeyi = f2_Kullanici_Mdi_TalepveSorunlar.gridView2.GetFocusedRowCellValue("oncelik_duzey_adi").ToString();
                    Class_Detay.k_icerik = f2_Kullanici_Mdi_TalepveSorunlar.gridView2.GetFocusedRowCellValue("ts_acıklama").ToString();
                    Class_Detay.k_olusturulma_tarihi = f2_Kullanici_Mdi_TalepveSorunlar.gridView2.GetFocusedRowCellValue("ts_olusturulma_Tarihi").ToString();
                    Class_Detay.k_tur = f2_Kullanici_Mdi_TalepveSorunlar.gridView2.GetFocusedRowCellValue("tur_ad").ToString();
                    Class_Detay.k_tamamlanma_durumu = f2_Kullanici_Mdi_TalepveSorunlar.gridView2.GetFocusedRowCellValue("ts_Tamamlanma_Durumu").ToString();

                    Form3_Goruntule f3_Goruntule = new Form3_Goruntule();
                    f3_Goruntule.ShowDialog();
                }
            }
        }
    }
}
