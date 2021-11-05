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
    public partial class Form4_mdi_bildiri_turu_ekle_sil : Form
    {
        public Form4_mdi_bildiri_turu_ekle_sil()
        {
            InitializeComponent();
        }

        Sqlbaglantisi con = new Sqlbaglantisi();

        void bildiri_tur_listele()
        {
            SqlCommand cmd = new SqlCommand("Bildiri_Tur_Listele", con.baglanti());

            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            da.Fill(dt);
            gridControl1.DataSource = dt;

            gridView1.Columns[0].Visible = false;

            gridView1.Columns["tur_ad"].Caption = "Tür Adı";
        }
        private void Form4_mdi_bildiri_turu_ekle_sil_Load(object sender, EventArgs e)
        {
            bildiri_tur_listele();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Bildirim_Tur_Ekle", con.baglanti());
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tur_ad", txt_bildiri_turu_adi.Text);

            cmd.ExecuteNonQuery();

            bildiri_tur_listele();
        }

        private void btn_tur_Sil_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Devam Etmek İstediğinizde Seçili Olan Tür Silinecektir", "Devam Etmek İstiyor musunuz ?", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("Bildirim_Tur_Sil", con.baglanti());
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@tur_id", gridView1.GetFocusedRowCellValue("tur_id").ToString());

                cmd.ExecuteNonQuery();

                bildiri_tur_listele();
            }
        }
    }
}
