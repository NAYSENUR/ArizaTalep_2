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
    public partial class Form4_mdi_BolumGoruntuleDuzenle : Form
    {
        public Form4_mdi_BolumGoruntuleDuzenle()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        void bolumleri_listele()
        {
            SqlCommand cmd = new SqlCommand("Bolumleri_Listele", con.baglanti());

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            gridView1.Columns[0].Visible = false;

            gridView1.Columns["bolum_adi"].Caption = "Bölüm Adı";
        }

        private void Form4_mdi_BolumGoruntuleDuzenle_Load(object sender, EventArgs e)
        {
            bolumleri_listele();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Bolum_Ekle", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bolum_adi", txt_bolum_adi.Text);

            cmd.ExecuteNonQuery();

            bolumleri_listele();
        }

        private void btn_bolum_Sil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Devam Etmek İstediğinizde Seçili Olan Bölüm Silinecektir", "Devam Etmek İstiyor musunuz ?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Bolum_Sil", con.baglanti());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@bolum_id", gridView1.GetFocusedRowCellValue("bolum_id").ToString());

                cmd.ExecuteNonQuery();

                bolumleri_listele();
            }
        }
    }
}
