using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class Form4_mdi_Yonetici_TalepSorun : Form
    {
        public Form4_mdi_Yonetici_TalepSorun()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        public void talepsorun_yonetici_listele()
        {
            SqlCommand sorgu = new SqlCommand("TalepSorun_Yonetici_Listele", con.baglanti());
            sorgu.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(sorgu);

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            gridView1.Columns["ts_id"].Visible = false;

            gridView1.Columns["ts_id"].Caption = "ID";
            gridView1.Columns["tur_ad"].Caption = "TÜR";
            gridView1.Columns["ts_acıklama"].Caption = "AÇIKLAMA";
            gridView1.Columns["oncelik_duzey_adi"].Caption = "ÖNCELİK DURUMU";
            gridView1.Columns["ts_olusturulma_Tarihi"].Caption = "OLUŞTURULMA TARİHİ";
            gridView1.Columns["ts_Tamamlanma_Durumu"].Caption = "DURUM";

            gridView1.Columns["kullanici_id"].Visible = false;

            gridView1.Columns["kullanici_adi_soyadi"].Caption = "ADI SOYADI";
            gridView1.Columns["bolum_adi"].Caption = "BÖLÜMÜ";

            gridView1.Columns["ts_Tamamlanma_Durumu"].ColumnEdit = repositoryItemTextEdit1;
        }

        private void Form4_mdi_Yonetici_TalepSorun_Load(object sender, EventArgs e)
        {
            talepsorun_yonetici_listele();
        }

        private void Form4_mdi_Yonetici_TalepSorun_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Class_Detay.k_id = gridView1.GetFocusedRowCellValue("ts_id").ToString();
            Class_Detay.k_oncelik_duzeyi = gridView1.GetFocusedRowCellValue("oncelik_duzey_adi").ToString();
            Class_Detay.k_icerik = gridView1.GetFocusedRowCellValue("ts_acıklama").ToString();
            Class_Detay.k_olusturulma_tarihi = gridView1.GetFocusedRowCellValue("ts_olusturulma_Tarihi").ToString();
            Class_Detay.k_tur = gridView1.GetFocusedRowCellValue("tur_ad").ToString();
            Class_Detay.k_tamamlanma_durumu = gridView1.GetFocusedRowCellValue("ts_Tamamlanma_Durumu").ToString();

            Class_Detay.k_kisi_id = gridView1.GetFocusedRowCellValue("kullanici_id").ToString();

            Class_Detay.k_kullanici_adi = gridView1.GetFocusedRowCellValue("kullanici_adi_soyadi").ToString();
            Class_Detay.k_bolum_adi = gridView1.GetFocusedRowCellValue("bolum_adi").ToString();

            Form4_2_GoruntuleTalepDetay form4_2_Goruntule = new Form4_2_GoruntuleTalepDetay();
            form4_2_Goruntule.ShowDialog();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.FieldName == "ts_Tamamlanma_Durumu")
            {
                if ((e.CellValue).ToString() == "True")
                {
                    e.DisplayText = "BAŞARILI";
                    e.Appearance.ForeColor = Color.DarkGreen;
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
                    //e.Appearance.BackColor = Color.FromArgb(60, Color.Salmon);
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
                    //e.Appearance.BackColor = Color.AliceBlue; //DarkSeaGreen
                    //e.Appearance.ForeColor = Color.DarkSalmon;
                    e.Appearance.BackColor = Color.AntiqueWhite;
                    e.Appearance.BackColor2 = Color.FromArgb(60, Color.Lavender);

                }
            }
        }
    }
}
