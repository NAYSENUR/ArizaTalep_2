using DevExpress.XtraGrid.Columns;
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
    public partial class Form2_Kullanici_mdi_TalepveSorunlar : Form
    {
        public Form2_Kullanici_mdi_TalepveSorunlar()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        public void talepsorun_listele()
        {
            SqlCommand sorgu = new SqlCommand("TaleplerveSorunlar_Sorun", con.baglanti());
            sorgu.CommandType = CommandType.StoredProcedure;
            sorgu.Parameters.AddWithValue("@kullanici_id", Class_KullanıcıBilgileri.k_id);

            SqlDataAdapter da = new SqlDataAdapter(sorgu);

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;


            SqlCommand sorgu_2 = new SqlCommand("TaleplerveSorunlar_Talep", con.baglanti());
            sorgu_2.CommandType = CommandType.StoredProcedure;
            sorgu_2.Parameters.AddWithValue("@kullanici_id", Class_KullanıcıBilgileri.k_id);

            SqlDataAdapter da_2 = new SqlDataAdapter(sorgu_2);
            DataTable dt_2 = new DataTable();
            da_2.Fill(dt_2);
            gridControl2.DataSource = dt_2;

            gridView1.Columns["ts_id"].Visible = false;
            //gridView1.Columns["ts_id"].Caption = "ID";

            gridView1.Columns["tur_ad"].Caption = "TÜR";
            //gridView1.Columns["ts_konu"].Caption = "KONU";
            gridView1.Columns["ts_acıklama"].Caption = "AÇIKLAMA";
            gridView1.Columns["oncelik_duzey_adi"].Caption = "ÖNCELİK DURUMU";
            gridView1.Columns["ts_olusturulma_Tarihi"].Caption = "OLUŞTURULMA TARİHİ";
            gridView1.Columns["ts_Tamamlanma_Durumu"].Caption = "TAMAMLANDI";

            gridView1.Columns["ts_Tamamlanma_Durumu"].ColumnEdit = repositoryItemTextEdit1;

            //gridView2.Columns["ts_id"].Caption = "ID";
            gridView2.Columns["ts_id"].Visible = false;

            gridView2.Columns["tur_ad"].Caption = "TÜR";
            gridView2.Columns["ts_acıklama"].Caption = "AÇIKLAMA";
            gridView2.Columns["oncelik_duzey_adi"].Caption = "ÖNCELİK DURUMU";
            gridView2.Columns["ts_olusturulma_Tarihi"].Caption = "OLUŞTURULMA TARİHİ";
            gridView2.Columns["ts_Tamamlanma_Durumu"].Caption = "TAMAMLANDI";
            
            gridView2.Columns["ts_Tamamlanma_Durumu"].ColumnEdit = repositoryItemTextEdit2;
        }

        private void Form2_Kullanici_mdi_TalepveSorunlar_Load(object sender, EventArgs e)
        {
            talepsorun_listele();
        }

        private void gridControl1_MouseUp(object sender, MouseEventArgs e)
        {
            txt_hangi_Grid.Text = "1";
        }

        private void gridControl2_MouseUp(object sender, MouseEventArgs e)
        {
            txt_hangi_Grid.Text = "2";
        }

        private void Form2_Kullanici_mdi_TalepveSorunlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Class_Detay.k_id = gridView1.GetFocusedRowCellValue("ts_id").ToString();
            //Class_Detay.k_konu = gridView1.GetFocusedRowCellValue("ts_konu").ToString();
            Class_Detay.k_oncelik_duzeyi = gridView1.GetFocusedRowCellValue("oncelik_duzey_adi").ToString();
            Class_Detay.k_icerik = gridView1.GetFocusedRowCellValue("ts_acıklama").ToString();
            Class_Detay.k_olusturulma_tarihi = gridView1.GetFocusedRowCellValue("ts_olusturulma_Tarihi").ToString();
            Class_Detay.k_tur = gridView1.GetFocusedRowCellValue("tur_ad").ToString();
            Class_Detay.k_tamamlanma_durumu = gridView1.GetFocusedRowCellValue("ts_Tamamlanma_Durumu").ToString();

            Form3_Goruntule f3_Goruntule = new Form3_Goruntule();
            f3_Goruntule.ShowDialog();
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            Class_Detay.k_id = gridView2.GetFocusedRowCellValue("ts_id").ToString();
            //Class_Detay.k_konu = gridView2.GetFocusedRowCellValue("ts_konu").ToString();
            Class_Detay.k_oncelik_duzeyi = gridView2.GetFocusedRowCellValue("oncelik_duzey_adi").ToString();
            Class_Detay.k_icerik = gridView2.GetFocusedRowCellValue("ts_acıklama").ToString();
            Class_Detay.k_olusturulma_tarihi = gridView2.GetFocusedRowCellValue("ts_olusturulma_Tarihi").ToString();
            Class_Detay.k_tur = gridView2.GetFocusedRowCellValue("tur_ad").ToString();
            Class_Detay.k_tamamlanma_durumu = gridView2.GetFocusedRowCellValue("ts_Tamamlanma_Durumu").ToString();

            Form3_Goruntule f3_Goruntule = new Form3_Goruntule();
            f3_Goruntule.ShowDialog();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "ts_Tamamlanma_Durumu")
            {
                if ((e.CellValue).ToString() == "True")
                {
                    e.DisplayText = "BAŞARILI";
                    e.Appearance.ForeColor = Color.DarkGreen;
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.BackColor2 = Color.Green;
                }
                else if ((e.CellValue).ToString() == "False")
                {
                    e.DisplayText = "BAŞARISIZ";
                    e.Appearance.ForeColor = Color.DarkRed;
                }
                else
                {
                    e.DisplayText = "YENİ";
                    e.Appearance.BackColor = Color.AliceBlue;
                    e.Appearance.ForeColor = Color.DarkSlateBlue;
                }
            }

            if (e.Column.FieldName == "oncelik_duzey_adi")
            {
                if ((e.CellValue).ToString() == "kritik")
                {
                    e.DisplayText = "KRİTİK";
                    e.Appearance.ForeColor = Color.DarkRed;
                    e.Appearance.BackColor = Color.FromArgb(60, Color.LightPink);
                    e.Appearance.BackColor2 = Color.FromArgb(60, Color.Red);
                }
                else if ((e.CellValue).ToString() == "normal")
                {
                    e.DisplayText = "NORMAL";
                    e.Appearance.ForeColor = Color.DarkSlateBlue;
                    e.Appearance.BackColor = Color.AliceBlue;
                    e.Appearance.BackColor2 = Color.LightBlue;

                }
                else
                {
                    e.DisplayText = "DÜŞÜK";
                    e.Appearance.BackColor = Color.AntiqueWhite;
                    e.Appearance.BackColor2 = Color.FromArgb(60, Color.Lavender);
                }
            }
        }

        private void gridView2_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "ts_Tamamlanma_Durumu")
            {
                if ((e.CellValue).ToString() == "True")
                {
                    e.DisplayText = "BAŞARILI";
                    e.Appearance.ForeColor = Color.DarkGreen;
                    e.Appearance.BackColor = Color.LightGreen;
                    e.Appearance.BackColor2 = Color.Green;
                }
                else if ((e.CellValue).ToString() == "False")
                {
                    e.DisplayText = "BAŞARISIZ";
                    e.Appearance.ForeColor = Color.DarkRed;
                }
                else
                {
                    e.DisplayText = "YENİ";
                    e.Appearance.BackColor = Color.AliceBlue;
                    e.Appearance.ForeColor = Color.DarkSlateBlue;
                }
            }

            if (e.Column.FieldName == "oncelik_duzey_adi")
            {
                if ((e.CellValue).ToString() == "kritik")
                {
                    e.DisplayText = "KRİTİK";
                    e.Appearance.ForeColor = Color.DarkRed;
                    e.Appearance.BackColor = Color.FromArgb(60, Color.LightPink);
                    e.Appearance.BackColor2 = Color.FromArgb(60, Color.Red);
                }
                else if ((e.CellValue).ToString() == "normal")
                {
                    e.DisplayText = "NORMAL";
                    e.Appearance.ForeColor = Color.DarkSlateBlue;
                    e.Appearance.BackColor = Color.AliceBlue;
                    e.Appearance.BackColor2 = Color.LightBlue;
                }
                else
                {
                    e.DisplayText = "DÜŞÜK";
                    e.Appearance.BackColor = Color.AntiqueWhite;
                    e.Appearance.BackColor2 = Color.FromArgb(60, Color.Lavender);
                }
            }
        }
    }
}
