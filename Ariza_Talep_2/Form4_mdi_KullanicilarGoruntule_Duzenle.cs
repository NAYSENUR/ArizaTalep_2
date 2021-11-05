using DevExpress.XtraEditors;
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
    public partial class Form4_mdi_KullanicilarGoruntule_Duzenle : Form
    {
        public Form4_mdi_KullanicilarGoruntule_Duzenle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        public void kullanicilari_listele()
        {
            SqlCommand sorgu = new SqlCommand("Kullanicilari_Listele", con.baglanti());
            sorgu.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da_2 = new SqlDataAdapter(sorgu);

            DataTable dt = new DataTable();
            da_2.Fill(dt);
            gridControl1.DataSource = dt;

            gridView1.Columns["kullanici_id"].Caption = "ID";
            gridView1.Columns["kullanici_adi_soyadi"].Caption = "ADI SOYADI";

            gridView1.Columns["kullanici_sistem_adi"].Caption = "KULLANICI ADI";
            gridView1.Columns["bolum_adi"].Caption = "BÖLÜM";

            gridView1.Columns["Yonetici"].Caption = "YÖNETİCİ";
        }

        private void Form4_mdi_KullanicilarGoruntule_Duzenle_Load(object sender, EventArgs e)
        {
            kullanicilari_listele();
        }

        private void btn_yetki_ver_Click(object sender, EventArgs e)
        {
            gridView1.SetFocusedRowCellValue("Yonetici", true);

            SqlCommand cmd = new SqlCommand("Yetkilendir", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@kullanici_id", gridView1.GetFocusedRowCellValue("kullanici_id").ToString());

            cmd.Parameters.AddWithValue("@yonetici", "True");

            cmd.ExecuteNonQuery();

            kullanicilari_listele();
        }

        private void btn_yetki_iptal_Click(object sender, EventArgs e)
        {
            gridView1.SetFocusedRowCellValue("Yonetici", false);

            SqlCommand cmd = new SqlCommand("Yetkilendir", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@kullanici_id", gridView1.GetFocusedRowCellValue("kullanici_id").ToString());

            cmd.Parameters.AddWithValue("@yonetici", "False");

            cmd.ExecuteNonQuery();

            kullanicilari_listele();
        }

        private void btn_kullanici_düzenle_Click(object sender, EventArgs e)
        {
            Form4_1_Kullanici_Duzenle f4_1_Kullanici_Duzenle = new Form4_1_Kullanici_Duzenle();
            f4_1_Kullanici_Duzenle.ShowDialog();
            kullanicilari_listele();
        }

        private void btn_kullanici_Sil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Devam Etmek İstediğiniz Takdirde Kullanıcı Silinecektir", "Devam Etmek İstiyor musunuz ?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Kullanici_Sil", con.baglanti());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@kullanici_id", gridView1.GetFocusedRowCellValue("kullanici_id").ToString());

                cmd.ExecuteNonQuery();

                kullanicilari_listele();

                XtraMessageBox.Show("Kullanıcı Silindi..");
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            Class_Kullanici_Duzenle.id = gridView1.GetFocusedRowCellValue("kullanici_id").ToString();
            Class_Kullanici_Duzenle.adi = gridView1.GetFocusedRowCellValue("kullanici_adi_soyadi").ToString();
            Class_Kullanici_Duzenle.sistem_adi = gridView1.GetFocusedRowCellValue("kullanici_sistem_adi").ToString();
            Class_Kullanici_Duzenle.bolum_adi = gridView1.GetFocusedRowCellValue("bolum_adi").ToString();
        }
    }
}
